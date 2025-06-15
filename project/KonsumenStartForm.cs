
using System;
using System.Windows.Forms;

namespace ADP_Bakery
{
    public partial class KonsumenStartForm : Form
    {
        public KonsumenStartForm()
        {
            InitializeComponent();
        }

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            RegistrasiKonsumenForm form = new RegistrasiKonsumenForm();
            form.Show();
            this.Hide();
        }

        private void btnLoginMember_Click(object sender, EventArgs e)
        {
            LoginMemberForm form = new LoginMemberForm();
            form.Show();
            this.Hide();
        }

        private void btnBuatMember_Click(object sender, EventArgs e)
        {
            BuatMemberForm form = new BuatMemberForm();
            form.Show();
            this.Hide();
        }
    }
}
