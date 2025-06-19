
namespace ADP_Bakery
{
    partial class StartupForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnAdmin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnCustomer = new Button();
            btnAdmin = new Button();
            label1 = new Label();
            label2 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(100, 175);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(300, 50);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Login sebagai Konsumen";
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(100, 325);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(300, 50);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Login sebagai Admin";
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 50);
            label1.Name = "label1";
            label1.Size = new Size(272, 46);
            label1.TabIndex = 2;
            label1.Text = "Selamat Datang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 96);
            label2.Name = "label2";
            label2.Size = new Size(167, 38);
            label2.TabIndex = 3;
            label2.Text = "ADP Bakery";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(100, 231);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 50);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // StartupForm
            // 
            ClientSize = new Size(482, 453);
            Controls.Add(btnRegister);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCustomer);
            Controls.Add(btnAdmin);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "StartupForm";
            Text = "Selamat Datang di ADP Bakery";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private Button btnRegister;
    }
}
