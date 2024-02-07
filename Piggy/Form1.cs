using Piggy.models;
using Piggy.Pages;
using Piggy.provider;
using Dapper;
namespace Piggy
{
    public partial class Form1 : Form
    {
        public Point mouseLoaction;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLoaction = new Point(-e.X, -e.Y);

        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLoaction.X, mouseLoaction.Y);
                Location = mousePose;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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



        // Handling Login Logic
        private void loginBtn_Click_1(object sender, EventArgs e)
        {

            var username = userName.Text;
            var password = passwordEm.Text;
            // if(username == "" || password == "")
            // {
            //     MessageBox.Show("Please fill in all fields");
            //     return;
            //     }

            using (var conn = ConnectionProvider.GetConnection())
            {
                var dataCountQuery = @"
                        SELECT count(*) FROM users WHERE userPassword = @password 
                    ";

                var dataCount = conn.Query<int>(dataCountQuery, new { password }).FirstOrDefault();

                  
                if (dataCount > 0)
                {
                     var getUserDetails = @"
                        SELECT * FROM users WHERE userPassword = @password
                    ";
                var userDetails = conn.Query<UserModel>(getUserDetails, new { password }).FirstOrDefault();
                Session.CurrentUser = userDetails;
                    this.Hide();
                    var dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }


        }
    }
}