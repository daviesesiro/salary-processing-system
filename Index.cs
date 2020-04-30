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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            Setup();
        }

        private void Index_Paint(object sender, PaintEventArgs e)
        {
            //Graphics graphics = e.Graphics;
            //Rectangle gradient_rectangle = new Rectangle(0, 0, this.Width, this.Height);
            //Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 255), Color.FromArgb(0, 255, 0), 65f);
            //graphics.FillRectangle(b, gradient_rectangle);
        }

        public void Setup()
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginpage = new login();
            loginpage.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select the category of staff you want to capture\nFixed-salary staff uses CONUASS or CONTISS\nContractor will depend on the contract");
            
        }

        private void Help_MouseHover(object sender, EventArgs e)
        {
            Help.ForeColor = Color.Black;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Help.ForeColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Fixed_salaryForm fixed_salary_page = new Fixed_salaryForm();
            fixed_salary_page.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ContractorForm contractorpage = new ContractorForm();
            contractorpage.Show();
            //this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fixedSalaryStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            viewEmployee vEmpPage = new viewEmployee();
            vEmpPage.Show();
            //this.Close();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            processSalary FsalaryProcessPage = new processSalary();
            FsalaryProcessPage.Show();
            //this.Close();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
