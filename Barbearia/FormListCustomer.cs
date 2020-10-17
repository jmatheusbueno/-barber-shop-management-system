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
            // TODO: This line of code loads data into the 'brutusDataSet5.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.brutusDataSet.customer);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                this.customerTableAdapter.Fill(this.brutusDataSet.customer);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
                Fill();
        }
        #endregion

        #region Methods
        private void AddColumns()
        {
            dataGridView1.Columns[0].HeaderText = "Cliente";
            dataGridView1.Columns[1].HeaderText = "CPF";
            dataGridView1.Columns[2].HeaderText = "Telefone";
            dataGridView1.Columns[3].HeaderText = "Endereço";
            dataGridView1.Columns[4].HeaderText = "Número";
            dataGridView1.Columns[5].HeaderText = "Observações";
        }

        private void Fill()
        {
            Customer customer = new Customer();
            customer.Name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            customer.CPF = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            customer.Cell_Phone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            customer.Address = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            customer.Address_Number = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            customer.Observation = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            FormCustomerData frm = new FormCustomerData();
            frm.FillForm(customer.Name, customer.CPF, customer.Cell_Phone, customer.Address, customer.Address_Number, customer.Observation);
            frm.Show();
        }
        #endregion
    }
}
