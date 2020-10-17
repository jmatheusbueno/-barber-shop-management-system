using Barbearia.object_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbearia
{
    public partial class FormProductData : Form
    {
        public FormProductData()
        {
            InitializeComponent();
        }

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var p = Fill();
            Save(p as Product);
        }
        #endregion

        #region Methods
        private object Fill()
        {
            Product p = new Product();
            p.Name = txtName.Text;
            p.Price = float.Parse(txtPrice.Text, CultureInfo.InvariantCulture.NumberFormat);
            p.Quantity = Convert.ToInt32(txtQuantity.Text);
            return p;
        }

        public void FillForm(string name, float price, int quantity)
        {
            txtName.Text = name;
            txtPrice.Text = price.ToString();
            txtQuantity.Text = quantity.ToString();

            txtName.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtQuantity.ReadOnly = true;

            btnSave.Enabled = false;
            btnCancel.Text = "Fechar";
        }

        private void Save(Product obj)
        {
            Db db = new Db();
            SqlCommand insertCommand = new SqlCommand("insert Product(Name,Quantity,Price) values(@Name,@Quantity,@Price)");
            insertCommand.Parameters.AddWithValue("@Name", obj.Name);
            insertCommand.Parameters.AddWithValue("@Quantity", obj.Quantity);
            insertCommand.Parameters.AddWithValue("@Price", obj.Price);

            int row = db.executeQuery(insertCommand);
            if (row == 1)
                MessageBox.Show("Produto cadastrado com sucesso", "Cadastro concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Falha no cadastro, tente novamente", "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
        }
        #endregion
    }
}
