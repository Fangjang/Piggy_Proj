using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piggy.Pages
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox1.BackColor = Color.Transparent;
            ShowSplashScreen();

        }

        private async void ShowSplashScreen()
        {
            await Task.Delay(4000); // Delay for 5 seconds
            this.Hide();
            Form1 loginScreen = new Form1();
            loginScreen.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
