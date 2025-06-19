namespace project.ViewCustomer
{
    partial class TransaksiCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransaksiCustomer));
            panel1 = new Panel();
            label1 = new Label();
            dgTransaksi = new Component.CustomTable();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(750, 75);
            panel1.TabIndex = 9;
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
            label1.Text = "TRANSAKSI ANDA";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgTransaksi
            // 
            dgTransaksi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgTransaksi.AutoSize = true;
            dgTransaksi.Location = new Point(0, 221);
            dgTransaksi.Margin = new Padding(4);
            dgTransaksi.Name = "dgTransaksi";
            dgTransaksi.Size = new Size(750, 279);
            dgTransaksi.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12);
            panel2.Size = new Size(750, 134);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.Location = new Point(15, 12);
            label2.Name = "label2";
            label2.Size = new Size(720, 110);
            label2.TabIndex = 0;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TransaksiCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            Controls.Add(dgTransaksi);
            Controls.Add(panel1);
            MinimumSize = new Size(750, 500);
            Name = "TransaksiCustomer";
            Size = new Size(750, 500);
            Load += TransaksiCustomer_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Component.CustomTable dgTransaksi;
        private Panel panel2;
        private Label label2;
    }
}
