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
    public partial class IPBox : Form
    {
        Form formCreator;
        public IPBox(Form formCreater)
        {
            InitializeComponent();
            this.formCreator = formCreater;
            formCreator.Hide();
        }

        private void btnCnt_Click(object sender, EventArgs e)
        {
            formCreator.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formCreator.Show();
        }

        private void IPBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnBack_Click(sender, e);   
        }
    }
}
