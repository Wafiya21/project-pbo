namespace project.ViewAdmin.AkunCustomer
{
    partial class AkunCustomerCreate
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
            btnSimpan = new Button();
            tbPassword = new TextBox();
            label2 = new Label();
            tbUsername = new TextBox();
            label1 = new Label();
            cbMember = new CheckBox();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.DodgerBlue;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.Control;
            btnSimpan.Location = new Point(212, 134);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 40);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(12, 101);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(300, 27);
            tbPassword.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(12, 40);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(300, 27);
            tbUsername.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // cbMember
            // 
            cbMember.AutoSize = true;
            cbMember.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMember.Location = new Point(12, 136);
            cbMember.Name = "cbMember";
            cbMember.Size = new Size(108, 32);
            cbMember.TabIndex = 10;
            cbMember.Text = "Member";
            cbMember.UseVisualStyleBackColor = true;
            // 
            // AkunCustomerCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 185);
            Controls.Add(cbMember);
            Controls.Add(btnSimpan);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Name = "AkunCustomerCreate";
            Text = "AkunCustomerCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private TextBox tbPassword;
        private Label label2;
        private TextBox tbUsername;
        private Label label1;
        private CheckBox cbMember;
    }
}