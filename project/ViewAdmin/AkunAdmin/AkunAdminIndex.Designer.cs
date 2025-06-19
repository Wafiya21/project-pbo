namespace project.ViewAdmin.AkunAdmin
{
    partial class AkunAdminIndex
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
            btnAkun = new Button();
            label1 = new Label();
            panel1 = new Panel();
            dgAkunAdmin = new project.Component.CustomTable();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAkun
            // 
            btnAkun.BackColor = Color.DarkGreen;
            btnAkun.Dock = DockStyle.Right;
            btnAkun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAkun.ForeColor = Color.White;
            btnAkun.Location = new Point(496, 10);
            btnAkun.Name = "btnAkun";
            btnAkun.Size = new Size(94, 40);
            btnAkun.TabIndex = 1;
            btnAkun.Text = "Tambah";
            btnAkun.UseVisualStyleBackColor = false;
            btnAkun.Click += btnAkun_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 2;
            label1.Text = "DATA AKUN ADMIN";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAkun);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(600, 60);
            panel1.TabIndex = 3;
            // 
            // dgAkunAdmin
            // 
            dgAkunAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgAkunAdmin.AutoSize = true;
            dgAkunAdmin.Location = new Point(0, 80);
            dgAkunAdmin.Name = "dgAkunAdmin";
            dgAkunAdmin.Size = new Size(600, 320);
            dgAkunAdmin.TabIndex = 4;
            // 
            // AkunAdminIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(dgAkunAdmin);
            Controls.Add(panel1);
            Margin = new Padding(0);
            MinimumSize = new Size(600, 400);
            Name = "AkunAdminIndex";
            Size = new Size(600, 400);
            Load += AkunAdminIndex_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAkun;
        private Label label1;
        private Panel panel1;
        private Component.CustomTable dgAkunAdmin;
    }
}
