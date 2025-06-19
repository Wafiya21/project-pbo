namespace project.ViewAdmin.Menu
{
    partial class MenuCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSimpan = new Button();
            tbHarga = new TextBox();
            label2 = new Label();
            tbNama = new TextBox();
            label1 = new Label();
            tbStok = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.DodgerBlue;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.Control;
            btnSimpan.Location = new Point(212, 194);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 40);
            btnSimpan.TabIndex = 15;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(12, 101);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(300, 27);
            tbHarga.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 13;
            label2.Text = "Harga";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(12, 40);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(300, 27);
            tbNama.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 11;
            label1.Text = "Nama";
            // 
            // tbStok
            // 
            tbStok.Location = new Point(12, 161);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(300, 27);
            tbStok.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 16;
            label3.Text = "Stok";
            // 
            // MenuCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 244);
            Controls.Add(tbStok);
            Controls.Add(label3);
            Controls.Add(btnSimpan);
            Controls.Add(tbHarga);
            Controls.Add(label2);
            Controls.Add(tbNama);
            Controls.Add(label1);
            Name = "MenuCreate";
            Text = "MenuCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private TextBox tbHarga;
        private Label label2;
        private TextBox tbNama;
        private Label label1;
        private TextBox tbStok;
        private Label label3;
    }
}