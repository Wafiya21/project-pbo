using project.Controller;
using project.Model;
using project.ViewAdmin.AkunCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.ViewAdmin.AkunCustomer
{
    public partial class AkunCustomerIndex : UserControl
    {
        public AkunCustomerIndex()
        {
            InitializeComponent();
        }

        private void AkunCustomerIndex_Load(object sender, EventArgs e)
        {
            dgAkunCustomer.Grid.AutoGenerateColumns = false;
            dgAkunCustomer.Grid.Columns.Clear();

            var colIdAkunCustomer = new DataGridViewTextBoxColumn();
            colIdAkunCustomer.Name = "IdAkunCustomer";
            colIdAkunCustomer.HeaderText = "ID AkunCustomer";
            colIdAkunCustomer.DataPropertyName = "IdAkunCustomer";
            dgAkunCustomer.Grid.Columns.Add(colIdAkunCustomer);

            var colUsername = new DataGridViewTextBoxColumn();
            colUsername.Name = "Username";
            colUsername.HeaderText = "Username";
            colUsername.DataPropertyName = "Username";
            dgAkunCustomer.Grid.Columns.Add(colUsername);

            var colPassword = new DataGridViewTextBoxColumn();
            colPassword.Name = "Password";
            colPassword.HeaderText = "Password";
            colPassword.DataPropertyName = "Password";
            dgAkunCustomer.Grid.Columns.Add(colPassword);

            var colNoHp = new DataGridViewTextBoxColumn();
            colNoHp.Name = "NoHp";
            colNoHp.HeaderText = "No Hp";
            colNoHp.DataPropertyName = "NoHp";
            dgAkunCustomer.Grid.Columns.Add(colNoHp);

            var colMember = new DataGridViewTextBoxColumn();
            colMember.Name = "Member";
            colMember.HeaderText = "Member";
            colMember.DataPropertyName = "MemberStatus";
            dgAkunCustomer.Grid.Columns.Add(colMember);

            // Kolom button Edit
            var btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            dgAkunCustomer.Grid.Columns.Add(btnEdit);

            // Kolom button Hapus
            var btnHapus = new DataGridViewButtonColumn();
            btnHapus.Name = "btnHapus";
            btnHapus.HeaderText = "";
            btnHapus.Text = "Hapus";
            btnHapus.UseColumnTextForButtonValue = true;
            dgAkunCustomer.Grid.Columns.Add(btnHapus);

            dgAkunCustomer.Grid.CellContentClick += dgAkunCustomer_CellContentClick;

            LoadAkunCustomer();
        }

        private void LoadAkunCustomer()
        {
            try
            {
                List<AkunCustomerModel> listAkunCustomer = AkunCustomerController.GetAllAkunCustomer();
                dgAkunCustomer.Grid.DataSource = listAkunCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat load data", ex.Message);
            }
        }

        private void dgAkunCustomer_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgAkunCustomer.Grid.Rows.Count)
                return;

            DataGridViewColumn? columnEdit = dgAkunCustomer.Grid.Columns["btnEdit"];
            DataGridViewColumn? columnHapus = dgAkunCustomer.Grid.Columns["btnHapus"];

            if (columnEdit != null && e.ColumnIndex == columnEdit.Index)
            {
                if (
                    dgAkunCustomer.Grid.Rows[e.RowIndex].Cells["IdAkunCustomer"] != null
                    && dgAkunCustomer.Grid.Rows[e.RowIndex].Cells["IdAkunCustomer"].Value != null
                )
                {
                    int idAkunCustomer = Convert.ToInt32(
                        dgAkunCustomer.Grid.Rows[e.RowIndex].Cells["IdAkunCustomer"].Value
                    );
                    AkunCustomerModel? akunCustomer = AkunCustomerController.GetAkunCustomerById(idAkunCustomer);
                    if (akunCustomer != null)
                    {
                        using (var editAkunCustomerForm = new AkunCustomerEdit(akunCustomer))
                        {
                            editAkunCustomerForm.ShowDialog();
                            if (editAkunCustomerForm.DialogResult == DialogResult.OK)
                            {
                                LoadAkunCustomer();
                            }
                        }
                    }
                }
            }
            else if (columnHapus != null && e.ColumnIndex == columnHapus.Index)
            {
                if (
                    dgAkunCustomer.Grid.Rows[e.RowIndex].Cells["IdAkunCustomer"] != null
                    && dgAkunCustomer.Grid.Rows[e.RowIndex].Cells["IdAkunCustomer"].Value != null
                )
                {
                    int idAkunCustomer = Convert.ToInt32(
                        dgAkunCustomer.Grid.Rows[e.RowIndex].Cells["IdAkunCustomer"].Value
                    );

                    if (TransaksiController.GetTransaksiByAkunCust(idAkunCustomer) != null) {
                        MessageBox.Show("Akun tidak bisa dihapus karena sudah pernah melakukan transaksi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    AkunCustomerModel? akunCustomer = AkunCustomerController.GetAkunCustomerById(idAkunCustomer);
                    if (
                        akunCustomer != null
                        && MessageBox.Show(
                            $"Apakah yakin ingin menghapus akun customer '{akunCustomer.Username}'?",
                            "Konfirmasi Hapus",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        ) == DialogResult.Yes
                    )
                    {
                        if (AkunCustomerController.DeleteAkunCustomer(idAkunCustomer))
                        {
                            LoadAkunCustomer();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Gagal menghapus akunCustomer.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (var akunCustomerCreate = new AkunCustomerCreate())
            {
                akunCustomerCreate.ShowDialog();
                if (akunCustomerCreate.DialogResult == DialogResult.OK)
                {
                    LoadAkunCustomer();
                }
            }
        }
    }
}
