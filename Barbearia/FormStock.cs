using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbearia
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
            AddColumns();
        }

        #region Events
        private void btnNew_Click(object sender, EventArgs e)
        {
            FormProductData frm = new FormProductData();
            frm.Show();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brutusDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.brutusDataSet1.product);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                this.productTableAdapter.Fill(this.brutusDataSet1.product);
        }
        #endregion

        #region Methods
        private void AddColumns()
        {
            dataGridView1.Columns[0].HeaderText = "Produto";
            dataGridView1.Columns[1].HeaderText = "Quantidade";
            dataGridView1.Columns[2].HeaderText = "Preço";
        }
        #endregion
    }
}
