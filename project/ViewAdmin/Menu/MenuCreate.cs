using project.Controller;
using project.Model;
using System;
using System.Windows.Forms;

namespace project.ViewAdmin.Menu
{
    public partial class MenuCreate : Form
    {
        public MenuCreate()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = tbNama.Text.Trim();
                if (string.IsNullOrWhiteSpace(nama))
                {
                    MessageBox.Show("Nama menu tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(tbHarga.Text.Trim(), out decimal harga) || harga < 0)
                {
                    MessageBox.Show("Harga harus berupa angka positif!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbStok.Text.Trim(), out int stok) || stok < 0)
                {
                    MessageBox.Show("Stok harus berupa angka bulat positif!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newMenu = new MenuModel
                {
                    Nama = nama,
                    Harga = harga,
                    Stok = stok
                };

                bool result = MenuController.AddMenu(newMenu);
                if (result)
                {
                    MessageBox.Show("Menu berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan:\n" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
