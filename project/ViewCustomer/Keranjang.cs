using project.Controller;
using project.Helpers;
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
    public partial class Keranjang : UserControl
    {
        public Keranjang()
        {
            InitializeComponent();
        }

        private void Keranjang_Load(object sender, EventArgs e)
        {
            dgKeranjang.Grid.Columns.Clear();
            dgKeranjang.Grid.AutoGenerateColumns = false;

            var colId = new DataGridViewTextBoxColumn
            {
                Name = "IdKeranjang",
                DataPropertyName = "IdKeranjang",
                Visible = false
            };
            dgKeranjang.Grid.Columns.Add(colId);

            dgKeranjang.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Menu",
                DataPropertyName = "NamaMenu"
            });

            dgKeranjang.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tersedia",
                DataPropertyName = "Stok"
            });

            dgKeranjang.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Jumlah",
                DataPropertyName = "Qty",
            });

            dgKeranjang.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Harga",
                DataPropertyName = "HargaSatuan",
                DefaultCellStyle = { Format = "C0" }
            });

            dgKeranjang.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total",
                DataPropertyName = "HargaTotal",
                DefaultCellStyle = { Format = "C0" }
            });

            dgKeranjang.Grid.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnHapus",
                HeaderText = "",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            });

            dgKeranjang.Grid.CellClick += DgKeranjang_CellClick;
            LoadKeranjang();
        }

        private void DgKeranjang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgKeranjang.Grid.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                int idKeranjang = Convert.ToInt32(
                    dgKeranjang.Grid.Rows[e.RowIndex].Cells["IdKeranjang"].Value);

                if (MessageBox.Show("Hapus item ini dari keranjang?",
                                    "Konfirmasi",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (KeranjangController.DeleteFromKeranjang(idKeranjang))
                        LoadKeranjang();
                    else
                        MessageBox.Show("Gagal hapus item.", "Error",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadKeranjang()
        {
            int idUser = CustomerSession.IdAkunCustomer;
            var listKeranjang = KeranjangController.GetKeranjangByUserId(idUser);
            dgKeranjang.Grid.DataSource = listKeranjang;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                int idAkunCust = CustomerSession.IdAkunCustomer;
                bool sukses = KeranjangController.Checkout(idAkunCust);
                if (sukses)
                {
                    MessageBox.Show("Checkout berhasil!", "Sukses");
                    LoadKeranjang();
                }
                else
                {
                    MessageBox.Show("Keranjang kosong atau checkout gagal.", "Gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal checkout: {ex.Message}", "Error");
            }
        }
    }
}
