namespace ADP_Bakery
{
    partial class PembayaranForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblToko;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListBox lstRingkasan;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnKonfirmasi;

        private void InitializeComponent()
        {
            this.lblToko = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lstRingkasan = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnKonfirmasi = new System.Windows.Forms.Button();

            this.lblToko.Text = "Nama Toko";
            this.lblToko.Location = new System.Drawing.Point(20, 20);
            this.lblToko.AutoSize = true;

            this.lblID.Text = "ID Transaksi:";
            this.lblID.Location = new System.Drawing.Point(20, 50);
            this.lblID.AutoSize = true;

            this.lblWaktu.Text = "Waktu:";
            this.lblWaktu.Location = new System.Drawing.Point(20, 70);
            this.lblWaktu.AutoSize = true;

            this.lstRingkasan.Location = new System.Drawing.Point(20, 100);
            this.lstRingkasan.Size = new System.Drawing.Size(350, 100);

            this.lblTotal.Text = "Total: ";
            this.lblTotal.Location = new System.Drawing.Point(20, 210);
            this.lblTotal.AutoSize = true;

            this.btnKonfirmasi.Text = "Konfirmasi";
            this.btnKonfirmasi.Location = new System.Drawing.Point(250, 210);
            this.btnKonfirmasi.Click += new System.EventHandler(this.btnKonfirmasi_Click);

            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.lblToko);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.lstRingkasan);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnKonfirmasi);
            this.Text = "Struk Pembayaran";
        }
    }
}