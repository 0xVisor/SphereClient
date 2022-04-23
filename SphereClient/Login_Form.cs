using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SphereClient
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "SPHERECLIENT@1")
            {
                Main_Form mainForm = new Main_Form();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid key provided!");
                return;
            }
        }
    }
}
