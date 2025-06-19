using project.Controller;
using project.Model;
using System;
using System.Windows.Forms;

namespace project.ViewAdmin.AkunCustomer
{
    public partial class AkunCustomerCreate : Form
    {
        public AkunCustomerCreate()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text.Trim();
                string password = tbPassword.Text.Trim();
                bool isMember = cbMember.Checked;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username dan password wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (username.Contains(" ") || password.Contains(" "))
                {
                    MessageBox.Show("Username dan Password tidak boleh mengandung spasi.");
                    return;
                }

                AkunCustomerModel cekUsername = AkunCustomerController.GetAkunCustomerByUsername(username);
                if (cekUsername != null)
                {
                    MessageBox.Show("Username sudah digunakan! Silahkan gunakan username lain.");
                    return;
                }

                AkunCustomerModel akunBaru = new AkunCustomerModel
                {
                    Username = username,
                    Password = password,
                    IsMember = isMember
                };

                bool success = AkunCustomerController.AddAkunCustomer(akunBaru);
                if (success)
                {
                    MessageBox.Show("Akun customer berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan akun customer.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
