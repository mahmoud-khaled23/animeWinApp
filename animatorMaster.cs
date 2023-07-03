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
    public partial class animatorMaster : Form
    {
        public animatorMaster()
        {
            InitializeComponent();
        }

        private void animatorMaster_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            movie mv = new movie();
            mv.MdiParent = this.ActiveMdiChild;
            mv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anime an = new anime();
            an.MdiParent = this;
            an.Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void animeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Performer_Button_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manga_Button_Click(object sender, EventArgs e)
        {
            //Manga_Button.ForeColor = System.Drawing.Color.FromArgb(1, 102, 207);
            manga mn = new manga();
            mn.Show();
        }
        
        private void Manga_Button_MouseHover(object sender, EventArgs e)
        {
            master_manga_button.ForeColor = System.Drawing.Color.DarkOrchid;
            master_manga_button.BackColor = System.Drawing.Color.FloralWhite;

        }
        
        private void Manga_Button_MouseLeave(object sender, EventArgs e)
        {
            master_manga_button.ForeColor = System.Drawing.Color.CadetBlue;
            master_manga_button.BackColor = System.Drawing.Color.MistyRose;

        }

        private void action_movie(object sender, ControlEventArgs e)
        {

        }

        private void Writer_Button_Click(object sender, EventArgs e)
        {
            writer wrrr = new writer();
            wrrr.Show();
        }
    }
}
