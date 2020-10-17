using Barbearia.object_classes;
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

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                this.noteTableAdapter1.Fill(this.brutusDataSet3.note);
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
                Fill();
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

        private void Fill()
        {
            Note note = new Note();
            note.CustomerName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var date = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            note.Date = Convert.ToDateTime(date);
            note.StartSchedule = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            note.FinalSchedule = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            FormNoteData frm = new FormNoteData();
            frm.FillForm(note.CustomerName, note.Date, note.StartSchedule, note.FinalSchedule);
            frm.Show();
        }
        #endregion

    }
}
