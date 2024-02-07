namespace Piggy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            PasswordInput = new Label();
            loginBtn = new Button();
            userName = new TextBox();
            passwordEm = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(554, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 401);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 430);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 1;
            label1.Text = "© 2024 Pig Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi Cond", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 83);
            label2.Name = "label2";
            label2.Size = new Size(86, 37);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(739, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 31);
            panel1.TabIndex = 4;
            panel1.MouseDown += mouse_Down;
            panel1.MouseMove += mouse_Move;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 141);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Username";
            // 
            // PasswordInput
            // 
            PasswordInput.AutoSize = true;
            PasswordInput.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordInput.Location = new Point(29, 203);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(63, 15);
            PasswordInput.TabIndex = 8;
            PasswordInput.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Black;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            loginBtn.FlatAppearance.MouseOverBackColor = Color.DimGray;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.ForeColor = Color.GhostWhite;
            loginBtn.Location = new Point(32, 271);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(256, 40);
            loginBtn.TabIndex = 9;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click_1;
            // 
            // userName
            // 
            userName.AccessibleName = "";
            userName.BackColor = Color.Silver;
            userName.BorderStyle = BorderStyle.None;
            userName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            userName.Location = new Point(32, 161);
            userName.Margin = new Padding(10, 3, 3, 3);
            userName.Name = "userName";
            userName.Size = new Size(256, 27);
            userName.TabIndex = 10;
            // 
            // passwordEm
            // 
            passwordEm.AccessibleName = "";
            passwordEm.BackColor = Color.Silver;
            passwordEm.BorderStyle = BorderStyle.None;
            passwordEm.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordEm.Location = new Point(32, 221);
            passwordEm.Name = "passwordEm";
            passwordEm.PasswordChar = '*';
            passwordEm.Size = new Size(256, 27);
            passwordEm.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("AMS Aakash", 75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(251, -71);
            label4.Name = "label4";
            label4.Size = new Size(284, 290);
            label4.TabIndex = 12;
            label4.Text = "var[h";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(773, 450);
            Controls.Add(panel1);
            Controls.Add(passwordEm);
            Controls.Add(userName);
            Controls.Add(loginBtn);
            Controls.Add(PasswordInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label3;
        private Label PasswordInput;
        private Button loginBtn;
        private TextBox userName;
        private TextBox passwordEm;
        private Label label4;
    }
}