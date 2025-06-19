using project.Controller;
using project.Helpers;
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

namespace project.ViewCustomer
{
    public partial class MenuCustomer : UserControl
    {
        public MenuCustomer()
        {
            InitializeComponent();
        }

        private void MenuCustomer_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void LoadMenu()
        {
            List<MenuModel> menus = MenuModel.GetAll();

            flowMenuPanel.Controls.Clear();

            foreach (var menu in menus)
            {
                Panel card = new Panel
                {
                    Width = 180,
                    Height = 160,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    BackColor = Color.White
                };

                Label lblNama = new Label
                {
                    Text = menu.Nama,
                    Dock = DockStyle.Top,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 30
                };

                Label lblHarga = new Label
                {
                    Text = $"Rp {menu.Harga:N0}",
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label lblStok = new Label
                {
                    Text = $"Stok: {menu.Stok}",
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Panel bawah untuk Qty dan tombol Tambah
                Panel bottomPanel = new Panel
                {
                    Dock = DockStyle.Bottom,
                    Height = 40
                };

                NumericUpDown nudQty = new NumericUpDown
                {
                    Width = 50,
                    Minimum = menu.Stok > 0 ? 1 : 0,
                    Maximum = menu.Stok > 0 ? menu.Stok : 1,
                    Value = menu.Stok > 0 ? 1 : 0,
                    Location = new Point(5, 8),
                    Enabled = menu.Stok > 0
                };

                Button btnTambah = new Button
                {
                    Text = "Tambah",
                    Size = new Size(100, 30),
                    Location = new Point(65, 7),
                    BackColor = menu.Stok > 0 ? Color.MediumSeaGreen : Color.Gray,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Enabled = menu.Stok > 0
                };

                // Event handler hanya jika stok > 0
                if (menu.Stok > 0)
                {
                    btnTambah.Click += (sender, e) => BtnTambah_Click(sender, e, menu.IdMenu, nudQty);
                }

                bottomPanel.Controls.Add(nudQty);
                bottomPanel.Controls.Add(btnTambah);

                // Urutan penambahan dari bawah ke atas
                card.Controls.Add(bottomPanel);
                card.Controls.Add(lblStok);
                card.Controls.Add(lblHarga);
                card.Controls.Add(lblNama);

                flowMenuPanel.Controls.Add(card);
            }

        }

        private void BtnTambah_Click(object? sender, EventArgs e, int idMenu, NumericUpDown nudQty)
        {
            int qty = (int)nudQty.Value;

            if (qty <= 0)
            {
                MessageBox.Show("Jumlah tidak boleh 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idAkunCustomer = CustomerSession.IdAkunCustomer;

            var keranjangItem = new KeranjangModel
            {
                IdAkunCustomer = idAkunCustomer,
                IdMenu = idMenu,
                Qty = qty
            };

            bool success = KeranjangController.AddToKeranjang(keranjangItem);

            if (success)
            {
                MessageBox.Show("Berhasil ditambahkan ke keranjang.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal menambahkan ke keranjang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
