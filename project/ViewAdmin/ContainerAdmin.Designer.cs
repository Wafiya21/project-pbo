namespace project.ViewAdmin
{
    partial class ContainerAdmin
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
            btnTransaksi = new Button();
            btnMenu = new Button();
            btnAkunCustomer = new Button();
            btnAkunAdmin = new Button();
            panelContent = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnLogout = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnTransaksi);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnAkunCustomer);
            panel1.Controls.Add(btnAkunAdmin);
            panel1.Location = new Point(12, 12);
            panel1.Margin = new Padding(15);
            panel1.MaximumSize = new Size(250, 9999);
            panel1.MinimumSize = new Size(250, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(250, 429);
            panel1.TabIndex = 0;
            // 
            // btnTransaksi
            // 
            btnTransaksi.Dock = DockStyle.Top;
            btnTransaksi.Location = new Point(15, 165);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(220, 50);
            btnTransaksi.TabIndex = 3;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.Location = new Point(15, 115);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(220, 50);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnAkunCustomer
            // 
            btnAkunCustomer.Dock = DockStyle.Top;
            btnAkunCustomer.Location = new Point(15, 65);
            btnAkunCustomer.Name = "btnAkunCustomer";
            btnAkunCustomer.Size = new Size(220, 50);
            btnAkunCustomer.TabIndex = 1;
            btnAkunCustomer.Text = "Akun Customer";
            btnAkunCustomer.UseVisualStyleBackColor = true;
            btnAkunCustomer.Click += btnAkunCustomer_Click;
            // 
            // btnAkunAdmin
            // 
            btnAkunAdmin.Dock = DockStyle.Top;
            btnAkunAdmin.Location = new Point(15, 15);
            btnAkunAdmin.Name = "btnAkunAdmin";
            btnAkunAdmin.Size = new Size(220, 50);
            btnAkunAdmin.TabIndex = 0;
            btnAkunAdmin.Text = "Akun Admin";
            btnAkunAdmin.UseVisualStyleBackColor = true;
            btnAkunAdmin.Click += btnAkunAdmin_Click;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.AutoSize = true;
            panelContent.Location = new Point(280, 12);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(690, 429);
            panelContent.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(15, 364);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 50);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // ContainerAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(982, 453);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Name = "ContainerAdmin";
            Text = "Container";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAkunAdmin;
        private Button btnAkunCustomer;
        private Button btnTransaksi;
        private Button btnMenu;
        private Panel panelContent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnLogout;
    }
}