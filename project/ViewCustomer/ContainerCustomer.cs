using ADP_Bakery;
using project.Helpers;
using project.ViewAdmin.Menu;
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
    public partial class ContainerCustomer : Form
    {
        public ContainerCustomer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnMenu_Click(this, EventArgs.Empty);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            MenuCustomer menuCust = new MenuCustomer();
            menuCust.Dock = DockStyle.Fill;
            panelContent.Controls.Add(menuCust);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            TransaksiCustomer transaksiCust = new TransaksiCustomer();
            transaksiCust.Dock = DockStyle.Fill;
            panelContent.Controls.Add(transaksiCust);
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Keranjang keranjang = new Keranjang();
            keranjang.Dock = DockStyle.Fill;
            panelContent.Controls.Add(keranjang);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CustomerSession.Logout();
            this.Hide();
            StartupForm startupForm = new StartupForm();
            startupForm.ShowDialog();
            this.Close();
        }
    }
}
