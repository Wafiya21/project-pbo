namespace project.ViewCustomer
{
    partial class MenuCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowMenuPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowMenuPanel
            // 
            flowMenuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowMenuPanel.AutoSize = true;
            flowMenuPanel.Location = new Point(0, 100);
            flowMenuPanel.Margin = new Padding(4);
            flowMenuPanel.Name = "flowMenuPanel";
            flowMenuPanel.Size = new Size(750, 400);
            flowMenuPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(750, 75);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 51);
            label1.TabIndex = 2;
            label1.Text = "MENU KAMI";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MenuCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(flowMenuPanel);
            Margin = new Padding(4);
            MinimumSize = new Size(750, 500);
            Name = "MenuCustomer";
            Size = new Size(750, 500);
            Load += MenuCustomer_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowMenuPanel;
        private Panel panel1;
        private Label label1;
    }
}
