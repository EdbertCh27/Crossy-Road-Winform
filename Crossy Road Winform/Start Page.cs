using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossy_Road_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void judul_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 AfterStart = new Form2();
            AfterStart.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
