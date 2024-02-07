namespace Piggy.Pages.Componets
{
    partial class Dashboard_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Dashboard));
            label1 = new Label();
            salesToday = new Label();
            soldTodayElm = new Label();
            profitAllTime = new Label();
            dgvhome = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvhome).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 71);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // salesToday
            // 
            salesToday.AutoSize = true;
            salesToday.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            salesToday.Location = new Point(819, 38);
            salesToday.Name = "salesToday";
            salesToday.Size = new Size(159, 27);
            salesToday.TabIndex = 2;
            salesToday.Text = "Sales Today: 000";
            salesToday.Click += label3_Click;
            // 
            // soldTodayElm
            // 
            soldTodayElm.AutoSize = true;
            soldTodayElm.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            soldTodayElm.Location = new Point(819, 71);
            soldTodayElm.Name = "soldTodayElm";
            soldTodayElm.Size = new Size(150, 27);
            soldTodayElm.TabIndex = 2;
            soldTodayElm.Text = "Sold Today: 000";
            soldTodayElm.Click += label3_Click;
            // 
            // profitAllTime
            // 
            profitAllTime.AutoSize = true;
            profitAllTime.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            profitAllTime.Location = new Point(102, 26);
            profitAllTime.Name = "profitAllTime";
            profitAllTime.Size = new Size(119, 27);
            profitAllTime.TabIndex = 2;
            profitAllTime.Text = "Profit :$ 000";
            profitAllTime.Click += label6_Click;
            // 
            // dgvhome
            // 
            dgvhome.AllowUserToAddRows = false;
            dgvhome.AllowUserToDeleteRows = false;
            dgvhome.AllowUserToResizeColumns = false;
            dgvhome.AllowUserToResizeRows = false;
            dgvhome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhome.Location = new Point(102, 180);
            dgvhome.MultiSelect = false;
            dgvhome.Name = "dgvhome";
            dgvhome.ReadOnly = true;
            dgvhome.RowTemplate.Height = 25;
            dgvhome.Size = new Size(876, 406);
            dgvhome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(102, 149);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 4;
            label2.Text = "Recent Sales";
            // 
            // Dashboard_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 647);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(dgvhome);
            Controls.Add(profitAllTime);
            Controls.Add(soldTodayElm);
            Controls.Add(salesToday);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard_Dashboard";
            Text = "Dashboard_Dashboard";
            ((System.ComponentModel.ISupportInitialize)dgvhome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label salesToday;
        private Label soldTodayElm;
        private Label profitAllTime;
        private DataGridView dgvhome;
        private Label label2;
    }
}