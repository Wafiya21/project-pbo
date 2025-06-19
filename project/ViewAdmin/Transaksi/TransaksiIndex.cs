using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.ViewCustomer;

namespace project.ViewAdmin.Transaksi
{
    public partial class TransaksiIndex : UserControl
    {
        public TransaksiIndex()
        {
            InitializeComponent();
        }

        private void TransaksiIndex_Load(object sender, EventArgs e)
        {
            dgTransaksi.Grid.Columns.Clear();
            dgTransaksi.Grid.AutoGenerateColumns = false;

            dgTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdTransaksi",
                HeaderText = "ID Transaksi",
                DataPropertyName = "IdTransaksi"
            });
            dgTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tanggal",
                DataPropertyName = "TanggalTransaksi"
            });

            dgTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Bayar",
                DataPropertyName = "TotalBayar",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
            });

            dgTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Kode Unik",
                DataPropertyName = "KodeUnik"
            });

            dgTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            // Tombol Detail
            dgTransaksi.Grid.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnDetail",
                HeaderText = "",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            });

            // Tombol Ubah Status
            dgTransaksi.Grid.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnUbahStatus",
                HeaderText = "",
                Text = "Ubah Status",
                UseColumnTextForButtonValue = true
            });

            dgTransaksi.Grid.CellClick += DgTransaksi_Grid_CellClick;
            dgTransaksi.Grid.CellFormatting -= Grid_CellFormatting;
            dgTransaksi.Grid.CellFormatting += Grid_CellFormatting;

            LoadTransaksi();
        }

        private void LoadTransaksi()
        {
            var list = Controller.TransaksiController.GetAllTransaksi();
            dgTransaksi.Grid.DataSource = list;
        }

        private void DgTransaksi_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgTransaksi.Grid.Columns[e.ColumnIndex].Name == "btnDetail")
            {
                var idTransaksi = Convert.ToInt32(dgTransaksi.Grid.Rows[e.RowIndex].Cells["IdTransaksi"].Value);
                var detailForm = new TransaksiDetail(idTransaksi);
                detailForm.ShowDialog();
                return;
            }

            if (e.RowIndex >= 0 && dgTransaksi.Grid.Columns[e.ColumnIndex].Name == "btnUbahStatus")
            {
                var row = dgTransaksi.Grid.Rows[e.RowIndex];
                var idTransaksi = Convert.ToInt32(row.Cells["IdTransaksi"].Value);
                var statusSaatIni = row.Cells["Status"].Value?.ToString() ?? "";

                // Tentukan opsi status berdasarkan status saat ini
                List<string> opsi = new();
                switch (statusSaatIni)
                {
                    case "Menunggu Pembayaran":
                        opsi.AddRange(new[] { "Dibatalkan Admin" });
                        break;
                    case "Menunggu Verifikasi":
                        opsi.AddRange(new[] { "Terverifikasi", "Tidak Valid" });
                        break;
                    case "Terverifikasi":
                        opsi.AddRange(new[] { "Terverifikasi" });
                        break;
                    case "Tidak Valid":
                        opsi.AddRange(new[] { "Dibatalkan Admin" });
                        break;
                    case "Dibatalkan":
                        opsi.AddRange(new[] { "Dibatalkan" });
                        break;
                    case "Dibatalkan Admin":
                        opsi.AddRange(new[] { "Dibatalkan Admin" });
                        break;
                }

                // Buat form popup dinamis
                var popup = new Form
                {
                    Text = "Ubah Status",
                    Size = new Size(300, 150),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };
                var combo = new ComboBox { DataSource = opsi, Dock = DockStyle.Top, DropDownStyle = ComboBoxStyle.DropDownList };
                var btnSimpan = new Button { Text = "Simpan", Dock = DockStyle.Bottom, DialogResult = DialogResult.OK, Height = 50 };
                popup.Controls.Add(combo);
                popup.Controls.Add(btnSimpan);

                if (popup.ShowDialog() == DialogResult.OK)
                {
                    string statusBaru = combo.SelectedItem?.ToString() ?? statusSaatIni;
                    if (!string.IsNullOrEmpty(statusBaru) && statusBaru != statusSaatIni)
                    {
                        // Update status di database
                        if (statusBaru == "Dibatalkan Admin")
                        {
                            Controller.TransaksiController.BatalkanTransaksiAdmin(idTransaksi);
                        }
                        else
                        {
                            Controller.TransaksiController.UpdateStatusTransaksi(idTransaksi, statusBaru);
                        }
                        LoadTransaksi();
                    }
                }
                return;
            }
        }

        private void Grid_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = dgTransaksi.Grid;
            if (grid.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
            {
                string status = e.Value.ToString() ?? "";
                DataGridViewCell cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                switch (status)
                {
                    case "Menunggu Pembayaran":
                        cell.Style.BackColor = Color.FromArgb(100, 181, 246); // biru muda
                        cell.Style.ForeColor = Color.Black;
                        break;
                    case "Dibatalkan":
                        cell.Style.BackColor = Color.FromArgb(220, 53, 69); // merah
                        cell.Style.ForeColor = Color.White;
                        break;
                    case "Menunggu Verifikasi":
                        cell.Style.BackColor = Color.FromArgb(255, 193, 7); // kuning
                        cell.Style.ForeColor = Color.Black;
                        break;
                    case "Terverifikasi":
                        cell.Style.BackColor = Color.FromArgb(40, 167, 69); // hijau
                        cell.Style.ForeColor = Color.White;
                        break;
                    case "Tidak Valid":
                        cell.Style.BackColor = Color.FromArgb(189, 189, 189); // abu-abu
                        cell.Style.ForeColor = Color.Black;
                        break;
                    case "Dibatalkan Admin":
                        cell.Style.BackColor = Color.FromArgb(156, 39, 176); // ungu
                        cell.Style.ForeColor = Color.White;
                        break;
                    default:
                        cell.Style.BackColor = Color.White;
                        cell.Style.ForeColor = Color.Black;
                        break;
                }
            }
        }

        private void dgTransaksi_Load(object sender, EventArgs e)
        {

        }
    }
}
