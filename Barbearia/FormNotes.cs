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
            AddColumns();
        }

        #region Events
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
        #endregion

        #region Methods
        private void AddColumns()
        {
            dataGridView1.Columns[0].HeaderText = "Cliente";
            dataGridView1.Columns[1].HeaderText = "Data";
            dataGridView1.Columns[2].HeaderText = "Horário de início";
            dataGridView1.Columns[3].HeaderText = "Horário de término";
        }
        #endregion
    }
}
