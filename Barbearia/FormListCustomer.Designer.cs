namespace Barbearia
{
    partial class FormListCustomer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brutusDataSet = new Barbearia.BrutusDataSet();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.customerTableAdapter = new Barbearia.BrutusDataSetTableAdapters.customerTableAdapter();
            this.btnView = new System.Windows.Forms.Button();
            this.brutusDataSet5 = new Barbearia.BrutusDataSet5();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brutusDataSet)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brutusDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.cellPhoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.Address_Number,
            this.observationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(875, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFDataGridViewTextBoxColumn.Width = 130;
            // 
            // cellPhoneDataGridViewTextBoxColumn
            // 
            this.cellPhoneDataGridViewTextBoxColumn.DataPropertyName = "Cell_Phone";
            this.cellPhoneDataGridViewTextBoxColumn.HeaderText = "Cell_Phone";
            this.cellPhoneDataGridViewTextBoxColumn.Name = "cellPhoneDataGridViewTextBoxColumn";
            this.cellPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Address_Number
            // 
            this.Address_Number.DataPropertyName = "Address_Number";
            this.Address_Number.HeaderText = "Address_Number";
            this.Address_Number.Name = "Address_Number";
            this.Address_Number.ReadOnly = true;
            // 
            // observationDataGridViewTextBoxColumn
            // 
            this.observationDataGridViewTextBoxColumn.DataPropertyName = "Observation";
            this.observationDataGridViewTextBoxColumn.FillWeight = 200F;
            this.observationDataGridViewTextBoxColumn.HeaderText = "Observation";
            this.observationDataGridViewTextBoxColumn.Name = "observationDataGridViewTextBoxColumn";
            this.observationDataGridViewTextBoxColumn.ReadOnly = true;
            this.observationDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.brutusDataSet;
            // 
            // brutusDataSet
            // 
            this.brutusDataSet.DataSetName = "BrutusDataSet";
            this.brutusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(732, 409);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(3, 10);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(88, 26);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "Clientes";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTitle.Controls.Add(this.lblClientes);
            this.pnlTitle.Location = new System.Drawing.Point(13, 13);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(875, 45);
            this.pnlTitle.TabIndex = 3;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(813, 409);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Visualizar";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // brutusDataSet5
            // 
            this.brutusDataSet5.DataSetName = "BrutusDataSet5";
            this.brutusDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(900, 444);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormListCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Cadastrados";
            this.Load += new System.EventHandler(this.FormListCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brutusDataSet)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brutusDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Panel pnlTitle;
        private BrutusDataSet brutusDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BrutusDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button btnView;
        private BrutusDataSet5 brutusDataSet5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationDataGridViewTextBoxColumn;
    }
}