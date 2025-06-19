using project.Controller;
using project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.ViewAdmin.AkunAdmin
{
    public partial class AkunAdminCreate : Form
    {
        public AkunAdminCreate()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mohon isi semua input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Contains(" ") || password.Contains(" "))
            {
                MessageBox.Show("Username dan Password tidak boleh mengandung spasi.");
                return;
            }

            AkunAdminModel cekUsername = AkunAdminController.GetAkunAdminByUsername(username);
            if (cekUsername != null)
            {
                MessageBox.Show("Username sudah digunakan! Silahkan gunakan username lain.");
                return;
            }


            bool IsTambah = AkunAdminController.AddAkunAdmin(
                new AkunAdminModel
                {
                    Username = username,
                    Password = password,
                }
            );

            if (IsTambah)
            {
                MessageBox.Show("Akun admin berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan akun admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
