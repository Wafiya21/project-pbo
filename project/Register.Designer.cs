namespace project
{
    partial class Register
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
            btnDaftar = new Button();
            label4 = new Label();
            tbPassword = new TextBox();
            label3 = new Label();
            tbUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            tbNoHp = new TextBox();
            btnKembali = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.Green;
            btnDaftar.Dock = DockStyle.Right;
            btnDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.ForeColor = SystemColors.Control;
            btnDaftar.Location = new Point(153, 0);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(147, 50);
            btnDaftar.TabIndex = 24;
            btnDaftar.Text = "DAFTAR";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 225);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 23;
            label4.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(91, 256);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(300, 34);
            tbPassword.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 157);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 21;
            label3.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(91, 188);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(300, 34);
            tbUsername.TabIndex = 20;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 96);
            label2.Name = "label2";
            label2.Size = new Size(382, 38);
            label2.TabIndex = 19;
            label2.Text = "ADP Bakery";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(382, 46);
            label1.TabIndex = 18;
            label1.Text = "Daftar Akun Baru";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(91, 293);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 26;
            label5.Text = "No HP";
            // 
            // tbNoHp
            // 
            tbNoHp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNoHp.Location = new Point(91, 324);
            tbNoHp.Name = "tbNoHp";
            tbNoHp.Size = new Size(300, 34);
            tbNoHp.TabIndex = 25;
            // 
            // btnKembali
            // 
            btnKembali.AutoSize = true;
            btnKembali.BackColor = Color.Blue;
            btnKembali.Dock = DockStyle.Left;
            btnKembali.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = SystemColors.Control;
            btnKembali.Location = new Point(0, 0);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(147, 50);
            btnKembali.TabIndex = 27;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDaftar);
            panel1.Controls.Add(btnKembali);
            panel1.Location = new Point(91, 413);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 50);
            panel1.TabIndex = 28;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 544);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(tbNoHp);
            Controls.Add(label4);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(500, 999);
            MinimumSize = new Size(500, 500);
            Name = "Register";
            Padding = new Padding(50);
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDaftar;
        private Label label4;
        private TextBox tbPassword;
        private Label label3;
        private TextBox tbUsername;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox tbNoHp;
        private Button btnKembali;
        private Panel panel1;
    }
}