namespace project.ViewCustomer
{
    partial class Keranjang
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
            panel1 = new Panel();
            btnCheckout = new Button();
            label1 = new Label();
            dgKeranjang = new project.Component.CustomTable();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCheckout);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(600, 60);
            panel1.TabIndex = 9;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.ForestGreen;
            btnCheckout.Dock = DockStyle.Right;
            btnCheckout.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = SystemColors.Control;
            btnCheckout.Location = new Point(440, 10);
            btnCheckout.Margin = new Padding(2);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(150, 40);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 2;
            label1.Text = "KERANJANG ANDA";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgKeranjang
            // 
            dgKeranjang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgKeranjang.AutoSize = true;
            dgKeranjang.Location = new Point(0, 80);
            dgKeranjang.Name = "dgKeranjang";
            dgKeranjang.Size = new Size(600, 320);
            dgKeranjang.TabIndex = 10;
            // 
            // Keranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(dgKeranjang);
            Controls.Add(panel1);
            MinimumSize = new Size(600, 400);
            Name = "Keranjang";
            Size = new Size(600, 400);
            Load += Keranjang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Component.CustomTable dgKeranjang;
        private Button btnCheckout;
    }
}
