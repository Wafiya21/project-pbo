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

namespace project.ViewAdmin.AkunAdmin
{
    public partial class AkunAdminIndex : UserControl
    {
        public AkunAdminIndex()
        {
            InitializeComponent();
        }

        private void AkunAdminIndex_Load(object sender, EventArgs e)
        {
            dgAkunAdmin.Grid.AutoGenerateColumns = false;
            dgAkunAdmin.Grid.Columns.Clear();

            var colIdAkunAdmin = new DataGridViewTextBoxColumn();
            colIdAkunAdmin.Name = "IdAkunAdmin";
            colIdAkunAdmin.HeaderText = "ID AkunAdmin";
            colIdAkunAdmin.DataPropertyName = "IdAkunAdmin";
            dgAkunAdmin.Grid.Columns.Add(colIdAkunAdmin);

            var colUsername = new DataGridViewTextBoxColumn();
            colUsername.Name = "Username";
            colUsername.HeaderText = "Username";
            colUsername.DataPropertyName = "Username";
            dgAkunAdmin.Grid.Columns.Add(colUsername);

            var colPassword = new DataGridViewTextBoxColumn();
            colPassword.Name = "Password";
            colPassword.HeaderText = "Password";
            colPassword.DataPropertyName = "Password";
            dgAkunAdmin.Grid.Columns.Add(colPassword);

            // Kolom button Edit
            var btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            dgAkunAdmin.Grid.Columns.Add(btnEdit);

            // Kolom button Hapus
            var btnHapus = new DataGridViewButtonColumn();
            btnHapus.Name = "btnHapus";
            btnHapus.HeaderText = "";
            btnHapus.Text = "Hapus";
            btnHapus.UseColumnTextForButtonValue = true;
            dgAkunAdmin.Grid.Columns.Add(btnHapus);

            dgAkunAdmin.Grid.CellContentClick += dgAkunAdmin_CellContentClick;

            LoadAkunAdmin();
        }

        private void LoadAkunAdmin()
        {
            try
            {
                List<AkunAdminModel> listAkunAdmin = AkunAdminController.GetAllAkunAdmin();
                dgAkunAdmin.Grid.DataSource = listAkunAdmin;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat load data", ex.Message);
            }
        }

        private void dgAkunAdmin_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgAkunAdmin.Grid.Rows.Count)
                return;

            DataGridViewColumn? columnEdit = dgAkunAdmin.Grid.Columns["btnEdit"];
            DataGridViewColumn? columnHapus = dgAkunAdmin.Grid.Columns["btnHapus"];

            if (columnEdit != null && e.ColumnIndex == columnEdit.Index)
            {
                if (
                    dgAkunAdmin.Grid.Rows[e.RowIndex].Cells["IdAkunAdmin"] != null
                    && dgAkunAdmin.Grid.Rows[e.RowIndex].Cells["IdAkunAdmin"].Value != null
                )
                {
                    int idAkunAdmin = Convert.ToInt32(
                        dgAkunAdmin.Grid.Rows[e.RowIndex].Cells["IdAkunAdmin"].Value
                    );
                    AkunAdminModel? akunAdmin = AkunAdminController.GetAkunAdminById(idAkunAdmin);
                    if (akunAdmin != null)
                    {
                        using (var editAkunAdminForm = new AkunAdminEdit(akunAdmin))
                        {
                            editAkunAdminForm.ShowDialog();
                            if (editAkunAdminForm.DialogResult == DialogResult.OK)
                            {
                                LoadAkunAdmin();
                            }
                        }
                    }
                }
            }
            else if (columnHapus != null && e.ColumnIndex == columnHapus.Index)
            {
                if (
                    dgAkunAdmin.Grid.Rows[e.RowIndex].Cells["IdAkunAdmin"] != null
                    && dgAkunAdmin.Grid.Rows[e.RowIndex].Cells["IdAkunAdmin"].Value != null
                )
                {
                    int idAkunAdmin = Convert.ToInt32(
                        dgAkunAdmin.Grid.Rows[e.RowIndex].Cells["IdAkunAdmin"].Value
                    );

                    if (AdminSession.CurrentUser.IdAkunAdmin == idAkunAdmin)
                    {
                        MessageBox.Show("Tidak bisa menghapus diri sendiri!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    AkunAdminModel? akunAdmin = AkunAdminController.GetAkunAdminById(idAkunAdmin);
                    if (
                        akunAdmin != null
                        && MessageBox.Show(
                            $"Apakah yakin ingin menghapus akun admin '{akunAdmin.Username}'?",
                            "Konfirmasi Hapus",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        ) == DialogResult.Yes
                    )
                    {
                        if (AkunAdminController.DeleteAkunAdmin(idAkunAdmin))
                        {
                            LoadAkunAdmin();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Gagal menghapus akunAdmin.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            using (var akunAdminCreate = new AkunAdminCreate())
            {
                akunAdminCreate.ShowDialog();
                if (akunAdminCreate.DialogResult == DialogResult.OK)
                { 
                    LoadAkunAdmin();
                }
            }
        }

    }
}
