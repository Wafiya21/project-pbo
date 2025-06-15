namespace ADP_Bakery
{
    partial class BuatMemberForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnDaftar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.txtNama.Location = new System.Drawing.Point(30, 30);
            this.txtNama.Size = new System.Drawing.Size(200, 22);
            this.txtNama.PlaceholderText = "Nama";

            this.txtNoTelp.Location = new System.Drawing.Point(30, 70);
            this.txtNoTelp.Size = new System.Drawing.Size(200, 22);
            this.txtNoTelp.PlaceholderText = "No Telepon";

            this.txtAlamat.Location = new System.Drawing.Point(30, 110);
            this.txtAlamat.Size = new System.Drawing.Size(200, 22);
            this.txtAlamat.PlaceholderText = "Alamat";

            this.btnDaftar.Location = new System.Drawing.Point(30, 150);
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);

            this.ClientSize = new System.Drawing.Size(280, 220);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.btnDaftar);
            this.Text = "Form Buat Member";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}