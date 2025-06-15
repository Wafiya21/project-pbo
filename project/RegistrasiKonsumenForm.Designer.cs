
namespace ADP_Bakery
{
    partial class RegistrasiKonsumenForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNoTelp;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNama = new Label();
            lblNoTelp = new Label();
            txtNama = new TextBox();
            txtNoTelp = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(30, 30);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(52, 20);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama:";
            // 
            // lblNoTelp
            // 
            lblNoTelp.AutoSize = true;
            lblNoTelp.Location = new Point(30, 70);
            lblNoTelp.Name = "lblNoTelp";
            lblNoTelp.Size = new Size(64, 20);
            lblNoTelp.TabIndex = 1;
            lblNoTelp.Text = "No Telp:";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(120, 27);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(200, 27);
            txtNama.TabIndex = 2;
            // 
            // txtNoTelp
            // 
            txtNoTelp.Location = new Point(120, 67);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(200, 27);
            txtNoTelp.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(120, 110);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // RegistrasiKonsumenForm
            // 
            ClientSize = new Size(356, 173);
            Controls.Add(btnSubmit);
            Controls.Add(txtNoTelp);
            Controls.Add(txtNama);
            Controls.Add(lblNoTelp);
            Controls.Add(lblNama);
            Name = "RegistrasiKonsumenForm";
            Text = "Registrasi Konsumen";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
