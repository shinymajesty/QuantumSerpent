using System;
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
    public partial class HostServerForm : Form
    {
        Form FormCreator;
        public HostServerForm(Form formCreator)
        {
            InitializeComponent();
            this.FormCreator = formCreator;
        }

        string ServerName;
        int PlayerCount;
        int InitLength;
        int Interval;

        private void HostServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormCreator.Visible == false) FormCreator.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormCreator.Show();
            this.Close();
        }

        private void trackBar_PlayerCount_ValueChanged(object sender, EventArgs e)
        {
            lblSliderCountVal.Text = "Selected: " + trackBar_PlayerCount.Value.ToString();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            this.ServerName = rTB_Name.Text;
            this.PlayerCount = trackBar_PlayerCount.Value;
            this.InitLength = (int)Math.Round(nUD_initLength.Value);
            this.Interval = (int)Math.Round(nUP_Interval.Value);
        }
    }
}
