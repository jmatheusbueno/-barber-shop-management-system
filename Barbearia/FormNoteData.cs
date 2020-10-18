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
    public partial class FormNoteData : Form
    {
        public bool Edit { get; set; }
        public FormNoteData()
        {
            InitializeComponent();
        }

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            var n = Fill();
            Save(n as Note);
        }

        private void FormNoteData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brutusDataSet2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.brutusDataSet2.customer);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Methods
        private object Fill()
        {
            Note n = new Note();
            var dataRowView = this.cboCustomer.SelectedItem as DataRowView;
            n.CustomerName = dataRowView.Row.ItemArray[0].ToString();
            n.Date = Convert.ToDateTime(txtDate.Text);
            n.StartSchedule = txtStartSchedule.Text;
            n.FinalSchedule = txtFinalSchedule.Text;
            
            return n;
        }

        public void FillForm(string customer, DateTime date, string startschedule, string finalschedule)
        {
            cboCustomer.Enabled = false;
            lblCustomerName.Visible = true;
            lblCustomerName.Text = customer;
            txtDate.Text = date.ToString();
            txtStartSchedule.Text = startschedule;
            txtFinalSchedule.Text = finalschedule;
            if (!Edit)
            {
                txtDate.ReadOnly = true;
                txtStartSchedule.ReadOnly = true;
                txtFinalSchedule.ReadOnly = true;

                btnSave.Enabled = false;
                btnCancel.Text = "Fechar";
                return;
            }
            btnSave.Text = "Editar";
        }

        private void Save(Note obj)
        {
            Db db = new Db();
            SqlCommand insertCommand = new SqlCommand("insert Note(Name, Date, StartSchedule, FinalSchedule) values(@Name, @Date, @StartSchedule, @FinalSchedule)");
            insertCommand.Parameters.AddWithValue("@Name", obj.CustomerName);
            insertCommand.Parameters.AddWithValue("@Date", obj.Date);
            insertCommand.Parameters.AddWithValue("@StartSchedule", obj.StartSchedule);
            insertCommand.Parameters.AddWithValue("@FinalSchedule", obj.FinalSchedule);

            int row = db.executeQuery(insertCommand);
            if (row == 1)
                MessageBox.Show("Horário cadastrado com sucesso", "Cadastro concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Falha no cadastro, tente novamente", "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
        }
        #endregion
    }
}
