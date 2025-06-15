
namespace ADP_Bakery
{
    partial class LoginMemberForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.label1.Text = "Nama:";
            this.label1.Location = new System.Drawing.Point(30, 30);

            this.txtNama.Location = new System.Drawing.Point(130, 30);
            this.txtNama.Width = 180;

            this.label2.Text = "Password:";
            this.label2.Location = new System.Drawing.Point(30, 70);

            this.txtPassword.Location = new System.Drawing.Point(130, 70);
            this.txtPassword.Width = 180;
            this.txtPassword.PasswordChar = '*';

            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(130, 110);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.ClientSize = new System.Drawing.Size(360, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginMemberForm";
            this.Text = "Login Member";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
