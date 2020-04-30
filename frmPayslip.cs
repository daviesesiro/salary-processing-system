using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedSalaryProcessingSystem
{
    public partial class frmPayslip : Form
    {
        List<modelPayslip> _list;
        string _total, _date, _EID, _Name;       

        public frmPayslip(List<modelPayslip> dataSource, string EID, string Name, string total, string date)
        {
            InitializeComponent();
            _date = date;
            _total = total;
            _list = dataSource;
            _EID = EID;
            _Name = Name;
        }

        private void frmPayslip_Load(object sender, EventArgs e)
        {
            modelPayslipBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new
                Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal", _total),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("peID", _EID),
                new Microsoft.Reporting.WinForms.ReportParameter("pName", _Name)
            };
            this.report.LocalReport.SetParameters(para);
            this.report.RefreshReport();
        }

    }
}
