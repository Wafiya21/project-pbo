using ADP_Bakery;
using project.Controller;
using project.Helpers;
using project.Model;
using project.ViewAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Username dan password tidak boleh kosong.",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                AkunAdminModel? user = AkunAdminController.Login(username, password);

                if (user != null)
                {
                    AdminSession.CurrentUser = user;

                    MessageBox.Show(
                        $"Selamat datang {user.Username}!",
                        "Login Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ContainerAdmin containerAdmin = new ContainerAdmin();
                    this.Hide();
                    containerAdmin.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Username atau password salah.",
                        "Login Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Login error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartupForm startupForm = new StartupForm();
            startupForm.ShowDialog();
            this.Close();
        }
    }
}
