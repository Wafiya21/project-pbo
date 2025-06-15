
namespace ADP_Bakery
{
    partial class StartupForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnKonsumen;
        private System.Windows.Forms.Button btnKaryawan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnKonsumen = new System.Windows.Forms.Button();
            this.btnKaryawan = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.btnKonsumen.Location = new System.Drawing.Point(90, 40);
            this.btnKonsumen.Name = "btnKonsumen";
            this.btnKonsumen.Size = new System.Drawing.Size(150, 40);
            this.btnKonsumen.Text = "Login sebagai Konsumen";
            this.btnKonsumen.Click += new System.EventHandler(this.btnKonsumen_Click);

            this.btnKaryawan.Location = new System.Drawing.Point(90, 100);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(150, 40);
            this.btnKaryawan.Text = "Login sebagai Karyawan";
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);

            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.btnKonsumen);
            this.Controls.Add(this.btnKaryawan);
            this.Name = "StartupForm";
            this.Text = "Selamat Datang di ADP Bakery";
            this.ResumeLayout(false);
        }
    }
}
