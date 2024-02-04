using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piggy.Pages
{
    public partial class Dashboard : Form
    {
        public Point mouseLoaction;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void mouse_down_dash(object sender, MouseEventArgs e)
        {
            mouseLoaction = new Point(-e.X, -e.Y);

        }

        private void mouse_move_dash(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLoaction.X, mouseLoaction.Y);
                Location = mousePose;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /*   private void button1_Click(object sender, EventArgs e)
           {
               Form1 form1 = new Form1()
               {
                   TopLevel = false,
                   TopMost = true,
               };
               form1.FormBorderStyle = FormBorderStyle.None;
               form1.Size = new Size(874, 538);

               pchild.Controls.Add(form1);
               form1.Show();
           }*/

    }
}
