using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.Model;

namespace project.ViewCustomer
{
    public partial class TransaksiDetail : Form
    {
        private int _idTransaksi;
        public TransaksiDetail(int idTransaksi)
        {
            InitializeComponent();
            _idTransaksi = idTransaksi;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void TransaksiDetailCustomer_Load(object sender, EventArgs e)
        {
            var details = DetailTransaksiModel.GetByIdTransaksi(_idTransaksi);
            dgDetailTransaksi.Grid.Columns.Clear();
            dgDetailTransaksi.Grid.AutoGenerateColumns = false;
            dgDetailTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Menu", DataPropertyName = "NamaMenu" });
            dgDetailTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Qty", DataPropertyName = "Qty" });
            dgDetailTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Harga Satuan", DataPropertyName = "HargaSatuan" });
            dgDetailTransaksi.Grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Subtotal", DataPropertyName = "SubTotal" });
            dgDetailTransaksi.Grid.DataSource = details;
        }
    }
}
