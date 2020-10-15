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
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormNoteData frm = new FormNoteData();
            frm.Show();
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brutusDataSet3.note' table. You can move, or remove it, as needed.
            this.noteTableAdapter1.Fill(this.brutusDataSet3.note);
        }
    }
}
