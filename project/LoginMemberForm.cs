
using System;
using System.Windows.Forms;
using Npgsql;

namespace ADP_Bakery
{
    public partial class LoginMemberForm : Form
    {
        public LoginMemberForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Isi semua data.");
                return;
            }

            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                string query = "SELECT * FROM member WHERE nama_member = @nama AND id_member = @password";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login berhasil!");
                            this.Hide();
                            MenuForm menu = new MenuForm ();
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nama atau password salah.");
                        }
                    }
                }
            }
        }
    }
}
