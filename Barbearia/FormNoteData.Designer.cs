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
            this.cbbCustomer.Size = new System.Drawing.Size(403, 21);
            this.cbbCustomer.TabIndex = 3;
            // 
            // lblStartSchedule
            // 
            this.lblStartSchedule.AutoSize = true;
            this.lblStartSchedule.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStartSchedule.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartSchedule.Location = new System.Drawing.Point(12, 50);
            this.lblStartSchedule.Name = "lblStartSchedule";
            this.lblStartSchedule.Size = new System.Drawing.Size(94, 18);
            this.lblStartSchedule.TabIndex = 4;
            this.lblStartSchedule.Text = "Data de início:";
            // 
            // lblFinalSchedule
            // 
            this.lblFinalSchedule.AutoSize = true;
            this.lblFinalSchedule.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblFinalSchedule.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalSchedule.Location = new System.Drawing.Point(238, 48);
            this.lblFinalSchedule.Name = "lblFinalSchedule";
            this.lblFinalSchedule.Size = new System.Drawing.Size(130, 18);
            this.lblFinalSchedule.TabIndex = 5;
            this.lblFinalSchedule.Text = "Horário de Término:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(399, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(318, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtStartSchedule
            // 
            this.txtStartSchedule.Location = new System.Drawing.Point(113, 47);
            this.txtStartSchedule.Name = "txtStartSchedule";
            this.txtStartSchedule.Size = new System.Drawing.Size(100, 20);
            this.txtStartSchedule.TabIndex = 16;
            // 
            // txtFinalSchedule
            // 
            this.txtFinalSchedule.Location = new System.Drawing.Point(374, 46);
            this.txtFinalSchedule.Name = "txtFinalSchedule";
            this.txtFinalSchedule.Size = new System.Drawing.Size(100, 20);
            this.txtFinalSchedule.TabIndex = 17;
            // 
            // FormNoteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 113);
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
    }
}