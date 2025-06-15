using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;

namespace ADP_Bakery
{
    public partial class PembayaranForm : Form
    {
        private List<Tuple<string, string, int, int>> keranjang;

        public PembayaranForm(List<Tuple<string, string, int, int>> keranjang)
        {
            InitializeComponent();
            this.keranjang = keranjang;
            TampilkanStruk();
        }

        private void TampilkanStruk()
        {
            int total = 0;
            string idTransaksi = "TRX" + DateTime.Now.Ticks.ToString().Substring(10);
            lblID.Text = idTransaksi;
            lblWaktu.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            lblToko.Text = "ADP Bakery";

            foreach (var item in keranjang)
            {
                int subTotal = item.Item3 * item.Item4;
                lstRingkasan.Items.Add($"{item.Item2} x{item.Item4} = Rp{subTotal}");
                total += subTotal;
            }

            lblTotal.Text = $"Total: Rp{total}";
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                string idTransaksi = lblID.Text;
                string queryTransaksi = "INSERT INTO transaksi (id_transaksi, tanggal) VALUES (@id, @tgl)";
                using (var cmd = new NpgsqlCommand(queryTransaksi, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idTransaksi);
                    cmd.Parameters.AddWithValue("@tgl", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }

                foreach (var item in keranjang)
                {
                    string queryDetail = "INSERT INTO detail_transaksi (id_transaksi, id_produk, jumlah, total_harga) VALUES (@id_trx, @id_prod, @qty, @total)";
                    using (var cmd = new NpgsqlCommand(queryDetail, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_trx", idTransaksi);
                        cmd.Parameters.AddWithValue("@id_prod", item.Item1);
                        cmd.Parameters.AddWithValue("@qty", item.Item4);
                        cmd.Parameters.AddWithValue("@total", item.Item3 * item.Item4);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Transaksi berhasil!");
            this.Close();
        }
    }
}