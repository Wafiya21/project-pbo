namespace project.ViewAdmin.Transaksi
{
    partial class TransaksiIndex
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgTransaksi = new Component.CustomTable();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgTransaksi
            // 
            dgTransaksi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgTransaksi.AutoSize = true;
            dgTransaksi.Location = new Point(0, 99);
            dgTransaksi.Margin = new Padding(4);
            dgTransaksi.Name = "dgTransaksi";
            dgTransaksi.Size = new Size(750, 400);
            dgTransaksi.TabIndex = 10;
            dgTransaksi.Load += dgTransaksi_Load;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 51);
            label1.TabIndex = 2;
            label1.Text = "DATA TRANSAKSI";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(750, 75);
            panel1.TabIndex = 9;
            // 
            // TransaksiIndex
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgTransaksi);
            Controls.Add(panel1);
            MinimumSize = new Size(750, 500);
            Name = "TransaksiIndex";
            Size = new Size(750, 500);
            Load += TransaksiIndex_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Component.CustomTable dgTransaksi;
        private Label label1;
        private Panel panel1;
    }
}
