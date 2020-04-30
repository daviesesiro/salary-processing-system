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
    public partial class ContractorForm : Form
    {
        public ContractorForm()
        {
            InitializeComponent();
        }
        

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginpage = new login();
            loginpage.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contractor = new Contractor();
            float hourly = float.Parse(hourpaytxt.Text.Trim());
            float empid = Int32.Parse(idtxt.Text.Trim());
            using (EUIm db = new EUIm())
            {
                var emp = db.employees.Where(x => x.id == empid).FirstOrDefault();
                if(emp != null && emp.category == "Non-academic")
                {

                    contractor.employeeID = emp.id;
                    contractor.hourly = hourly;                  
                    
                    db.Contractors.Add(contractor);
                    db.SaveChanges();
                    MessageBox.Show("Successfully Captured");
                    idtxt.Text = "";
                    hourpaytxt.Text = "";
                }else
                {
                    MessageBox.Show("Employee is not a non-academic employee.\nPlease make sure employee is a non-academic employee");
                }
            }
        }

        private void ContractorForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, this.Width, this.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 255), Color.FromArgb(0, 255, 0), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void fixedSalaryStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewEmployee vEmpPage = new viewEmployee();
            vEmpPage.Show();
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
            enabler_disabler();
        }
        void enabler_disabler()
        {
            int emid = 0;
            try { emid = Int32.Parse(idtxt.Text); } catch { }
            using(EUIm db = new EUIm())
            {
                var employee = db.employees.Where(x=>x.id == emid).FirstOrDefault();
                if (employee != null && employee.category == "Non-academic")
                {
                    hourpaytxt.Enabled = true;
                    capturebtn.Enabled = true;
                }else
                {
                    hourpaytxt.Enabled = false;
                    capturebtn.Enabled = false;
                }
            }
        }
    }
}
