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
    public partial class viewEmployee : Form
    {
        public viewEmployee()
        {
            InitializeComponent();
        }
        employee emp = new employee();
        int GemployeeID;
        private void viewEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDS.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDS.employee);

        }



        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(employeeDT.CurrentRow.Index != -1)
            {
                emp.id = Convert.ToInt32(employeeDT.CurrentRow.Cells["id"].Value);
                GemployeeID = emp.id;
                using (EUIm db = new EUIm())
                {
                    var emModel = db.employees.Where(x => x.id == emp.id).FirstOrDefault();
                    firstNametxt.Text = emModel.firstname;
                    lastNametxt.Text = emModel.lastname;
                    otherNametxt.Text = emModel.othername;
                    addresstxt.Text = emModel.address;
                    teltxt.Text = emModel.tel;
                    emailtxt.Text = emModel.email;
                    statuscb.Text = emModel.status;       
                }
                UpdateBtn.Enabled = true;
                cancelbtn.Enabled = true;
            }            
        }
        
        void refreshTable()
        {
            using(EUIm db = new EUIm())
            {
                employeeDT.DataSource = db.employees.ToList<employee>();
            }
            
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            using (EUIm db = new EUIm())
            {
                var emModel = db.employees.Where(x => x.id == GemployeeID).FirstOrDefault();
                   
                MessageBox.Show(emModel.firstname);
                db.employees.Remove(emModel);
                db.SaveChanges();
                refreshTable();
                MessageBox.Show("Delete Successful");             
                    
            }

       
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            firstNametxt.Text = "";
            lastNametxt.Text = "";
            otherNametxt.Text = "";
            addresstxt.Text = "";
            teltxt.Text = "";
            emailtxt.Text = "";
            statuscb.Text = "";
            UpdateBtn.Enabled = false;
            cancelbtn.Enabled = false;
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            using(EUIm db = new EUIm())
            {
                var emModel = db.employees.Where(x => x.id == GemployeeID).FirstOrDefault();
                emModel.firstname = firstNametxt.Text;
                emModel.lastname = lastNametxt.Text;
                emModel.othername = otherNametxt.Text;
                emModel.address = addresstxt.Text;
                emModel.tel = teltxt.Text;
                emModel.email = emailtxt.Text;
                emModel.status = statuscb.Text;
                db.SaveChanges();
                MessageBox.Show("Updated");
            }
            UpdateBtn.Enabled = false;
            cancelbtn.Enabled = false;
            clear();
            refreshTable();
    }
    }
}
