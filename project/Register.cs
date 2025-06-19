using ADP_Bakery;
using project.Controller;
using project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text?.Trim();
                string password = tbPassword.Text?.Trim();
                string noHp = tbNoHp.Text?.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(noHp))
                {
                    MessageBox.Show(
                        "Username, password, dan no hp tidak boleh kosong.",
                        "Login Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
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

                if (!Regex.IsMatch(noHp, @"^08\d{8,11}$"))
                {
                    MessageBox.Show("Nomor HP harus diawali dengan 08 dan memiliki 10–13 digit angka!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newAkunCust = new AkunCustomerModel
                {
                    Username = username,
                    Password = password,
                    NoHp = noHp
                };

                bool result = AkunCustomerController.AddAkunCustomer(newAkunCust);

                if (result)
                {
                    MessageBox.Show("Registrasi berhasil! Silahkan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginCustomer loginCustomer = new LoginCustomer();
                    loginCustomer.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registrasi gagal!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan:\n" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
