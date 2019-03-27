namespace CARGODESK
{
    partial class Invoice
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.repairDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.repairCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorizingOfficerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.receivedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.repairerRemarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairDateDataGridViewTextBoxColumn,
            this.repairCompanyDataGridViewTextBoxColumn,
            this.timeinDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.authorizingOfficerDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.receivedByDataGridViewTextBoxColumn,
            this.iDNumberDataGridViewTextBoxColumn,
            this.repairerRemarksDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.deliveryBindingSource;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.Location = new System.Drawing.Point(12, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView1.Size = new System.Drawing.Size(1011, 397);
			this.dataGridView1.TabIndex = 4;
			// 
			// repairDateDataGridViewTextBoxColumn
			// 
			this.repairDateDataGridViewTextBoxColumn.DataPropertyName = "RepairDate";
			this.repairDateDataGridViewTextBoxColumn.HeaderText = "RepairDate";
			this.repairDateDataGridViewTextBoxColumn.Name = "repairDateDataGridViewTextBoxColumn";
			this.repairDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// repairCompanyDataGridViewTextBoxColumn
			// 
			this.repairCompanyDataGridViewTextBoxColumn.DataPropertyName = "RepairCompany";
			this.repairCompanyDataGridViewTextBoxColumn.HeaderText = "RepairCompany";
			this.repairCompanyDataGridViewTextBoxColumn.Name = "repairCompanyDataGridViewTextBoxColumn";
			this.repairCompanyDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// timeinDataGridViewTextBoxColumn
			// 
			this.timeinDataGridViewTextBoxColumn.DataPropertyName = "Timein";
			this.timeinDataGridViewTextBoxColumn.HeaderText = "Timein";
			this.timeinDataGridViewTextBoxColumn.Name = "timeinDataGridViewTextBoxColumn";
			this.timeinDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// itemDataGridViewTextBoxColumn
			// 
			this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
			this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
			this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
			this.itemDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// modelDataGridViewTextBoxColumn
			// 
			this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
			this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
			this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
			this.modelDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// remarksDataGridViewTextBoxColumn
			// 
			this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
			this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
			this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
			this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// authorizingOfficerDataGridViewTextBoxColumn
			// 
			this.authorizingOfficerDataGridViewTextBoxColumn.DataPropertyName = "AuthorizingOfficer";
			this.authorizingOfficerDataGridViewTextBoxColumn.HeaderText = "AuthorizingOfficer";
			this.authorizingOfficerDataGridViewTextBoxColumn.Name = "authorizingOfficerDataGridViewTextBoxColumn";
			this.authorizingOfficerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// designationDataGridViewTextBoxColumn
			// 
			this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
			this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
			this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
			this.designationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// receivedByDataGridViewTextBoxColumn
			// 
			this.receivedByDataGridViewTextBoxColumn.DataPropertyName = "ReceivedBy";
			this.receivedByDataGridViewTextBoxColumn.HeaderText = "ReceivedBy";
			this.receivedByDataGridViewTextBoxColumn.Name = "receivedByDataGridViewTextBoxColumn";
			this.receivedByDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// iDNumberDataGridViewTextBoxColumn
			// 
			this.iDNumberDataGridViewTextBoxColumn.DataPropertyName = "IDNumber";
			this.iDNumberDataGridViewTextBoxColumn.HeaderText = "IDNumber";
			this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
			this.iDNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// repairerRemarksDataGridViewTextBoxColumn
			// 
			this.repairerRemarksDataGridViewTextBoxColumn.DataPropertyName = "RepairerRemarks";
			this.repairerRemarksDataGridViewTextBoxColumn.HeaderText = "RepairerRemarks";
			this.repairerRemarksDataGridViewTextBoxColumn.Name = "repairerRemarksDataGridViewTextBoxColumn";
			this.repairerRemarksDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// diagnosisDataGridViewTextBoxColumn
			// 
			this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis";
			this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis";
			this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
			this.diagnosisDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// deliveryBindingSource
			// 
			this.deliveryBindingSource.DataSource = typeof(CARGODESK.Delivery);
			// 
			// Invoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1035, 447);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.Name = "Invoice";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delivery Reports";
			this.Load += new System.EventHandler(this.Invoice_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorizingOfficerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairerRemarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
    }
}