using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Piggy.Pages.Componets;
using Piggy.provider;

namespace Piggy.Pages
{
    public partial class Dashboard : Form
    {

        public Point mouseLoaction;
        public Dashboard()
        {
            InitializeComponent();
            Dashboard_Sales_Update();
        }

        public void Dashboard_Sales_Update()
        {
            var getThisMonthSalesQuery = @"
        SELECT SUM(soldPrice)
        FROM pigs 
        WHERE isSold = 1;
    ";

            using (var conn = ConnectionProvider.GetConnection())
            {
                // Execute the SQL query and retrieve the sum of soldPrice
                var TMSQ = conn.Query<int?>(getThisMonthSalesQuery).FirstOrDefault() ?? 0; // Handle nullable value

                // Update the salesMonth control with the formatted sales amount
                salesMonth.Text = "Rs." + TMSQ.ToString(); // Convert to string
            }
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("You are not logged in");
                return;
            }
            var user = Session.CurrentUser.UserName;
            adminName.Text = user;

            Dashboard_Dashboard dash_Dash = new Dashboard_Dashboard(this)
            {
                TopLevel = false,
                TopMost = true,
            };
            Panel_Main.Controls.Add(dash_Dash);
            dash_Dash.Show();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to quit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.ExitThread();

            }
            else
            {
                return;
            }
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


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button_Dashboard_Click(object sender, EventArgs e)
        {
            Panel_Main.Controls.Clear();

            Dashboard_Dashboard dash_Dash = new Dashboard_Dashboard(this)
            {
                TopLevel = false,
                TopMost = true,
            };
            Panel_Main.Controls.Add(dash_Dash);
            dash_Dash.Show();
        }

        private void Button_Pigs_Click(object sender, EventArgs e)
        {
            Panel_Main.Controls.Clear();

            Dashboard_Pigs dash_Pig = new Dashboard_Pigs(this)
            {
                TopLevel = false,
                TopMost = true,
            };
            Panel_Main.Controls.Add(dash_Pig);
            dash_Pig.Show();

        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you to logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();

            }
            else
            {
                return;
            }

        }

        private void TitleBar_Paint(object sender, PaintEventArgs e)
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
