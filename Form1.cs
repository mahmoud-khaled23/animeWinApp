using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstWindowsApp
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hidePanelButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.BackColor = Color.Blue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void showPanelButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.BackColor = Color.Blue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
