using Barbearia.object_classes;
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
            // TODO: This line of code loads data into the 'brutusDataSet6.product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.brutusDataSet6.product);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                this.productTableAdapter1.Fill(this.brutusDataSet6.product);
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
                Edit();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.productTableAdapter1.Fill(this.brutusDataSet6.product);
        }
        #endregion

        #region Methods
        private void AddColumns()
        {
            dataGridView1.Columns[1].HeaderText = "Produto";
            dataGridView1.Columns[2].HeaderText = "Quantidade";
            dataGridView1.Columns[3].HeaderText = "Preço";
        }

        private void Fill()
        {
            Product product = new Product();
            product.Name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            product.Quantity = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            product.Price = float.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            FormProductData frm = new FormProductData();
            frm.FillForm(product.Name, product.Price, product.Quantity);
            frm.Show();
        }

        private void Remove()
        {
            var id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Db db = new Db();
            SqlCommand deleteCommand = new SqlCommand("delete from product where id = @id");
            deleteCommand.Parameters.AddWithValue("@id", id);

            db.executeQuery(deleteCommand);
            MessageBox.Show("Produto removido com sucesso", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Edit()
        {
            Product product = new Product();
            product.Name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            product.Quantity = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            product.Price = float.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            FormProductData frm = new FormProductData() { Edit = true };
            frm.FillForm(product.Name, product.Price, product.Quantity);
            if (frm.ShowDialog() != DialogResult.None)
            {
                var id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Db db = new Db();
                SqlCommand deleteCommand = new SqlCommand("delete from product where id = @id");
                deleteCommand.Parameters.AddWithValue("@id", id);

                db.executeQuery(deleteCommand);
            }
        }
        #endregion
    }
}
