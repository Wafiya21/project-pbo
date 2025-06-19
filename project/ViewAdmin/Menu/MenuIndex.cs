using project.Controller;
using project.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project.ViewAdmin.Menu
{
    public partial class MenuIndex : UserControl
    {
        public MenuIndex()
        {
            InitializeComponent();
        }

        private void MenuIndex_Load(object sender, EventArgs e)
        {
            dgMenu.Grid.AutoGenerateColumns = false;
            dgMenu.Grid.Columns.Clear();

            // Kolom ID
            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdMenu";
            colId.HeaderText = "ID";
            colId.DataPropertyName = "IdMenu";
            dgMenu.Grid.Columns.Add(colId);

            // Kolom Nama
            var colNama = new DataGridViewTextBoxColumn();
            colNama.Name = "Nama";
            colNama.HeaderText = "Nama";
            colNama.DataPropertyName = "Nama";
            dgMenu.Grid.Columns.Add(colNama);

            // Kolom Harga
            var colHarga = new DataGridViewTextBoxColumn();
            colHarga.Name = "Harga";
            colHarga.HeaderText = "Harga";
            colHarga.DataPropertyName = "Harga";
            dgMenu.Grid.Columns.Add(colHarga);

            // Kolom Stok
            var colStok = new DataGridViewTextBoxColumn();
            colStok.Name = "Stok";
            colStok.HeaderText = "Stok";
            colStok.DataPropertyName = "Stok";
            dgMenu.Grid.Columns.Add(colStok);

            // Kolom Tombol Edit
            var btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            dgMenu.Grid.Columns.Add(btnEdit);

            // Kolom Tombol Hapus
            var btnHapus = new DataGridViewButtonColumn();
            btnHapus.Name = "btnHapus";
            btnHapus.HeaderText = "";
            btnHapus.Text = "Hapus";
            btnHapus.UseColumnTextForButtonValue = true;
            dgMenu.Grid.Columns.Add(btnHapus);

            dgMenu.Grid.CellContentClick += dgMenu_CellContentClick;

            LoadMenu();
        }

        private void LoadMenu()
        {
            try
            {
                List<MenuModel> list = MenuController.GetAllMenu();
                dgMenu.Grid.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data menu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgMenu.Grid.Rows.Count)
                return;

            int id = Convert.ToInt32(dgMenu.Grid.Rows[e.RowIndex].Cells["IdMenu"].Value);
            var menu = MenuController.GetMenuById(id);
            if (menu == null) return;

            if (dgMenu.Grid.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                using (var editForm = new MenuEdit(menu))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadMenu();
                    }
                }
            }
            else if (dgMenu.Grid.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                if (MessageBox.Show($"Yakin ingin hapus menu '{menu.Nama}'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (MenuController.DeleteMenu(id))
                        LoadMenu();
                    else
                        MessageBox.Show("Gagal menghapus menu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (var createForm = new MenuCreate())
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMenu();
                }
            }
        }
    }
}
