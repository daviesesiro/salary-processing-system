using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedSalaryProcessingSystem
{
    public class modelPayslip
    {
        public int id { get; set; }
        public int employeeID { get; set; }
        public string Earnings { get; set; }
        public float Amount { get; set; }
    }
}
