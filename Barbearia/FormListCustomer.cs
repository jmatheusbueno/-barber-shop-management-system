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
    public partial class FormListCustomer : Form
    {
        public FormListCustomer()
        {
            InitializeComponent();
            AddColumns();
        }

        #region Events
        private void btnNew_Click(object sender, EventArgs e)
        {
            FormCustomerData frm = new FormCustomerData();
            frm.Show();
        }

        private void FormListCustomer_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.brutusDataSet.customer);
        }
        #endregion

        #region Methods
        private void AddColumns()
        {
            dataGridView1.Columns[0].HeaderText = "Cliente";
            dataGridView1.Columns[1].HeaderText = "CPF";
            dataGridView1.Columns[2].HeaderText = "Telefone";
            dataGridView1.Columns[3].HeaderText = "Endereço";
            dataGridView1.Columns[4].HeaderText = "Observações";
        }
        #endregion
    }
}
