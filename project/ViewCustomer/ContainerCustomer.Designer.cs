namespace project.ViewCustomer
{
    partial class ContainerCustomer
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
            panel1 = new Panel();
            btnKeranjang = new Button();
            btnTransaksi = new Button();
            btnMenu = new Button();
            label1 = new Label();
            btnLogout = new Button();
            panelContent = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnKeranjang);
            panel1.Controls.Add(btnTransaksi);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(12, 12);
            panel1.Margin = new Padding(15);
            panel1.MaximumSize = new Size(9999, 75);
            panel1.MinimumSize = new Size(950, 75);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(958, 75);
            panel1.TabIndex = 2;
            // 
            // btnKeranjang
            // 
            btnKeranjang.Dock = DockStyle.Left;
            btnKeranjang.Location = new Point(412, 12);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(100, 51);
            btnKeranjang.TabIndex = 7;
            btnKeranjang.Text = "Keranjang";
            btnKeranjang.UseVisualStyleBackColor = true;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.Dock = DockStyle.Left;
            btnTransaksi.Location = new Point(312, 12);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(100, 51);
            btnTransaksi.TabIndex = 5;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Left;
            btnMenu.Location = new Point(212, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(100, 51);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(200, 51);
            label1.TabIndex = 6;
            label1.Text = "ADP Bakery";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Dock = DockStyle.Right;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(846, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 51);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.AutoSize = true;
            panelContent.Location = new Point(12, 105);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(958, 336);
            panelContent.TabIndex = 3;
            // 
            // ContainerCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(982, 453);
            Controls.Add(panel1);
            Controls.Add(panelContent);
            MinimumSize = new Size(1000, 500);
            Name = "ContainerCustomer";
            Text = "ContainerCustomer";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnMenu;
        private Panel panelContent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnTransaksi;
        private Label label1;
        private Button btnKeranjang;
    }
}