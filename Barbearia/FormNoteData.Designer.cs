namespace Barbearia
{
    partial class FormNoteData
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brutusDataSet2 = new Barbearia.BrutusDataSet2();
            this.lblStartSchedule = new System.Windows.Forms.Label();
            this.lblFinalSchedule = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStartSchedule = new System.Windows.Forms.TextBox();
            this.txtFinalSchedule = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new Barbearia.BrutusDataSet2TableAdapters.customerTableAdapter();
            this.lblCustomerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brutusDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(12, 22);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(53, 18);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Cliente:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DataSource = this.customerBindingSource;
            this.cboCustomer.DisplayMember = "Name";
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(71, 19);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(478, 21);
            this.cboCustomer.TabIndex = 0;
            this.cboCustomer.ValueMember = "Name";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.brutusDataSet2;
            // 
            // brutusDataSet2
            // 
            this.brutusDataSet2.DataSetName = "BrutusDataSet2";
            this.brutusDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStartSchedule
            // 
            this.lblStartSchedule.AutoSize = true;
            this.lblStartSchedule.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStartSchedule.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartSchedule.Location = new System.Drawing.Point(161, 52);
            this.lblStartSchedule.Name = "lblStartSchedule";
            this.lblStartSchedule.Size = new System.Drawing.Size(111, 18);
            this.lblStartSchedule.TabIndex = 4;
            this.lblStartSchedule.Text = "Horário de início:";
            // 
            // lblFinalSchedule
            // 
            this.lblFinalSchedule.AutoSize = true;
            this.lblFinalSchedule.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblFinalSchedule.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalSchedule.Location = new System.Drawing.Point(350, 52);
            this.lblFinalSchedule.Name = "lblFinalSchedule";
            this.lblFinalSchedule.Size = new System.Drawing.Size(130, 18);
            this.lblFinalSchedule.TabIndex = 5;
            this.lblFinalSchedule.Text = "Horário de Término:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(474, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(393, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStartSchedule
            // 
            this.txtStartSchedule.Location = new System.Drawing.Point(278, 50);
            this.txtStartSchedule.Name = "txtStartSchedule";
            this.txtStartSchedule.Size = new System.Drawing.Size(62, 20);
            this.txtStartSchedule.TabIndex = 2;
            // 
            // txtFinalSchedule
            // 
            this.txtFinalSchedule.Location = new System.Drawing.Point(486, 50);
            this.txtFinalSchedule.Name = "txtFinalSchedule";
            this.txtFinalSchedule.Size = new System.Drawing.Size(63, 20);
            this.txtFinalSchedule.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblData.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 52);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(40, 18);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "Data:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(71, 50);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(84, 20);
            this.txtDate.TabIndex = 1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Enabled = false;
            this.lblCustomerName.Location = new System.Drawing.Point(73, 23);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 19;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.Visible = false;
            // 
            // FormNoteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 117);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtFinalSchedule);
            this.Controls.Add(this.txtStartSchedule);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFinalSchedule);
            this.Controls.Add(this.lblStartSchedule);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Name = "FormNoteData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Horário";
            this.Load += new System.EventHandler(this.FormNoteData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brutusDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblStartSchedule;
        private System.Windows.Forms.Label lblFinalSchedule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStartSchedule;
        private System.Windows.Forms.TextBox txtFinalSchedule;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtDate;
        private BrutusDataSet2 brutusDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BrutusDataSet2TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label lblCustomerName;
    }
}