
using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace ADP_Bakery
{
    public partial class RegistrasiKonsumenForm : Form
    {
        public RegistrasiKonsumenForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string noTelp = txtNoTelp.Text.Trim();

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(noTelp))
            {
                MessageBox.Show("Nama dan No Telp harus diisi.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(Database.ConnString))
                {
                    conn.Open();

                    // Ambil jumlah customer saat ini
                    string getCountQuery = "SELECT COUNT(*) FROM customer";
                    int count = 0;

                    using (var cmdCount = new NpgsqlCommand(getCountQuery, conn))
                    {
                        count = Convert.ToInt32(cmdCount.ExecuteScalar());
                    }

                    // Generate ID_Customer baru
                    string idCustomer = "CS" + (count + 1).ToString("D2"); // contoh: CS01, CS02, ...

                    // Query insert
                    string query = "INSERT INTO customer (id_customer, nama_customer, no_telepon) VALUES (@id, @nama, @no_telp)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idCustomer);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@no_telp", noTelp);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registrasi berhasil!");

                    MenuForm menu = new MenuForm();
                    menu.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
