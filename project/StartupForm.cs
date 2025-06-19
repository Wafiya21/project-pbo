
using project;
using project.ViewAdmin;
using System;
using System.Windows.Forms;

namespace ADP_Bakery
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin admin= new LoginAdmin();
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            LoginCustomer customer = new LoginCustomer();
            this.Hide();
            customer.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }
    }
}
