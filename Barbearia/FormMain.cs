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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomerChoice frm = new FormCustomerChoice();
            frm.Show();
        }

        private void btnHours_Click(object sender, EventArgs e)
        {
            FormNotes frm = new FormNotes();
            frm.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormStock frm = new FormStock();
            frm.Show();
        }

    }
}
