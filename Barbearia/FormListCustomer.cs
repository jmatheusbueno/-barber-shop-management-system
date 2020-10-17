using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            // TODO: This line of code loads data into the 'brutusDataSet8.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.brutusDataSet8.customer);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                this.customerTableAdapter1.Fill(this.brutusDataSet8.customer);
        }
        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
                Fill();
        }
        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
                Remove();
        }
        #endregion

        #region Methods
        private void AddColumns()
        {
            dataGridView1.Columns[1].HeaderText = "Cliente";
            dataGridView1.Columns[2].HeaderText = "CPF";
            dataGridView1.Columns[3].HeaderText = "Telefone";
            dataGridView1.Columns[4].HeaderText = "Endereço";
            dataGridView1.Columns[5].HeaderText = "Número";
            dataGridView1.Columns[6].HeaderText = "Observações";
        }

        private void Fill()
        {
            Customer customer = new Customer();
            customer.Name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            customer.CPF = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            customer.Cell_Phone = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            customer.Address = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            customer.Address_Number = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            customer.Observation = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            FormCustomerData frm = new FormCustomerData();
            frm.FillForm(customer.Name, customer.CPF, customer.Cell_Phone, customer.Address, customer.Address_Number, customer.Observation);
            frm.Show();

        }

        private void Remove()
        {
            var id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Db db = new Db();
            SqlCommand deleteCommand = new SqlCommand("delete from customer where id = @id");
            deleteCommand.Parameters.AddWithValue("@id", id);

            db.executeQuery(deleteCommand);
            MessageBox.Show("Cliente removido com sucesso", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion


    }
}
