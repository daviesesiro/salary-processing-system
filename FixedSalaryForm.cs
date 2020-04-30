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
    public partial class Fixed_salaryForm : Form
    {
        
        public Fixed_salaryForm()
        {
            InitializeComponent();
                       
        }

        private void Fixed_salaryForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, this.Width, this.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 255), Color.FromArgb(0, 255, 0), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fixed_salaryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentList.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.departmentList.department);

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginpage = new login();
            loginpage.ShowDialog();
            this.Close();
        }

        void clear()
        {
            firstNametxt.Text = "";
            lastNametxt.Text = "";
            otherNametxt.Text = "";
            emailtxt.Text = "";
            teltxt.Text = "";
            addresstxt.Text = "";
            gendercb.Text = "";
            nKinNametxt.Text = "";
            nKinRealtxt.Text = "";
            nKinTeltxt.Text = "";
            catcb.Text = "";
            nKinEmailtxt.Text = "";
            nKinAddresstxt.Text = "";
        }

        private void capture_Click(object sender, EventArgs e)
        {
            employee model = new employee();
            model.firstname = firstNametxt.Text.Trim(); 
            model.lastname = lastNametxt.Text.Trim();   
            model.othername = otherNametxt.Text.Trim(); 
            model.email = emailtxt.Text.Trim();         
            model.tel = teltxt.Text.Trim();             
            model.address = addresstxt.Text.Trim();
            model.gender = gendercb.Text;
            using(EUIm db = new EUIm())
            {
                
                var dep = db.departments.Where(x => x.departmentName == depcb.Text).FirstOrDefault();
                if (depcb.Enabled) { model.departmentID = dep.id; }else { model.departmentID = null;}
                
            }
            model.nKName = nKinNametxt.Text.Trim();
            model.nKRelationship = nKinRealtxt.Text.Trim();
            model.nKTel = nKinTeltxt.Text.Trim();
            model.nKEmail = nKinEmailtxt.Text.Trim();
            model.nKaddress = nKinAddresstxt.Text.Trim();
            model.category = catcb.Text.Trim().Trim();
            model.DOB = dobdt.Value.Date;
            model.status = "Hired";
            
            
            try
            {
                using (EUIm db = new EUIm())
                {
                    var em = db.employees.Where(x => x.email == model.email).FirstOrDefault();
                    if(em == null)
                    {
                        db.employees.Add(model);
                        db.SaveChanges();
                        MessageBox.Show("Successful Captured");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Employee Email already already Exist in database");
                    }

                   
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show("error");
            }          

        }
        

        private void catcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(catcb.Text == "Academic")
            {
                depcb.Enabled = true;
            }else
            {
                depcb.Enabled = false;
            }
        }
        

        private void fixedSalaryStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            viewEmployee vEmpPage = new viewEmployee();
            vEmpPage.Show();
            //this.Close();
        }
    }
}
