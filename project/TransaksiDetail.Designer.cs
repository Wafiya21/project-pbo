namespace project.ViewCustomer
{
    partial class TransaksiDetail
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
            dgDetailTransaksi = new Component.CustomTable();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgDetailTransaksi
            // 
            dgDetailTransaksi.Location = new Point(25, 103);
            dgDetailTransaksi.Name = "dgDetailTransaksi";
            dgDetailTransaksi.Size = new Size(750, 321);
            dgDetailTransaksi.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 25);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(750, 75);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 51);
            label1.TabIndex = 2;
            label1.Text = "DETAIL TRANSAKSI";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TransaksiDetailCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgDetailTransaksi);
            Name = "TransaksiDetailCustomer";
            Text = "TransaksiDetailCustomer";
            Load += TransaksiDetailCustomer_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Component.CustomTable dgDetailTransaksi;
        private Panel panel1;
        private Label label1;
    }
}