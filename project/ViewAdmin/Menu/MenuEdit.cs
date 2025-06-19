using project.Controller;
using project.Model;
using System;
using System.Windows.Forms;

namespace project.ViewAdmin.Menu
{
    public partial class MenuEdit : Form
    {
        private readonly MenuModel _menu;

        public MenuEdit(MenuModel menu)
        {
            InitializeComponent();
            _menu = menu;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MenuEdit_Load(object sender, EventArgs e)
        {
            // Isi field dengan data lama
            tbNama.Text = _menu.Nama;
            tbHarga.Text = _menu.Harga.ToString();
            tbStok.Text = _menu.Stok.ToString();
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

                // Set nilai baru
                _menu.Nama = nama;
                _menu.Harga = harga;
                _menu.Stok = stok;

                bool result = MenuController.UpdateMenu(_menu);
                if (result)
                {
                    MessageBox.Show("Menu berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan:\n" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
