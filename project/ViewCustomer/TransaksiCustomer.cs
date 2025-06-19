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
    public partial class TransaksiCustomer : UserControl
    {
        public TransaksiCustomer()
        {
            InitializeComponent();
        }

        private void TransaksiCustomer_Load(object sender, EventArgs e)
        {
            dgTransaksi.Grid.Columns.Clear();
            dgTransaksi.Grid.AutoGenerateColumns = false;

            dgTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tanggal",
                DataPropertyName = "TanggalTransaksi"
            });

            dgTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Bayar",
                DataPropertyName = "TotalBayar"
            });

            dgTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Kode Unik",
                DataPropertyName = "KodeUnik"
            });

            dgTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            // Tambahkan tombol Batalkan
            var btnBatalkan = new DataGridViewButtonColumn();
            btnBatalkan.HeaderText = "";
            btnBatalkan.Text = "Batalkan";
            btnBatalkan.UseColumnTextForButtonValue = true;
            btnBatalkan.Name = "btnBatalkan";
            dgTransaksi.Grid.Columns.Add(btnBatalkan);

            // Tambahkan tombol Sudah Bayar
            var btnSudahBayar = new DataGridViewButtonColumn();
            btnSudahBayar.HeaderText = "";
            btnSudahBayar.Text = "Sudah Bayar";
            btnSudahBayar.UseColumnTextForButtonValue = true;
            btnSudahBayar.Name = "btnSudahBayar";
            dgTransaksi.Grid.Columns.Add(btnSudahBayar);

            // Tambahkan tombol Detail
            var btnDetail = new DataGridViewButtonColumn();
            btnDetail.HeaderText = "";
            btnDetail.Text = "Detail";
            btnDetail.UseColumnTextForButtonValue = true;
            btnDetail.Name = "btnDetail";
            dgTransaksi.Grid.Columns.Add(btnDetail);

            dgTransaksi.Grid.CellClick -= Grid_CellClick;
            dgTransaksi.Grid.CellClick += Grid_CellClick;

            LoadTransaksi();
        }

        private void Grid_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var grid = dgTransaksi.Grid;
            var row = grid.Rows[e.RowIndex];
            var data = row.DataBoundItem;
            if (data == null) return;
            int idTransaksi = 0;
            var prop = data.GetType().GetProperty("IdTransaksi");
            if (prop != null)
            {
                var val = prop.GetValue(data);
                if (val != null && int.TryParse(val.ToString(), out int id))
                {
                    idTransaksi = id;
                }
            }
            string status = data.GetType().GetProperty("Status")?.GetValue(data)?.ToString() ?? "";

            if (grid.Columns[e.ColumnIndex].Name == "btnDetail")
            {
                var detailForm = new TransaksiDetail(idTransaksi);
                detailForm.ShowDialog();
                return;
            }

            if (grid.Columns[e.ColumnIndex].Name == "btnBatalkan")
            {
                if (status == "Menunggu Pembayaran")
                {
                    if (MessageBox.Show("Yakin ingin membatalkan transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Controller.TransaksiController.BatalkanTransaksi(idTransaksi))
                        {
                            MessageBox.Show("Transaksi berhasil dibatalkan.");
                            LoadTransaksi();
                        }
                        else
                        {
                            MessageBox.Show("Gagal membatalkan transaksi.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Transaksi tidak dapat dibatalkan.");
                }
            }
            else if (grid.Columns[e.ColumnIndex].Name == "btnSudahBayar")
            {
                if (status == "Menunggu Pembayaran")
                {
                    if (MessageBox.Show("Konfirmasi pembayaran untuk transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Controller.TransaksiController.KonfirmasiSudahBayar(idTransaksi))
                        {
                            MessageBox.Show("Status transaksi diubah menjadi Menunggu Verifikasi.");
                            LoadTransaksi();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah status transaksi.");
                        }
                    }
                }
                else if (status == "Tidak Valid")
                {
                    if (MessageBox.Show("Transaksi sebelumnya tidak valid. Ajukan ulang konfirmasi pembayaran?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Controller.TransaksiController.KonfirmasiSudahBayar(idTransaksi))
                        {
                            MessageBox.Show("Status transaksi diubah menjadi Menunggu Verifikasi.");
                            LoadTransaksi();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah status transaksi.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Transaksi sudah dibayar atau tidak dapat diubah.");
                }
            }
        }

        private void LoadTransaksi()
        {
            int id = CustomerSession.IdAkunCustomer;
            var list = TransaksiController.GetTransaksiByAkunCust(id);
            dgTransaksi.Grid.DataSource = list;
        }
    }
}
