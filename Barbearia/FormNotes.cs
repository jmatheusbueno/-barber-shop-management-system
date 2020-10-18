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
            // TODO: This line of code loads data into the 'brutusDataSet7.note' table. You can move, or remove it, as needed.
            this.noteTableAdapter.Fill(this.brutusDataSet7.note);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                this.noteTableAdapter.Fill(this.brutusDataSet7.note);
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
            this.noteTableAdapter.Fill(this.brutusDataSet7.note);
        }
        #endregion

        #region Methods
        private void AddColumns()
        {
            dataGridView1.Columns[1].HeaderText = "Cliente";
            dataGridView1.Columns[2].HeaderText = "Data";
            dataGridView1.Columns[3].HeaderText = "Horário de início";
            dataGridView1.Columns[4].HeaderText = "Horário de término";
        }

        private void Fill()
        {
            Note note = new Note();
            note.CustomerName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            var date = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            note.Date = Convert.ToDateTime(date);
            note.StartSchedule = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            note.FinalSchedule = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            FormNoteData frm = new FormNoteData();
            frm.FillForm(note.CustomerName, note.Date, note.StartSchedule, note.FinalSchedule);
            frm.Show();
        }

        private void Remove()
        {
            var id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Db db = new Db();
            SqlCommand deleteCommand = new SqlCommand("delete from note where id = @id");
            deleteCommand.Parameters.AddWithValue("@id", id);

            db.executeQuery(deleteCommand);
            MessageBox.Show("Horário removido com sucesso", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Edit()
        {
            Note note = new Note();
            note.CustomerName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            var date = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            note.Date = Convert.ToDateTime(date);
            note.StartSchedule = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            note.FinalSchedule = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            FormNoteData frm = new FormNoteData() { Edit = true };
            frm.FillForm(note.CustomerName, note.Date, note.StartSchedule, note.FinalSchedule);
            if (frm.ShowDialog() != DialogResult.None)
            {
                var id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Db db = new Db();
                SqlCommand deleteCommand = new SqlCommand("delete from note where id = @id");
                deleteCommand.Parameters.AddWithValue("@id", id);

                db.executeQuery(deleteCommand);
            }
        }
        #endregion
    }
}
