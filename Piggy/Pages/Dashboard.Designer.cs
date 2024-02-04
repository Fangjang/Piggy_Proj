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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            roundImage1 = new RoundImage();
            TitleBar = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            SideBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundImage1).BeginInit();
            TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SideBarMenu
            // 
            SideBarMenu.BackColor = Color.FromArgb(52, 60, 71);
            SideBarMenu.Controls.Add(button3);
            SideBarMenu.Controls.Add(button2);
            SideBarMenu.Controls.Add(button1);
            SideBarMenu.Controls.Add(label6);
            SideBarMenu.Controls.Add(label5);
            SideBarMenu.Controls.Add(roundImage1);
            SideBarMenu.ForeColor = SystemColors.ButtonHighlight;
            SideBarMenu.Location = new Point(17, 22);
            SideBarMenu.Name = "SideBarMenu";
            SideBarMenu.Size = new Size(193, 816);
            SideBarMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(29, 34, 40);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 79, 94);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(23, 509);
            button3.Margin = new Padding(10, 3, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(150, 40);
            button3.TabIndex = 8;
            button3.Text = "Pigs";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(29, 34, 40);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 79, 94);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(23, 407);
            button2.Margin = new Padding(10, 3, 3, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(45, 0, 0, 0);
            button2.Size = new Size(150, 40);
            button2.TabIndex = 7;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 34, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 79, 94);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(23, 457);
            button1.Margin = new Padding(10, 3, 3, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(45, 0, 0, 0);
            button1.Size = new Size(150, 40);
            button1.TabIndex = 6;
            button1.Text = "Employees";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(67, 176);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 5;
            label6.Text = "Admin";
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
            label4.Location = new Point(596, -79);
            label4.Name = "label4";
            label4.Size = new Size(268, 273);
            label4.TabIndex = 13;
            label4.Text = "var[h";
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
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1358, 837);
            Controls.Add(SideBarMenu);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            SideBarMenu.ResumeLayout(false);
            SideBarMenu.PerformLayout();
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
        private Label label6;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}