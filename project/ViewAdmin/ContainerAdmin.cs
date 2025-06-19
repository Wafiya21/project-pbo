using ADP_Bakery;
using project.Helpers;
using project.ViewAdmin.AkunAdmin;
using project.ViewAdmin.AkunCustomer;
using project.ViewAdmin.Menu;
using project.ViewAdmin.Transaksi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.ViewAdmin
{
    public partial class ContainerAdmin : Form
    {
        public ContainerAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAkunAdmin_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            AkunAdminIndex akunAdminIndex = new AkunAdminIndex();
            akunAdminIndex.Dock = DockStyle.Fill;
            panelContent.Controls.Add(akunAdminIndex);
        }

        private void btnAkunCustomer_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            AkunCustomerIndex akunCustomerIndex = new AkunCustomerIndex();
            akunCustomerIndex.Dock = DockStyle.Fill;
            panelContent.Controls.Add(akunCustomerIndex);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            MenuIndex menuIndex = new MenuIndex();
            menuIndex.Dock = DockStyle.Fill;
            panelContent.Controls.Add(menuIndex);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            TransaksiIndex transaksiIndex = new TransaksiIndex();
            transaksiIndex.Dock = DockStyle.Fill;
            panelContent.Controls.Add(transaksiIndex);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                AdminSession.Logout();
                this.Hide();
                StartupForm startupForm = new StartupForm();
                startupForm.ShowDialog();
                this.Close();
            }
        }
    }
}
