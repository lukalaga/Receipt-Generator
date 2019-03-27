namespace CARGODESK
{
    partial class Dashboard
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnMaintenance = new System.Windows.Forms.Button();
            this.BtnRepairs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnMaintenance
            // 
            this.BtnMaintenance.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaintenance.Location = new System.Drawing.Point(209, 70);
            this.BtnMaintenance.Name = "BtnMaintenance";
            this.BtnMaintenance.Size = new System.Drawing.Size(191, 65);
            this.BtnMaintenance.TabIndex = 1;
            this.BtnMaintenance.Text = "Monthly Maintenance";
            this.BtnMaintenance.UseVisualStyleBackColor = true;
            this.BtnMaintenance.Click += new System.EventHandler(this.BtnMaintenance_Click);
            // 
            // BtnRepairs
            // 
            this.BtnRepairs.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRepairs.Location = new System.Drawing.Point(12, 70);
            this.BtnRepairs.Name = "BtnRepairs";
            this.BtnRepairs.Size = new System.Drawing.Size(191, 65);
            this.BtnRepairs.TabIndex = 0;
            this.BtnRepairs.Text = "Repairs Confirmity";
            this.BtnRepairs.UseVisualStyleBackColor = true;
            this.BtnRepairs.Click += new System.EventHandler(this.BtnRepairs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1074, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.gridsToolStripMenuItem,
            this.securityToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repairReportToolStripMenuItem,
            this.maintenanceReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // repairReportToolStripMenuItem
            // 
            this.repairReportToolStripMenuItem.Name = "repairReportToolStripMenuItem";
            this.repairReportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.repairReportToolStripMenuItem.Text = "Repair Report";
            this.repairReportToolStripMenuItem.Click += new System.EventHandler(this.repairReportToolStripMenuItem_Click);
            // 
            // maintenanceReportToolStripMenuItem
            // 
            this.maintenanceReportToolStripMenuItem.Name = "maintenanceReportToolStripMenuItem";
            this.maintenanceReportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.maintenanceReportToolStripMenuItem.Text = "Maintenance Report";
            // 
            // gridsToolStripMenuItem
            // 
            this.gridsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportGridToolStripMenuItem,
            this.maintenanceGridToolStripMenuItem});
            this.gridsToolStripMenuItem.Name = "gridsToolStripMenuItem";
            this.gridsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.gridsToolStripMenuItem.Text = "Grids";
            // 
            // reportGridToolStripMenuItem
            // 
            this.reportGridToolStripMenuItem.Name = "reportGridToolStripMenuItem";
            this.reportGridToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reportGridToolStripMenuItem.Text = "Report Grid";
            this.reportGridToolStripMenuItem.Click += new System.EventHandler(this.reportGridToolStripMenuItem_Click);
            // 
            // maintenanceGridToolStripMenuItem
            // 
            this.maintenanceGridToolStripMenuItem.Name = "maintenanceGridToolStripMenuItem";
            this.maintenanceGridToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.maintenanceGridToolStripMenuItem.Text = "Maintenance Grid";
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.securityToolStripMenuItem.Text = "Security";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRepairs);
            this.Controls.Add(this.BtnMaintenance);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button BtnMaintenance;
		private System.Windows.Forms.Button BtnRepairs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem repairReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintenanceReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem securityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gridsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportGridToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintenanceGridToolStripMenuItem;
    }
}