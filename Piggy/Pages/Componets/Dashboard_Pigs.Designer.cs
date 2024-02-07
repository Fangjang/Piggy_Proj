namespace Piggy.Pages.Componets
{
    partial class Dashboard_Pigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Pigs));
            totalPigsCountTop = new Label();
            MalePigCount = new Label();
            FemalePigCount = new Label();
            button2 = new Button();
            Purchase_Pig_Btn = new Button();
            dgvPig = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPig).BeginInit();
            SuspendLayout();
            // 
            // totalPigsCountTop
            // 
            totalPigsCountTop.AutoSize = true;
            totalPigsCountTop.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            totalPigsCountTop.Location = new Point(102, 26);
            totalPigsCountTop.Name = "totalPigsCountTop";
            totalPigsCountTop.Size = new Size(114, 27);
            totalPigsCountTop.TabIndex = 0;
            totalPigsCountTop.Text = "Total Pigs : ";
            // 
            // MalePigCount
            // 
            MalePigCount.AutoSize = true;
            MalePigCount.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            MalePigCount.Location = new Point(102, 64);
            MalePigCount.Name = "MalePigCount";
            MalePigCount.Size = new Size(103, 27);
            MalePigCount.TabIndex = 0;
            MalePigCount.Text = "Male : 000";
            MalePigCount.Click += label2_Click;
            // 
            // FemalePigCount
            // 
            FemalePigCount.AutoSize = true;
            FemalePigCount.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FemalePigCount.Location = new Point(102, 101);
            FemalePigCount.Name = "FemalePigCount";
            FemalePigCount.Size = new Size(129, 27);
            FemalePigCount.TabIndex = 0;
            FemalePigCount.Text = "Female  : 000";
            FemalePigCount.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(850, 26);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 5;
            button2.Text = "Sell Pig";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Purchase_Pig_Btn
            // 
            Purchase_Pig_Btn.BackColor = Color.ForestGreen;
            Purchase_Pig_Btn.FlatAppearance.BorderSize = 0;
            Purchase_Pig_Btn.FlatStyle = FlatStyle.Flat;
            Purchase_Pig_Btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Purchase_Pig_Btn.ForeColor = Color.Snow;
            Purchase_Pig_Btn.ImageAlign = ContentAlignment.BottomCenter;
            Purchase_Pig_Btn.Location = new Point(850, 88);
            Purchase_Pig_Btn.Name = "Purchase_Pig_Btn";
            Purchase_Pig_Btn.Size = new Size(150, 40);
            Purchase_Pig_Btn.TabIndex = 5;
            Purchase_Pig_Btn.TabStop = false;
            Purchase_Pig_Btn.Text = "Purchase Pig";
            Purchase_Pig_Btn.UseVisualStyleBackColor = false;
            Purchase_Pig_Btn.Click += Purchase_Pig_Btn_Click;
            // 
            // dgvPig
            // 
            dgvPig.AllowUserToAddRows = false;
            dgvPig.AllowUserToDeleteRows = false;
            dgvPig.AllowUserToResizeColumns = false;
            dgvPig.AllowUserToResizeRows = false;
            dgvPig.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvPig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPig.Location = new Point(102, 150);
            dgvPig.MultiSelect = false;
            dgvPig.Name = "dgvPig";
            dgvPig.ReadOnly = true;
            dgvPig.RowHeadersWidth = 100;
            dgvPig.RowTemplate.Height = 25;
            dgvPig.Size = new Size(898, 466);
            dgvPig.TabIndex = 6;
            // 
            // Dashboard_Pigs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 647);
            Controls.Add(dgvPig);
            Controls.Add(Purchase_Pig_Btn);
            Controls.Add(button2);
            Controls.Add(FemalePigCount);
            Controls.Add(MalePigCount);
            Controls.Add(totalPigsCountTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard_Pigs";
            Text = "Dashboard_Pigs";
            Load += Dashboard_Pigs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalPigsCountTop;
        private Label MalePigCount;
        private Label FemalePigCount;
        private Button button2;
        private Button Purchase_Pig_Btn;
        private DataGridView dgvPig;
    }
}