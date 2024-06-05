using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuantumSerpent
{
    public delegate ((IEnumerable<Position> avoid, IEnumerable<Food> food), (int, int)) WorldInfoFunction();

    public class AIPlayer : Player
    {
        private int[,] adjacencyMatrix;
        private int maxWidth;
        private int maxHeight;
        private WorldInfoFunction GetWorldInfo;

        public AIPlayer(int x, int y, Directions directions, int initLength, WorldInfoFunction getWorldInfo) : base(x, y, directions, initLength)
        {
            HeadColor = Brushes.DarkRed;
            BodyColor = Brushes.Red;
            GetWorldInfo = getWorldInfo;
        }

        public override bool HandleKey(Keys keyCode)
        {
            return false;
        }

        public override void Move(Directions direction)
        {
            // Determine the best direction to move
            direction = FindBestDirection(new Position(X, Y));
            base.Move(direction);
        }

        public Directions FindBestDirection(Position playerPosition)
        {
            // Create the adjacency matrix representing the grid
            CreateAdjacencyMatrix();

            // Find the closest food using A* algorithm
            var closestFood = FindClosestFood(playerPosition);

            // If no food is found, stall for time by moving safely
            if (closestFood == null)
                return FindSafeDirection(playerPosition);

            // Calculate the path to the closest food while avoiding obstacles
            var path = FindPath(playerPosition, closestFood.Position);

            // If path is empty, stall for time by moving safely
            if (path.Count == 0)
                return FindSafeDirection(playerPosition);

            // Calculate the direction to the next position in the path
            var temp = path[0];
            path.RemoveAt(0);
            return CalculateDirection(playerPosition, temp);
        }

        private List<Position> FindPath(Position start, Position goal)
        {
            // Initialize open and closed lists
            var open = new List<Position>();
            var closed = new HashSet<Position>();

            // Add start position to open list
            open.Add(start);

            // Initialize parent map to keep track of the path
            var parent = new Dictionary<Position, Position>();

            // Initialize cost map to keep track of costs
            var costs = new Dictionary<Position, int>();
            costs[start] = 0;

            while (open.Count > 0)
            {
                // Get the position with the lowest cost from the open list
                var current = open.OrderBy(p => costs[p]).First();

                // Remove current position from open list
                open.Remove(current);

                // Add current position to closed list
                closed.Add(current);

                // If goal is reached, reconstruct and return the path
                if (current.Equals(goal))
                    return ReconstructPath(start, goal, parent);

                // Generate successors of current position
                var successors = GetSuccessors(current);

                foreach (var successor in successors)
                {
                    // Skip if successor is in closed list
                    if (closed.Contains(successor))
                        continue;

                    // Calculate tentative cost from start to successor
                    var tentativeCost = CalculateDistance(start, successor);

                    // Add successor to open list if not already there
                    if (!open.Contains(successor))
                    {
                        open.Add(successor);
                        parent[successor] = current;
                        costs[successor] = tentativeCost;
                    }
                    else if (tentativeCost < costs[successor])
                    {
                        // Update cost if new path to successor is better
                        parent[successor] = current;
                        costs[successor] = tentativeCost;
                    }
                }
            }

            // If no path found, return an empty list
            return new List<Position>();
        }

        private List<Position> ReconstructPath(Position start, Position goal, Dictionary<Position, Position> parent)
        {
            // Reconstruct the path from goal to start
            var path = new Stack<Position>();
            var current = goal;

            while (!current.Equals(start))
            {
                path.Push(current);
                current = parent[current];
            }

            return new(path);
        }

        private List<Position> GetSuccessors(Position position)
        {
            var successors = new List<Position>();

            // Define possible moves (up, down, left, right)
            var moves = new List<(int, int)>
            {
                (0, 1),   // Up
                (0, -1),  // Down
                (-1, 0),  // Left
                (1, 0)    // Right
            };

            foreach (var move in moves)
            {
                var newX = position.X + move.Item1;
                var newY = position.Y + move.Item2;

                // Check if new position is within bounds and not an obstacle
                if (newX >= 0 && newX < maxWidth && newY >= 0 && newY < maxHeight &&
                    adjacencyMatrix[newX, newY] != int.MaxValue)
                {
                    successors.Add(new Position(newX, newY));
                }
            }

            return successors;
        }

        private Food FindClosestFood(Position playerPosition)
        {
            var world = GetWorldInfo();

            var food = world.Item1.food;
            Food? closestFood = null;

            // Initialize with maximum distance
            var minDistance = int.MaxValue;

            foreach (var item in food)
            {
                var distance = CalculateDistance(playerPosition, item.Position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestFood = item;
                }
            }

            return closestFood!;
        }

        private int[,] CreateAdjacencyMatrix()
        {
            var world = GetWorldInfo();
            var avoid = world.Item1.avoid;
            var food = world.Item1.food;
            maxWidth = world.Item2.Item1;
            maxHeight = world.Item2.Item2;

            // Initialize the adjacency matrix with dimensions maxWidth x maxHeight
            adjacencyMatrix = new int[maxWidth, maxHeight];

            // Initialize all elements in the matrix to 0 (no connection)
            for (int i = 0; i < maxWidth; i++)
            {
                for (int j = 0; j < maxHeight; j++)
                {
                    adjacencyMatrix[i, j] = 0;
                }
            }

            // Populate the adjacency matrix based on the positions of objects
            foreach (var position in avoid)
            {
                // Check if position is within bounds
                if (position.X >= 0 && position.X < maxWidth && position.Y >= 0 && position.Y < maxHeight)
                {
                    // Mark the position as avoidable (-1)
                    adjacencyMatrix[position.X, position.Y] = int.MaxValue;
                }
            }

            foreach (var item in food)
            {
                // Check if position is within bounds
                if (item.Position.X >= 0 && item.Position.X < maxWidth && item.Position.Y >= 0 && item.Position.Y < maxHeight)
                {
                    // Mark the position as containing food (1)
                    adjacencyMatrix[item.Position.X, item.Position.Y] = 1;
                }
            }

            return adjacencyMatrix;
        }

        public int CalculateDistance(Position start, Position end)
        {
            int deltaX = end.X - start.X;
            int deltaY = end.Y - start.Y;

            return Convert.ToInt32(Math.Floor(Math.Sqrt(deltaX * deltaX + deltaY * deltaY)));
        }

        private Directions CalculateDirection(Position start, Position end)
        {
            // Calculate the direction to move based on the difference in coordinates
            if (start.X < end.X)
                return Directions.Right;
            if (start.X > end.X)
                return Directions.Left;
            if (start.Y < end.Y)
                return Directions.Down;
            if (start.Y > end.Y)
                return Directions.Up;

            // If start and end positions are the same, return default direction
            return Directions.Up;
        }

        private Directions FindSafeDirection(Position playerPosition)
        {
            // Get all possible directions
            var possibleDirections = new List<Directions> { Directions.Up, Directions.Down, Directions.Left, Directions.Right };
            var safeDirections = new List<Directions>();

            foreach (var direction in possibleDirections)
            {
                var newPosition = GetNewPosition(playerPosition, direction);

                // Check if the new position is safe (within bounds and not an obstacle)
                if (newPosition.X >= 0 && newPosition.X < maxWidth && newPosition.Y >= 0 && newPosition.Y < maxHeight &&
                    adjacencyMatrix[newPosition.X, newPosition.Y] != int.MaxValue)
                {
                    safeDirections.Add(direction);
                }
            }

            // If no safe directions are found, return Up as default
            if (safeDirections.Count == 0)
                return Directions.Up;

            // Randomly select a safe direction to stall for time
            var random = new Random();
            int index = random.Next(safeDirections.Count);
            return safeDirections[index];
        }

        private Position GetNewPosition(Position current, Directions direction)
        {
            // Calculate the new position based on the direction
            switch (direction)
            {
                case Directions.Up:
                    return new Position(current.X, current.Y - 1);
                case Directions.Down:
                    return new Position(current.X, current.Y + 1);
                case Directions.Left:
                    return new Position(current.X - 1, current.Y);
                case Directions.Right:
                    return new Position(current.X + 1, current.Y);
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }
    }
}
