namespace project.ViewAdmin.Menu
{
    partial class MenuIndex
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
            btnTambah = new Button();
            label1 = new Label();
            panel1 = new Panel();
            dgMenu = new Component.CustomTable();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DarkGreen;
            btnTambah.Dock = DockStyle.Right;
            btnTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(620, 12);
            btnTambah.Margin = new Padding(4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(118, 51);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 2;
            label1.Text = "DATA MENU";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(750, 75);
            panel1.TabIndex = 7;
            // 
            // dgMenu
            // 
            dgMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgMenu.AutoSize = true;
            dgMenu.Location = new Point(0, 100);
            dgMenu.Margin = new Padding(4);
            dgMenu.Name = "dgMenu";
            dgMenu.Size = new Size(750, 400);
            dgMenu.TabIndex = 8;
            // 
            // MenuIndex
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgMenu);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MinimumSize = new Size(750, 500);
            Name = "MenuIndex";
            Size = new Size(750, 500);
            Load += MenuIndex_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTambah;
        private Label label1;
        private Panel panel1;
        private Component.CustomTable dgMenu;
    }
}
