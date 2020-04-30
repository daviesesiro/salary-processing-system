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
    public partial class processSalary : Form
    {
        public employee emp;
        List<modelPayslip> payslip_model = new List<modelPayslip>();
        float total;
        public processSalary()
        {
            InitializeComponent();
        }

        private void fixedprocessSalary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'levelds.level' table. You can move, or remove it, as needed.
            this.levelTableAdapter.Fill(this.levelds.level);
            // TODO: This line of code loads data into the 'rankds.ranks' table. You can move, or remove it, as needed.
            this.ranksTableAdapter.Fill(this.rankds.ranks);
            // TODO: This line of code loads data into the 'stepList.step' table. You can move, or remove it, as needed.
            this.stepTableAdapter.Fill(this.stepList.step);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
               

        employee enable_disabler()
        {
            employee em;
            int employeeID = 0;
            try{ employeeID = Int32.Parse(empIDtxt.Text.Trim()); } catch (Exception err) { }
            
            using (EUIm db = new EUIm())
            {
                em = db.employees.Where(x => x.id == employeeID).FirstOrDefault();
                
                if (em == null)
                {
                    hoursWorkedtxt.Enabled = false;
                    levelcb.Enabled = false;
                    rankcb.Enabled = false;
                    stepcb.Enabled = false;
                    proSalarybtn.Enabled = false;
                    genPaySlipbtn.Enabled = false;
                    cbPosition.Enabled = false;
                    cbworkingHours.Enabled = false;
                }
                else
                {
                    proSalarybtn.Enabled = true;
                    //genPaySlipbtn.Enabled = true;
                    if (em.category == "Academic" || em.category == "Non-academic")
                    {
                        levelcb.Enabled = true;
                        rankcb.Enabled = true;
                        stepcb.Enabled = true;
                        if(em.category == "Academic")
                        {
                            cbPosition.Enabled = true;
                            cbworkingHours.Enabled = false;
                        }else
                        {
                            cbPosition.Enabled = false;
                            cbworkingHours.Enabled = true;
                        }

                        var con = db.Contractors.Where(x => x.employeeID == em.id).FirstOrDefault();
                        if(con != null)
                        {
                            hoursWorkedtxt.Enabled = true;
                            levelcb.Enabled = false;
                            rankcb.Enabled = false;
                            stepcb.Enabled = false;
                        }
                    }
                    
                }
            }
            return em;
        }

        private void empIDtxt_Up(object sender, KeyEventArgs e)
        {
            emp = enable_disabler();
        }

        private void proSalarybtn_Click(object sender, EventArgs e)
        {
            //setting important variables
            var level = Int32.Parse(levelcb.Text.Trim());
            var rank = rankcb.Text;
            var step = Int32.Parse(stepcb.Text);
            

            if(emp != null && emp.status=="Hired")
            {
                using (EUIm db = new EUIm())
                {
                    // setting employeeId to 0
                    int employeeID = 0; 
                    if (empIDtxt.Text.Trim() != "") { employeeID = Int32.Parse(empIDtxt.Text.Trim()); } 
                    //creating an employee model from the employeeID
                    var em = db.employees.Where(x => x.id == employeeID).FirstOrDefault();
                    //creating a contractor model from the employeeID
                    var contractorM = db.Contractors.Where(x => x.employeeID == em.id).FirstOrDefault();
                    
                    // checking if employee is an Academic or a non-academic Staff
                    if(em.category == "Academic")
                    {
                        var con = db.nCONUASSes.Where(x => x.level == level && x.step == step).FirstOrDefault();                        
                        var model = new emConuass();
                        model.employeeID = em.id;
                        model.conuassID = con.id;
                        db.emConuasses.Add(model); // adding employee to CONUASS
                        insertRSL(em, rank, level, step); // inserting data into emRank, emLevel and emLevel
                        db.SaveChanges();
                        //Insert into salary table
                        var salary = new Salary();
                        float RA;
                        salary.employeeid = em.id;
                        salary.EWA = (float)con.EWA;
                        if(cbPosition.Text != "None")
                        {
                            salary.RA =(float) con.responsibilityAllowance;
                            RA = (float)con.responsibilityAllowance;
                        }
                        else
                        {
                            salary.RA = 0;
                            RA = 0;
                        }
                        salary.HA =(float) con.hazard;
                        salary.OA = 0;
                        salary.salary1 =(float) con.basicSalary;
                        total = RA + (float)(con.hazard + con.EWA + con.basicSalary);
                        salary.total =  RA + (float)(con.hazard + con.EWA  + con.basicSalary);

                        db.Salaries.Add(salary);
                        db.SaveChanges();

                        //**************Insert into payslip table**************//
                        //Array of different earnings
                        string[] Earnings = {"Basic Salary", "Enhanced work allowance","Overtime allowance",
                                            "Hazard allowance","Responsibility allowance" };
                        float[] Amount = { (float)con.basicSalary, (float)con.EWA, 0, (float)con.hazard, RA };
                        var payslip = new payslip();
                        payslip.employeeID = em.id;
                        payslip.salaryid = salary.id;
                        db.payslips.Add(payslip);
                        db.SaveChanges();
                        var mP = new modelPayslip();
                        for (int i = 0; i < Earnings.Length; i++)
                        {
                            mP = new modelPayslip();
                            mP.Earnings = Earnings[i];
                            mP.Amount = Amount[i];
                            mP.employeeID = em.id;
                            mP.id = i + 1;
                            payslip_model.Add(mP);
                        }
                        MessageBox.Show("Salary successfully processed academic employee salary.\nPlease proceed to Generate a payslip");
                    }
                    else if(contractorM != null)                        
                    {
                        //setting important variables for the contractor model
                        int hoursWorked = Int32.Parse(hoursWorkedtxt.Text.Trim()); float bonus = 0f;
                        float hourly = (float)contractorM.hourly; //retriving hourly data from the contractor model
                        total = hoursWorked * hourly;
                        // give contractor bonus of 10% normal payment if he/she works more than 150 hours
                        if (hoursWorked >= 150)
                        {
                            bonus = (hoursWorked * hourly) * 0.1f;
                            total = bonus + (hoursWorked * hourly);
                        }
                        //creating a salaryContractor model and inserting into database
                        var salary = new Salary();
                        salary.bonus = bonus;
                        salary.total = total;
                        salary.salary1 = (hoursWorked * hourly);
                        salary.employeeid = em.id;
                        db.Salaries.Add(salary);
                        
                        db.SaveChanges();


                        //**************Insert into payslip table**************//
                        
                        var payslip = new payslip();
                        payslip.employeeID = em.id;
                        payslip.salaryid = salary.id;
                        db.payslips.Add(payslip);
                        db.SaveChanges();
                        var mP = new modelPayslip();
                        //Array of different earnings
                        string[] Earnings = {"Basic Salary", "Bonus"};
                        float[] Amount = {(hoursWorked * hourly), bonus};
                        for (int i = 0; i < Earnings.Length; i++)
                        {
                            mP = new modelPayslip();
                            mP.Earnings = Earnings[i];
                            mP.Amount = Amount[i];
                            mP.employeeID = em.id;
                            mP.id = i + 1;
                            payslip_model.Add(mP);
                        }
                        MessageBox.Show("Successfully Processed Contractor's salary.\nPlease proceed to generate payslip");

                    }
                    else if(em.category == "Non-academic")
                    {
                        //retriving a contiss model from the data with the same level and step
                        var cont = db.nCONTISSes.Where(x => x.level == level && x.step == step).FirstOrDefault();
                        //creating an emContiss object and adding it to the database
                        var model = new emContiss();
                        model.employeeID = em.id;
                        model.contissID = cont.id;
                        db.emContisses.Add(model); // adding employee to CONTISS
                        insertRSL(em, rank, level, step); // inserting data into emRank, emLevel and emLevel
                        db.SaveChanges();
                        //insert into salary table
                        var salary = new Salary();
                        salary.salary1 =(float) cont.basicSalary;                       
                        salary.employeeid = em.id;
                        salary.EWA = 0;
                        float OA = (float)cont.OA;
                        if (cbworkingHours.Text == "Overtime")
                        {
                            salary.OA = (float)cont.OA;
                        }
                        else
                        {
                            salary.OA = 0;
                            OA = 0;
                        }
                        salary.RA = 0;
                        salary.HA = (float)cont.hazard;
                        salary.salary1 = (float)cont.basicSalary;
                        total = OA + (float)(cont.hazard + cont.basicSalary);
                        salary.total = OA + (float) (cont.hazard + cont.basicSalary);

                        db.Salaries.Add(salary);
                        db.SaveChanges();

                        //**************Insert into payslip table**************//
                        //Array of different earnings
                        string[] Earnings = {"Basic Salary", "Enhanced work allowance","Overtime allowance",
                                            "Hazard allowance","Responsibility allowance" };
                        float[] Amount = { (float)cont.basicSalary, 0, OA, (float)cont.hazard, 0 };
                        var payslip = new payslip();
                        payslip.employeeID = em.id;
                        payslip.salaryid = salary.id;
                        db.payslips.Add(payslip);
                        db.SaveChanges();
                        var mP = new modelPayslip();
                        for (int i = 0; i < Earnings.Length; i++)
                        {
                            mP = new modelPayslip();
                            mP.Earnings = Earnings[i];
                            mP.Amount = Amount[i];
                            mP.employeeID = em.id;  
                            mP.id = i + 1;
                            payslip_model.Add(mP);
                        }
                        MessageBox.Show("Salary successfully processed non-Academic employee salary.\nProceed to Generate a payslip");
                    }                                   
                }
            }else
            {
                MessageBox.Show("No longer an employee");
            }
            genPaySlipbtn.Enabled = true;  
          }

        void insertRSL(employee em, string rank, int level, int step)
        {
            using (EUIm db = new EUIm())
            {
                // Insert data into emRank Table
                emrank nRank = new emrank();
                var rankID = db.ranks.Where(x => x.rankName == rank).FirstOrDefault();

                nRank.rankid = rankID.id;
                nRank.employeeid = em.id;                
                db.emranks.Add(nRank);
                db.SaveChanges();
                
                // Insert data into level Table
                emlevel emlevel = new emlevel();
                var levelModel = db.levels.Where(x => x.levelname == level).FirstOrDefault();
                emlevel.levelid = levelModel.id;
                emlevel.employeeid = em.id;
                //emlevel.id = 1;
                db.emlevels.Add(emlevel);
                
                db.SaveChanges();

                // Insert data into step Table
                emStep nStep = new emStep();
                var StepID = db.steps.Where(x => x.stepname == step).FirstOrDefault();
                nStep.stepid = StepID.id;
                nStep.employeeID = em.id;
                db.emSteps.Add(nStep);
                db.SaveChanges();
            }
            genPaySlipbtn.Enabled = true;
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginpage = new login();
            loginpage.ShowDialog();
            this.Close();
        }

        private void fixedSalaryStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewEmployee vEmpPage = new viewEmployee();
            vEmpPage.ShowDialog();
            this.Close();
        }
        

        private void genPaySlipbtn_Click(object sender, EventArgs e)
        {
            
            var Name = emp.firstname+" "+emp.lastname;
            using (var form = new frmPayslip(payslip_model, emp.id.ToString(), Name, string.Format("{0}$", total.ToString()), DateTime.Now.ToString()))
            {
                form.ShowDialog();
            }

        }
    }
}
