using project.Controller;
using project.Model;
using System;
using System.Windows.Forms;

namespace project.ViewAdmin.AkunAdmin
{
    public partial class AkunAdminEdit : Form
    {
        private AkunAdminModel _akunAdmin;

        public AkunAdminEdit(AkunAdminModel akunAdmin)
        {
            InitializeComponent();
            _akunAdmin = akunAdmin;

            tbUsername.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AkunAdminEdit_Load(object sender, EventArgs e)
        {
            tbUsername.Text = _akunAdmin.Username;
            tbPassword.Text = _akunAdmin.Password;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mohon isi semua input.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _akunAdmin.Username = username;
            _akunAdmin.Password = password;

            bool updated = AkunAdminController.UpdateAkunAdmin(_akunAdmin);
            if (updated)
            {
                MessageBox.Show("Data akun admin berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal mengupdate data akun admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
