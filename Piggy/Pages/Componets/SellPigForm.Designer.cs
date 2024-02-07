namespace Piggy.Pages.Componets
{
    partial class SellPigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellPigForm));
            PurchasePigElm = new Button();
            pigIdNice = new TextBox();
            label3 = new Label();
            sellingAmountElm = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // PurchasePigElm
            // 
            PurchasePigElm.BackColor = Color.RoyalBlue;
            PurchasePigElm.FlatAppearance.BorderSize = 0;
            PurchasePigElm.FlatStyle = FlatStyle.Flat;
            PurchasePigElm.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PurchasePigElm.ForeColor = Color.Snow;
            PurchasePigElm.ImageAlign = ContentAlignment.BottomCenter;
            PurchasePigElm.Location = new Point(26, 313);
            PurchasePigElm.Name = "PurchasePigElm";
            PurchasePigElm.Size = new Size(295, 55);
            PurchasePigElm.TabIndex = 20;
            PurchasePigElm.TabStop = false;
            PurchasePigElm.Text = "Sell Pig";
            PurchasePigElm.UseVisualStyleBackColor = false;
            PurchasePigElm.Click += PurchasePigElm_Click;
            // 
            // pigIdNice
            // 
            pigIdNice.AccessibleName = "";
            pigIdNice.BackColor = Color.Silver;
            pigIdNice.BorderStyle = BorderStyle.None;
            pigIdNice.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            pigIdNice.Location = new Point(26, 131);
            pigIdNice.Margin = new Padding(10, 3, 3, 3);
            pigIdNice.Name = "pigIdNice";
            pigIdNice.Size = new Size(295, 34);
            pigIdNice.TabIndex = 22;
            pigIdNice.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(78, 97);
            label3.Name = "label3";
            label3.Size = new Size(198, 18);
            label3.TabIndex = 21;
            label3.Text = "Enter Pig tag number / ID";
            // 
            // sellingAmountElm
            // 
            sellingAmountElm.AccessibleName = "";
            sellingAmountElm.BackColor = Color.Silver;
            sellingAmountElm.BorderStyle = BorderStyle.None;
            sellingAmountElm.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            sellingAmountElm.Location = new Point(26, 229);
            sellingAmountElm.Margin = new Padding(10, 3, 3, 3);
            sellingAmountElm.Name = "sellingAmountElm";
            sellingAmountElm.Size = new Size(295, 34);
            sellingAmountElm.TabIndex = 23;
            sellingAmountElm.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(111, 196);
            label1.Name = "label1";
            label1.Size = new Size(122, 18);
            label1.TabIndex = 24;
            label1.Text = "Selling Amount";
            // 
            // SellPigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 406);
            Controls.Add(label1);
            Controls.Add(sellingAmountElm);
            Controls.Add(pigIdNice);
            Controls.Add(label3);
            Controls.Add(PurchasePigElm);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SellPigForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sell pig";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PurchasePigElm;
        private TextBox pigIdNice;
        private Label label3;
        private TextBox sellingAmountElm;
        private Label label1;
    }
}