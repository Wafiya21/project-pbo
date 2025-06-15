using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ADP_Bakery
{
    public partial class MenuForm : Form
    {
        private DataGridView dgvMenu;
        private NumericUpDown nudQty;
        private Button btnTambah;
        private Button btnBayar;

        private readonly string connStr =
            @"Data Source=.;Initial Catalog=ADP_Bakery;Integrated Security=True";

        public MenuForm()
        {
            InitializeComponent();
            this.Load += MenuForm_Load;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            LoadMenu();
            dgvMenu.ClearSelection();
        }

        private void LoadMenu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = @"SELECT ProdukID, NamaProduk AS [Nama Produk],
                                          Harga, Stok
                                   FROM   Produk";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvMenu.DataSource = dt;
                        dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvMenu.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat menu: {ex.Message}");
            }
        }

        // ---------- kode InitializeComponent tidak berubah ----------
        // ---------- plus handler dgvMenu_SelectionChanged (opsional) ----------

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih produk dulu.");
                return;
            }

            string nama = dgvMenu.SelectedRows[0].Cells["Nama Produk"].Value.ToString();
            int qty = (int)nudQty.Value;
            MessageBox.Show($"{qty} × {nama} ditambahkan ke keranjang.");
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lanjut ke pembayaran.");
        }
    }
}
