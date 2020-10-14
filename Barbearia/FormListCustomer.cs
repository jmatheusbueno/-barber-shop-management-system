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
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormCustomerData frm = new FormCustomerData();
            frm.Show();
        }

        private void FormListCustomer_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.brutusDataSet.customer);
        }
    }
}
