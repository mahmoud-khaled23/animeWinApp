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
    public partial class writer : animatorMaster
    {
        public writer()
        {
            InitializeComponent();
            Load += new EventHandler(writer_Load);
        }

        private void writer_Load(object sender, EventArgs e)
        {

        }

        private void writer_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WritersQuery_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker33 = new DateTimePicker();
            Controls.AddRange(new Control[] { dateTimePicker33 });
            MessageBox.Show(dateTimePicker33.Value.ToString());

            dateTimePicker33.Value = DateTime.Now.AddDays(1);
            MessageBox.Show(dateTimePicker33.Value.ToString());
        }

        private void ModifyDemographic_Button_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void completedAnime_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // the movie is completed

            int x = 8;
        }

        private void presentAnime_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void newestAnime_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void oldestAnime_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void premieredDate_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
