namespace Barbearia
{
    partial class FormCustomerData
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtAdressNumber = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lnlNumber = new System.Windows.Forms.Label();
            this.lblEnder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(67, 47);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(253, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(72, 115);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(248, 20);
            this.txtCellPhone.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(86, 141);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(154, 20);
            this.txtAdress.TabIndex = 4;
            // 
            // txtAdressNumber
            // 
            this.txtAdressNumber.Location = new System.Drawing.Point(279, 143);
            this.txtAdressNumber.Name = "txtAdressNumber";
            this.txtAdressNumber.Size = new System.Drawing.Size(41, 20);
            this.txtAdressNumber.TabIndex = 5;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(13, 49);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(35, 18);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // lnlNumber
            // 
            this.lnlNumber.AutoSize = true;
            this.lnlNumber.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lnlNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlNumber.Location = new System.Drawing.Point(13, 117);
            this.lnlNumber.Name = "lnlNumber";
            this.lnlNumber.Size = new System.Drawing.Size(53, 18);
            this.lnlNumber.TabIndex = 7;
            this.lnlNumber.Text = "Celular:";
            // 
            // lblEnder
            // 
            this.lblEnder.AutoSize = true;
            this.lblEnder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblEnder.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnder.Location = new System.Drawing.Point(13, 143);
            this.lblEnder.Name = "lblEnder";
            this.lblEnder.Size = new System.Drawing.Size(67, 18);
            this.lblEnder.TabIndex = 8;
            this.lblEnder.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nº:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(13, 188);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(83, 18);
            this.lblObs.TabIndex = 10;
            this.lblObs.Text = "Observação:";
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(12, 223);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(308, 81);
            this.txtObservation.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormCustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 349);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEnder);
            this.Controls.Add(this.lnlNumber);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtAdressNumber);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximumSize = new System.Drawing.Size(352, 388);
            this.MinimumSize = new System.Drawing.Size(352, 388);
            this.Name = "FormCustomerData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtAdressNumber;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lnlNumber;
        private System.Windows.Forms.Label lblEnder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}