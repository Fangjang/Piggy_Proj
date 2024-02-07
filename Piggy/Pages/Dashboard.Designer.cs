namespace Piggy.Pages
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            SideBarMenu = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            Button_Logout = new Button();
            label2 = new Label();
            salesMonth = new Label();
            Button_Pigs = new Button();
            button_Dashboard = new Button();
            adminName = new Label();
            label5 = new Label();
            roundImage1 = new RoundImage();
            TitleBar = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Panel_Main = new Panel();
            SideBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundImage1).BeginInit();
            TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SideBarMenu
            // 
            SideBarMenu.BackColor = Color.FromArgb(52, 60, 71);
            SideBarMenu.Controls.Add(pictureBox6);
            SideBarMenu.Controls.Add(pictureBox5);
            SideBarMenu.Controls.Add(pictureBox4);
            SideBarMenu.Controls.Add(Button_Logout);
            SideBarMenu.Controls.Add(label2);
            SideBarMenu.Controls.Add(salesMonth);
            SideBarMenu.Controls.Add(Button_Pigs);
            SideBarMenu.Controls.Add(button_Dashboard);
            SideBarMenu.Controls.Add(adminName);
            SideBarMenu.Controls.Add(label5);
            SideBarMenu.Controls.Add(roundImage1);
            SideBarMenu.ForeColor = SystemColors.ButtonHighlight;
            SideBarMenu.Location = new Point(10, 36);
            SideBarMenu.Name = "SideBarMenu";
            SideBarMenu.Size = new Size(193, 816);
            SideBarMenu.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(29, 34, 40);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(30, 415);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Firebrick;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(30, 690);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(29, 34, 40);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(30, 354);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Button_Logout
            // 
            Button_Logout.BackColor = Color.Firebrick;
            Button_Logout.FlatAppearance.BorderSize = 0;
            Button_Logout.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            Button_Logout.FlatStyle = FlatStyle.Flat;
            Button_Logout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Logout.Location = new Point(21, 686);
            Button_Logout.Margin = new Padding(10, 3, 3, 3);
            Button_Logout.Name = "Button_Logout";
            Button_Logout.Padding = new Padding(30, 0, 0, 0);
            Button_Logout.Size = new Size(150, 40);
            Button_Logout.TabIndex = 11;
            Button_Logout.Text = "Logout";
            Button_Logout.UseVisualStyleBackColor = false;
            Button_Logout.Click += Button_Logout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 287);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 10;
            label2.Text = "All Time Sales";
            // 
            // salesMonth
            // 
            salesMonth.AutoSize = true;
            salesMonth.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            salesMonth.Location = new Point(41, 252);
            salesMonth.Name = "salesMonth";
            salesMonth.Size = new Size(104, 32);
            salesMonth.TabIndex = 9;
            salesMonth.Text = "$69,420";
            salesMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Button_Pigs
            // 
            Button_Pigs.BackColor = Color.FromArgb(29, 34, 40);
            Button_Pigs.FlatAppearance.BorderSize = 0;
            Button_Pigs.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 79, 94);
            Button_Pigs.FlatStyle = FlatStyle.Flat;
            Button_Pigs.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Pigs.Location = new Point(21, 410);
            Button_Pigs.Margin = new Padding(10, 3, 3, 3);
            Button_Pigs.Name = "Button_Pigs";
            Button_Pigs.Size = new Size(150, 40);
            Button_Pigs.TabIndex = 8;
            Button_Pigs.Text = "Pigs";
            Button_Pigs.UseVisualStyleBackColor = false;
            Button_Pigs.Click += Button_Pigs_Click;
            // 
            // button_Dashboard
            // 
            button_Dashboard.BackColor = Color.FromArgb(29, 34, 40);
            button_Dashboard.FlatAppearance.BorderSize = 0;
            button_Dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 79, 94);
            button_Dashboard.FlatStyle = FlatStyle.Flat;
            button_Dashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Dashboard.ForeColor = SystemColors.ButtonHighlight;
            button_Dashboard.Location = new Point(21, 349);
            button_Dashboard.Margin = new Padding(10, 3, 3, 3);
            button_Dashboard.Name = "button_Dashboard";
            button_Dashboard.Padding = new Padding(45, 0, 0, 0);
            button_Dashboard.Size = new Size(150, 40);
            button_Dashboard.TabIndex = 7;
            button_Dashboard.Text = "Dashboard";
            button_Dashboard.UseVisualStyleBackColor = false;
            button_Dashboard.Click += button_Dashboard_Click;
            // 
            // adminName
            // 
            adminName.AutoSize = true;
            adminName.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            adminName.ForeColor = Color.White;
            adminName.Location = new Point(67, 176);
            adminName.Name = "adminName";
            adminName.Size = new Size(64, 23);
            adminName.TabIndex = 5;
            adminName.Text = "Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(57, 158);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Welcome back,";
            // 
            // roundImage1
            // 
            roundImage1.BorderStyle = BorderStyle.FixedSingle;
            roundImage1.Image = (Image)resources.GetObject("roundImage1.Image");
            roundImage1.Location = new Point(48, 44);
            roundImage1.Name = "roundImage1";
            roundImage1.Size = new Size(100, 103);
            roundImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundImage1.TabIndex = 0;
            roundImage1.TabStop = false;
            // 
            // TitleBar
            // 
            TitleBar.BackColor = Color.Snow;
            TitleBar.BackgroundImage = (Image)resources.GetObject("TitleBar.BackgroundImage");
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(pictureBox2);
            TitleBar.Controls.Add(label4);
            TitleBar.Controls.Add(pictureBox1);
            TitleBar.Location = new Point(-2, 0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(1361, 130);
            TitleBar.TabIndex = 1;
            TitleBar.Paint += TitleBar_Paint;
            TitleBar.MouseDown += mouse_down_dash;
            TitleBar.MouseMove += mouse_move_dash;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1249, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("AMS Aakash", 70F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(595, -78);
            label4.Name = "label4";
            label4.Size = new Size(268, 273);
            label4.TabIndex = 13;
            label4.Text = "var[h";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1298, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Panel_Main
            // 
            Panel_Main.BackgroundImageLayout = ImageLayout.None;
            Panel_Main.Location = new Point(202, 128);
            Panel_Main.Name = "Panel_Main";
            Panel_Main.Size = new Size(1157, 647);
            Panel_Main.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1358, 774);
            Controls.Add(Panel_Main);
            Controls.Add(SideBarMenu);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            SideBarMenu.ResumeLayout(false);
            SideBarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundImage1).EndInit();
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SideBarMenu;
        private Panel TitleBar;
        private RoundImage roundImage1;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
        private Label adminName;
        private Label label5;
        private Button button_Dashboard;
        private Button Button_Pigs;
        private Label label2;
        private Label salesMonth;
        private Button Button_Logout;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Panel Panel_Main;
    }
}