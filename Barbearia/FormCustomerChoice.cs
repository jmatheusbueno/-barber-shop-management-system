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
    public partial class FormCustomerChoice : Form
    {
        public FormCustomerChoice()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormCustomerData frm = new FormCustomerData();
            frm.Show();
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FormListCustomer frm = new FormListCustomer();
            frm.Show();
            this.Close();
        }
    }
}
