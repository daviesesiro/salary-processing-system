namespace AutomatedSalaryProcessingSystem
{
    partial class frmPayslip
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.modelPayslipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.modelPayslipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // modelPayslipBindingSource
            // 
            this.modelPayslipBindingSource.DataSource = typeof(AutomatedSalaryProcessingSystem.modelPayslip);
            // 
            // report
            // 
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "mP";
            reportDataSource1.Value = this.modelPayslipBindingSource;
            this.report.LocalReport.DataSources.Add(reportDataSource1);
            this.report.LocalReport.ReportEmbeddedResource = "AutomatedSalaryProcessingSystem.payslip.rdlc";
            this.report.Location = new System.Drawing.Point(0, 0);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(583, 261);
            this.report.TabIndex = 0;
            // 
            // frmPayslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 261);
            this.Controls.Add(this.report);
            this.Name = "frmPayslip";
            this.ShowIcon = false;
            this.Text = "Payslip";
            this.Load += new System.EventHandler(this.frmPayslip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelPayslipBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report;
        private System.Windows.Forms.BindingSource modelPayslipBindingSource;
    }
}