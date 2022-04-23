using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTTP_Server;

namespace SphereClient
{
    public partial class Main_Form : Form
    {
        bool autoCreate = false;
        public Main_Form()
        {
            InitializeComponent();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            string lines = System.IO.File.ReadAllText("server_data.php");
            richTextBox1.Text = lines;
            label1.Text = "Status : START";
            HTTP_Server.Program.StartHTTP(new string[1]
        {
      "http://*:80/"
        });
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            label1.Text = "Status : STOP";
            HTTP_Server.Program.StopHTTP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
