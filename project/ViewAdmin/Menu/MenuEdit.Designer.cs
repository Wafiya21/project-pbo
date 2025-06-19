namespace project.ViewAdmin.Menu
{
    partial class MenuEdit
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
            tbStok = new TextBox();
            label3 = new Label();
            btnSimpan = new Button();
            tbHarga = new TextBox();
            label2 = new Label();
            tbNama = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbStok
            // 
            tbStok.Location = new Point(12, 164);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(300, 27);
            tbStok.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 23;
            label3.Text = "Stok";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.DodgerBlue;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.Control;
            btnSimpan.Location = new Point(212, 197);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 40);
            btnSimpan.TabIndex = 22;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(12, 104);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(300, 27);
            tbHarga.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 20;
            label2.Text = "Harga";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(12, 43);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(300, 27);
            tbNama.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 18;
            label1.Text = "Nama";
            // 
            // MenuEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 250);
            Controls.Add(tbStok);
            Controls.Add(label3);
            Controls.Add(btnSimpan);
            Controls.Add(tbHarga);
            Controls.Add(label2);
            Controls.Add(tbNama);
            Controls.Add(label1);
            Name = "MenuEdit";
            Text = "MenuEdit";
            Load += MenuEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbStok;
        private Label label3;
        private Button btnSimpan;
        private TextBox tbHarga;
        private Label label2;
        private TextBox tbNama;
        private Label label1;
    }
}