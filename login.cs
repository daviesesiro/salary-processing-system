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
    public partial class login : Form    {
        public login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index firstpage = new Index();
            firstpage.ShowDialog();
            this.Close();            
        }

        private void login_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, this.Width, this.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 255), Color.FromArgb(0, 255, 0), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                passwordtxt.UseSystemPasswordChar = false;                
            }else
            {
                passwordtxt.UseSystemPasswordChar = true;
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_click(object sender, EventArgs e)
        {
            loginUser();
            
        }

        public void loginUser()
        {
            using (EUIm db = new EUIm())
            {

                var model = db.accountants.Where(x => x.username == usernametxt.Text.Trim() &&
                x.password == passwordtxt.Text.Trim()).FirstOrDefault();
                if (model != null)
                {
                    this.Hide();
                    Index firstpage = new Index();
                    firstpage.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
        

        private void usernametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                passwordtxt.Focus();
                passwordtxt.Text = "";
            }
        }

        private void passwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginUser();
            }
        }
        
    }
}
