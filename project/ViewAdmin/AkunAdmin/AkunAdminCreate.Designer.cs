namespace project.ViewAdmin.AkunAdmin
{
    partial class AkunAdminCreate
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
            label1 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label2 = new Label();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(12, 40);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(300, 27);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(12, 101);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(300, 27);
            tbPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.DodgerBlue;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.Control;
            btnSimpan.Location = new Point(218, 134);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 40);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // AkunAdminCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 180);
            Controls.Add(btnSimpan);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Name = "AkunAdminCreate";
            Text = "AkunAdminCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label2;
        private Button btnSimpan;
    }
}