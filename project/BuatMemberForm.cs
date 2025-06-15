using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace ADP_Bakery
{
    public partial class BuatMemberForm : Form
    {
        public BuatMemberForm()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string noTelp = txtNoTelp.Text.Trim();
            string alamat = txtAlamat.Text.Trim();

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(noTelp) || string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("Semua field wajib diisi.");
                return;
            }

            DialogResult hasil = MessageBox.Show("Anda yakin ingin mendaftar sebagai member?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (hasil == DialogResult.No) return;

            try
            {
                using (var conn = new NpgsqlConnection(Database.ConnString))
                {
                    conn.Open();
                    string query = "INSERT INTO member (nama_member, no_telepon) VALUES (@nama, @noTelp)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@noTelp", noTelp);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pendaftaran member berhasil!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}