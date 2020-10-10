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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.lblStartSchedule = new System.Windows.Forms.Label();
            this.lblFinalSchedule = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStartSchedule = new System.Windows.Forms.TextBox();
            this.txtFinalSchedule = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
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
            // cbbCustomer
            // 
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(71, 19);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(478, 21);
            this.cbbCustomer.TabIndex = 3;
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
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(393, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtStartSchedule
            // 
            this.txtStartSchedule.Location = new System.Drawing.Point(278, 50);
            this.txtStartSchedule.Name = "txtStartSchedule";
            this.txtStartSchedule.Size = new System.Drawing.Size(62, 20);
            this.txtStartSchedule.TabIndex = 16;
            // 
            // txtFinalSchedule
            // 
            this.txtFinalSchedule.Location = new System.Drawing.Point(486, 50);
            this.txtFinalSchedule.Name = "txtFinalSchedule";
            this.txtFinalSchedule.Size = new System.Drawing.Size(63, 20);
            this.txtFinalSchedule.TabIndex = 17;
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
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(71, 50);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(84, 20);
            this.txtData.TabIndex = 19;
            // 
            // FormNoteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 117);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtFinalSchedule);
            this.Controls.Add(this.txtStartSchedule);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFinalSchedule);
            this.Controls.Add(this.lblStartSchedule);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Name = "FormNoteData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Horário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.Label lblStartSchedule;
        private System.Windows.Forms.Label lblFinalSchedule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStartSchedule;
        private System.Windows.Forms.TextBox txtFinalSchedule;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
    }
}