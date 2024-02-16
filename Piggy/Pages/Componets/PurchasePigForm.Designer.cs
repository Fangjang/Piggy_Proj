namespace Piggy.Pages.Componets
{
    partial class PurchasePigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasePigForm));
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            genderElm = new ComboBox();
            label5 = new Label();
            priceElm = new NumericUpDown();
            ageElm = new NumericUpDown();
            weightElm = new NumericUpDown();
            PurchasePigElm = new Button();
            pictureBox1 = new PictureBox();
            breedElm = new RichTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)priceElm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ageElm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weightElm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(346, 31);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 11;
            label3.Text = "Age (Years)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(346, 79);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 13;
            label1.Text = "Weight (KG)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(346, 178);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 15;
            label2.Text = "Sex";
            // 
            // genderElm
            // 
            genderElm.FormattingEnabled = true;
            genderElm.Items.AddRange(new object[] { "M", "F" });
            genderElm.Location = new Point(348, 196);
            genderElm.Name = "genderElm";
            genderElm.Size = new Size(296, 23);
            genderElm.TabIndex = 17;
            genderElm.Text = "m";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(345, 128);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 13;
            label5.Text = "Price";
            // 
            // priceElm
            // 
            priceElm.DecimalPlaces = 2;
            priceElm.Location = new Point(348, 147);
            priceElm.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            priceElm.Name = "priceElm";
            priceElm.Size = new Size(296, 23);
            priceElm.TabIndex = 18;
            // 
            // ageElm
            // 
            ageElm.DecimalPlaces = 1;
            ageElm.Location = new Point(348, 47);
            ageElm.Name = "ageElm";
            ageElm.Size = new Size(296, 23);
            ageElm.TabIndex = 18;
            // 
            // weightElm
            // 
            weightElm.DecimalPlaces = 2;
            weightElm.Location = new Point(348, 96);
            weightElm.Maximum = new decimal(new int[] { 800, 0, 0, 0 });
            weightElm.Name = "weightElm";
            weightElm.Size = new Size(296, 23);
            weightElm.TabIndex = 18;
            // 
            // PurchasePigElm
            // 
            PurchasePigElm.BackColor = Color.ForestGreen;
            PurchasePigElm.FlatAppearance.BorderSize = 0;
            PurchasePigElm.FlatStyle = FlatStyle.Flat;
            PurchasePigElm.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PurchasePigElm.ForeColor = Color.Snow;
            PurchasePigElm.ImageAlign = ContentAlignment.BottomCenter;
            PurchasePigElm.Location = new Point(347, 278);
            PurchasePigElm.Name = "PurchasePigElm";
            PurchasePigElm.Size = new Size(295, 48);
            PurchasePigElm.TabIndex = 19;
            PurchasePigElm.TabStop = false;
            PurchasePigElm.Text = "Purchase Pig";
            PurchasePigElm.UseVisualStyleBackColor = false;
            PurchasePigElm.Click += PurchasePigElm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // breedElm
            // 
            breedElm.BackColor = SystemColors.ButtonHighlight;
            breedElm.BorderStyle = BorderStyle.FixedSingle;
            breedElm.Location = new Point(348, 246);
            breedElm.MaxLength = 99;
            breedElm.Multiline = false;
            breedElm.Name = "breedElm";
            breedElm.ScrollBars = RichTextBoxScrollBars.None;
            breedElm.Size = new Size(294, 26);
            breedElm.TabIndex = 21;
            breedElm.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(346, 228);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 15;
            label4.Text = "Pig Breed";
            // 
            // PurchasePigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(683, 374);
            Controls.Add(breedElm);
            Controls.Add(pictureBox1);
            Controls.Add(PurchasePigElm);
            Controls.Add(weightElm);
            Controls.Add(ageElm);
            Controls.Add(priceElm);
            Controls.Add(genderElm);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PurchasePigForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase a pig";
            ((System.ComponentModel.ISupportInitialize)priceElm).EndInit();
            ((System.ComponentModel.ISupportInitialize)ageElm).EndInit();
            ((System.ComponentModel.ISupportInitialize)weightElm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox genderElm;
        private Label label5;
        private NumericUpDown priceElm;
        private NumericUpDown ageElm;
        private NumericUpDown weightElm;
        private Button PurchasePigElm;
        private PictureBox pictureBox1;
        private RichTextBox breedElm;
        private Label label4;
    }
}