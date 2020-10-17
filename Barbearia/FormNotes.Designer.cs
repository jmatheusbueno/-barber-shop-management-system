namespace Barbearia
{
    partial class FormNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTile = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startScheduleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalScheduleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.brutusDataSet7 = new Barbearia.BrutusDataSet7();
            this.noteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.brutusDataSet3 = new Barbearia.BrutusDataSet3();
            this.btnNew = new System.Windows.Forms.Button();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteTableAdapter1 = new Barbearia.BrutusDataSet3TableAdapters.noteTableAdapter();
            this.noteTableAdapter = new Barbearia.BrutusDataSet7TableAdapters.noteTableAdapter();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brutusDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brutusDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTitle.Controls.Add(this.lblTile);
            this.pnlTitle.Location = new System.Drawing.Point(-2, -1);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(802, 72);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.Location = new System.Drawing.Point(14, 28);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(92, 25);
            this.lblTile.TabIndex = 0;
            this.lblTile.Text = "Agenda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1,
            this.startScheduleDataGridViewTextBoxColumn1,
            this.finalScheduleDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.noteBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(17, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 300F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // startScheduleDataGridViewTextBoxColumn1
            // 
            this.startScheduleDataGridViewTextBoxColumn1.DataPropertyName = "StartSchedule";
            this.startScheduleDataGridViewTextBoxColumn1.HeaderText = "StartSchedule";
            this.startScheduleDataGridViewTextBoxColumn1.Name = "startScheduleDataGridViewTextBoxColumn1";
            this.startScheduleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // finalScheduleDataGridViewTextBoxColumn1
            // 
            this.finalScheduleDataGridViewTextBoxColumn1.DataPropertyName = "FinalSchedule";
            this.finalScheduleDataGridViewTextBoxColumn1.HeaderText = "FinalSchedule";
            this.finalScheduleDataGridViewTextBoxColumn1.Name = "finalScheduleDataGridViewTextBoxColumn1";
            this.finalScheduleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // noteBindingSource2
            // 
            this.noteBindingSource2.DataMember = "note";
            this.noteBindingSource2.DataSource = this.brutusDataSet7;
            // 
            // brutusDataSet7
            // 
            this.brutusDataSet7.DataSetName = "BrutusDataSet7";
            this.brutusDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteBindingSource1
            // 
            this.noteBindingSource1.DataMember = "note";
            this.noteBindingSource1.DataSource = this.brutusDataSet3;
            // 
            // brutusDataSet3
            // 
            this.brutusDataSet3.DataSetName = "BrutusDataSet3";
            this.brutusDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(560, 415);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Cadastrar Horário";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataMember = "note";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Name";
            this.Nome.HeaderText = "Name";
            this.Nome.Name = "Nome";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // startScheduleDataGridViewTextBoxColumn
            // 
            this.startScheduleDataGridViewTextBoxColumn.DataPropertyName = "StartSchedule";
            this.startScheduleDataGridViewTextBoxColumn.HeaderText = "StartSchedule";
            this.startScheduleDataGridViewTextBoxColumn.Name = "startScheduleDataGridViewTextBoxColumn";
            // 
            // finalScheduleDataGridViewTextBoxColumn
            // 
            this.finalScheduleDataGridViewTextBoxColumn.DataPropertyName = "FinalSchedule";
            this.finalScheduleDataGridViewTextBoxColumn.HeaderText = "FinalSchedule";
            this.finalScheduleDataGridViewTextBoxColumn.Name = "finalScheduleDataGridViewTextBoxColumn";
            // 
            // noteTableAdapter1
            // 
            this.noteTableAdapter1.ClearBeforeFill = true;
            // 
            // noteTableAdapter
            // 
            this.noteTableAdapter.ClearBeforeFill = true;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerToolStripMenuItem,
            this.visualizarToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(124, 48);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(673, 444);
            this.ContextMenuStrip = this.cmsMenu;
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlTitle);
            this.Name = "FormNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNotes";
            this.Load += new System.EventHandler(this.FormNotes_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brutusDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brutusDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalScheduleDataGridViewTextBoxColumn;
        private BrutusDataSet3 brutusDataSet3;
        private System.Windows.Forms.BindingSource noteBindingSource1;
        private BrutusDataSet3TableAdapters.noteTableAdapter noteTableAdapter1;
        private BrutusDataSet7 brutusDataSet7;
        private System.Windows.Forms.BindingSource noteBindingSource2;
        private BrutusDataSet7TableAdapters.noteTableAdapter noteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startScheduleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalScheduleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
    }
}