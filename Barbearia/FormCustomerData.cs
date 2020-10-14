using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Barbearia
{
    public partial class FormCustomerData : Form
    {
        public FormCustomerChoice FrmCustomerChoice { get; set; }
        public FormCustomerData()
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
            if (IsValid())
            {
                var customer = Fill();
                Save(customer as Customer);
            }
            else            
                MessageBox.Show("Falha no cadastro, tente novamente", "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }
        #endregion

        #region Methods
        private Boolean IsValid()
        {
            bool isValid = true;
            if (txtName.Text.Length > 0 && txtName.Text != "Campo obrigatório")
                isValid = true;
            else
            {
                txtName.Text = "Campo obrigatório";
                txtName.ForeColor = Color.Red;
                lblName.ForeColor = Color.Red;
                isValid = false;
            }
            
            return isValid;
        }

        private object Fill()
        {
            Customer c = new Customer();
            c.Name = txtName.Text;
            c.CPF = txtCPF.Text;
            c.Cell_Phone = txtCellPhone.Text;
            c.Address = txtAdress.Text;
            c.Address_Number = txtAdressNumber.Text;
            c.Observation = txtObservation.Text;

            return c;
        }

        private void Save(Customer obj)
        {
            string name = obj.Name;
            string cpf = obj.CPF;
            string cellphone = obj.Cell_Phone;
            string address = obj.Address;
            string addressnumber = obj.Address_Number;
            string observation = obj.Observation;

            Db db = new Db();
            SqlCommand insertCommand = new SqlCommand("insert Customer(Name,CPF,Cell_Phone,Address,Address_Number,Observation) values(@name,@cpf,@cellphone,@address,@addressnumber,@observation)");
            insertCommand.Parameters.AddWithValue("@name", obj.Name);
            insertCommand.Parameters.AddWithValue("@cpf", obj.CPF);
            insertCommand.Parameters.AddWithValue("@cellphone", obj.Cell_Phone);
            insertCommand.Parameters.AddWithValue("@address", obj.Address);
            insertCommand.Parameters.AddWithValue("@addressnumber", obj.Address_Number);
            insertCommand.Parameters.AddWithValue("@observation", obj.Observation);

            int row = db.executeQuery(insertCommand);
            if (row == 1)
                MessageBox.Show("Cliente cadastrado com sucesso", "Cadastro concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Falha no cadastro, tente novamente", "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
        }
        #endregion
    }
}
