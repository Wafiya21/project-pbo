
namespace ADP_Bakery
{
    partial class KonsumenStartForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRegistrasi;
        private System.Windows.Forms.Button btnLoginMember;
        private System.Windows.Forms.Button btnBuatMember;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnRegistrasi = new System.Windows.Forms.Button();
            this.btnLoginMember = new System.Windows.Forms.Button();
            this.btnBuatMember = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.btnRegistrasi.Location = new System.Drawing.Point(90, 30);
            this.btnRegistrasi.Name = "btnRegistrasi";
            this.btnRegistrasi.Size = new System.Drawing.Size(150, 35);
            this.btnRegistrasi.Text = "Registrasi Konsumen";
            this.btnRegistrasi.Click += new System.EventHandler(this.btnRegistrasi_Click);

            this.btnLoginMember.Location = new System.Drawing.Point(90, 75);
            this.btnLoginMember.Name = "btnLoginMember";
            this.btnLoginMember.Size = new System.Drawing.Size(150, 35);
            this.btnLoginMember.Text = "Login Member";
            this.btnLoginMember.Click += new System.EventHandler(this.btnLoginMember_Click);

            this.btnBuatMember.Location = new System.Drawing.Point(90, 120);
            this.btnBuatMember.Name = "btnBuatMember";
            this.btnBuatMember.Size = new System.Drawing.Size(150, 35);
            this.btnBuatMember.Text = "Buat Member";
            this.btnBuatMember.Click += new System.EventHandler(this.btnBuatMember_Click);

            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.btnRegistrasi);
            this.Controls.Add(this.btnLoginMember);
            this.Controls.Add(this.btnBuatMember);
            this.Name = "KonsumenStartForm";
            this.Text = "Masuk Sebagai Konsumen";
            this.ResumeLayout(false);
        }
    }
}
