namespace project
{
    partial class LoginAdmin
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
            label2 = new Label();
            label1 = new Label();
            tbUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbPassword = new TextBox();
            panel1 = new Panel();
            btnLogin = new Button();
            btnKembali = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(157, 100);
            label2.Name = "label2";
            label2.Size = new Size(167, 38);
            label2.TabIndex = 5;
            label2.Text = "ADP Bakery";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 50);
            label1.Name = "label1";
            label1.Size = new Size(388, 46);
            label1.TabIndex = 4;
            label1.Text = "Selamat Datang Admin";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(100, 200);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(300, 34);
            tbUsername.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 169);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(100, 237);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(100, 268);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(300, 34);
            tbPassword.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnKembali);
            panel1.Location = new Point(100, 338);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 50);
            panel1.TabIndex = 30;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.Dock = DockStyle.Right;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(153, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 50);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
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
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "LoginAdmin";
            Text = "LoginAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox tbUsername;
        private Label label3;
        private Label label4;
        private TextBox tbPassword;
        private Panel panel1;
        private Button btnLogin;
        private Button btnKembali;
    }
}