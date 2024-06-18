﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantumSerpent
{
    public partial class Multiplayer : Form
    {
        MainMenu mainMenu;
        public Multiplayer(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void Multiplayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainMenu.Visible == false) mainMenu.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            _ = new IPBox(this).ShowDialog();
        }
        private void btnHost_Click(object sender, EventArgs e)
        {
            HostServerForm hostServerForm = new HostServerForm(this);
            hostServerForm.ShowDialog();
        }
    }
}
