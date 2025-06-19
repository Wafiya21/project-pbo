using project.Controller;
using project.Model;
using System;
using System.Windows.Forms;

namespace project.ViewAdmin.AkunCustomer
{
    public partial class AkunCustomerEdit : Form
    {
        private AkunCustomerModel _akunCustomer;

        public AkunCustomerEdit(AkunCustomerModel akunCustomer)
        {
            InitializeComponent();
            _akunCustomer = akunCustomer;

            tbUsername.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AkunCustomerEdit_Load(object sender, EventArgs e)
        {
            tbUsername.Text = _akunCustomer.Username;
            tbPassword.Text = _akunCustomer.Password;
            cbMember.Checked = _akunCustomer.IsMember;
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

                _akunCustomer.Username = username;
                _akunCustomer.Password = password;
                _akunCustomer.IsMember = isMember;

                bool success = AkunCustomerController.UpdateAkunCustomer(_akunCustomer);
                if (success)
                {
                    MessageBox.Show("Akun customer berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal mengupdate akun customer.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
