
using System;
using System.Windows.Forms;

namespace ADP_Bakery
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void btnKonsumen_Click(object sender, EventArgs e)
        {
            KonsumenStartForm konsumenForm = new KonsumenStartForm();
            konsumenForm.Show();
            this.Hide();
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitur login karyawan belum tersedia.");
        }
    }
}
