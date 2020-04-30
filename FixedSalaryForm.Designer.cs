namespace AutomatedSalaryProcessingSystem
{
    partial class Fixed_salaryForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixedSalaryStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.nKinAddresstxt = new System.Windows.Forms.TextBox();
            this.nKinRealtxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.nKinEmailtxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nKinNametxt = new System.Windows.Forms.TextBox();
            this.nKinTeltxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.teltxt = new System.Windows.Forms.TextBox();
            this.otherNametxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gendercb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dobdt = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.facultyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.depcb = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentList = new AutomatedSalaryProcessingSystem.departmentList();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.catcb = new System.Windows.Forms.ComboBox();
            this.facultyListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new AutomatedSalaryProcessingSystem.departmentListTableAdapters.departmentTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "Navigator";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixedSalaryStaffToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fixedSalaryStaffToolStripMenuItem
            // 
            this.fixedSalaryStaffToolStripMenuItem.Name = "fixedSalaryStaffToolStripMenuItem";
            this.fixedSalaryStaffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fixedSalaryStaffToolStripMenuItem.Text = "Employees";
            this.fixedSalaryStaffToolStripMenuItem.Click += new System.EventHandler(this.fixedSalaryStaffToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nKinAddresstxt);
            this.panel2.Controls.Add(this.nKinRealtxt);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.nKinEmailtxt);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nKinNametxt);
            this.panel2.Controls.Add(this.nKinTeltxt);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(479, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 224);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(107, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Employee Next of Kin Data";
            // 
            // nKinAddresstxt
            // 
            this.nKinAddresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nKinAddresstxt.Location = new System.Drawing.Point(101, 151);
            this.nKinAddresstxt.Multiline = true;
            this.nKinAddresstxt.Name = "nKinAddresstxt";
            this.nKinAddresstxt.Size = new System.Drawing.Size(255, 61);
            this.nKinAddresstxt.TabIndex = 31;
            // 
            // nKinRealtxt
            // 
            this.nKinRealtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nKinRealtxt.Location = new System.Drawing.Point(101, 63);
            this.nKinRealtxt.Name = "nKinRealtxt";
            this.nKinRealtxt.Size = new System.Drawing.Size(181, 24);
            this.nKinRealtxt.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(41, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 18);
            this.label19.TabIndex = 41;
            this.label19.Text = "Name";
            // 
            // nKinEmailtxt
            // 
            this.nKinEmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nKinEmailtxt.Location = new System.Drawing.Point(101, 121);
            this.nKinEmailtxt.Name = "nKinEmailtxt";
            this.nKinEmailtxt.Size = new System.Drawing.Size(181, 24);
            this.nKinEmailtxt.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(6, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 18);
            this.label12.TabIndex = 40;
            this.label12.Text = "Relationship";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(33, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "Address";
            // 
            // nKinNametxt
            // 
            this.nKinNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nKinNametxt.Location = new System.Drawing.Point(101, 33);
            this.nKinNametxt.Name = "nKinNametxt";
            this.nKinNametxt.Size = new System.Drawing.Size(181, 24);
            this.nKinNametxt.TabIndex = 30;
            // 
            // nKinTeltxt
            // 
            this.nKinTeltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nKinTeltxt.Location = new System.Drawing.Point(101, 92);
            this.nKinTeltxt.Name = "nKinTeltxt";
            this.nKinTeltxt.Size = new System.Drawing.Size(181, 24);
            this.nKinTeltxt.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(61, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 18);
            this.label11.TabIndex = 39;
            this.label11.Text = "Tel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(44, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Email";
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCapture.BackColor = System.Drawing.Color.LightGreen;
            this.btnCapture.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCapture.FlatAppearance.BorderSize = 50;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapture.Font = new System.Drawing.Font("Futura Md BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapture.Location = new System.Drawing.Point(689, 555);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(156, 47);
            this.btnCapture.TabIndex = 13;
            this.btnCapture.Text = "&CAPTURE STAFF\r\n";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.capture_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Image = global::AutomatedSalaryProcessingSystem.Properties.Resources.icons8_green_arrow_96;
            this.btnBack.Location = new System.Drawing.Point(35, 557);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 46);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 14;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(41, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(75, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(62, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Othernames";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Firstname";
            // 
            // firstNametxt
            // 
            this.firstNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNametxt.Location = new System.Drawing.Point(109, 25);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(181, 24);
            this.firstNametxt.TabIndex = 17;
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(109, 220);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(255, 61);
            this.addresstxt.TabIndex = 18;
            // 
            // lastNametxt
            // 
            this.lastNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNametxt.Location = new System.Drawing.Point(109, 55);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(181, 24);
            this.lastNametxt.TabIndex = 19;
            // 
            // teltxt
            // 
            this.teltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teltxt.Location = new System.Drawing.Point(109, 141);
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(181, 24);
            this.teltxt.TabIndex = 20;
            // 
            // otherNametxt
            // 
            this.otherNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherNametxt.Location = new System.Drawing.Point(109, 84);
            this.otherNametxt.Name = "otherNametxt";
            this.otherNametxt.Size = new System.Drawing.Size(181, 24);
            this.otherNametxt.TabIndex = 21;
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(109, 113);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(181, 24);
            this.emailtxt.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(72, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 303);
            this.panel1.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.gendercb);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.dobdt);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.lastNametxt);
            this.panel4.Controls.Add(this.emailtxt);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.otherNametxt);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.teltxt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.addresstxt);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.firstNametxt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(75, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 298);
            this.panel4.TabIndex = 2;
            // 
            // gendercb
            // 
            this.gendercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercb.FormattingEnabled = true;
            this.gendercb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gendercb.Location = new System.Drawing.Point(109, 168);
            this.gendercb.Name = "gendercb";
            this.gendercb.Size = new System.Drawing.Size(97, 21);
            this.gendercb.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(17, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Date Of Birth";
            // 
            // dobdt
            // 
            this.dobdt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobdt.Location = new System.Drawing.Point(109, 194);
            this.dobdt.Name = "dobdt";
            this.dobdt.Size = new System.Drawing.Size(97, 20);
            this.dobdt.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(87, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 18);
            this.label18.TabIndex = 29;
            this.label18.Text = "Employee Personal Data";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(50, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 18);
            this.label15.TabIndex = 24;
            this.label15.Text = "Gender";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Image = global::AutomatedSalaryProcessingSystem.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(400, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(326, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 31);
            this.label9.TabIndex = 33;
            this.label9.Text = "Capture Staff Data";
            // 
            // depcb
            // 
            this.depcb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depcb.DataSource = this.departmentBindingSource;
            this.depcb.DisplayMember = "departmentName";
            this.depcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depcb.Enabled = false;
            this.depcb.FormattingEnabled = true;
            this.depcb.Location = new System.Drawing.Point(80, 56);
            this.depcb.Name = "depcb";
            this.depcb.Size = new System.Drawing.Size(205, 21);
            this.depcb.TabIndex = 0;
            this.depcb.ValueMember = "departmentName";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.departmentList;
            // 
            // departmentList
            // 
            this.departmentList.DataSetName = "departmentList";
            this.departmentList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Department";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(110, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 18);
            this.label20.TabIndex = 30;
            this.label20.Text = "Employee Status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.catcb);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.depcb);
            this.panel3.Location = new System.Drawing.Point(479, 443);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 89);
            this.panel3.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "Category";
            // 
            // catcb
            // 
            this.catcb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.catcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catcb.FormattingEnabled = true;
            this.catcb.Items.AddRange(new object[] {
            "Academic",
            "Non-academic"});
            this.catcb.Location = new System.Drawing.Point(80, 29);
            this.catcb.Name = "catcb";
            this.catcb.Size = new System.Drawing.Size(121, 21);
            this.catcb.TabIndex = 31;
            this.catcb.SelectedIndexChanged += new System.EventHandler(this.catcb_SelectedIndexChanged);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // Fixed_salaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(903, 618);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(919, 657);
            this.Name = "Fixed_salaryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Processing System";
            this.Load += new System.EventHandler(this.Fixed_salaryForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Fixed_salaryForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixedSalaryStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNametxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox lastNametxt;
        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.TextBox otherNametxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nKinAddresstxt;
        private System.Windows.Forms.TextBox nKinRealtxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox nKinEmailtxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nKinNametxt;
        private System.Windows.Forms.TextBox nKinTeltxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox depcb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource facultyBindingSource1;
        private System.Windows.Forms.BindingSource facultyListBindingSource;
        private departmentList departmentList;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private departmentListTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox catcb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dobdt;
        private System.Windows.Forms.ComboBox gendercb;
        private System.Windows.Forms.Label label15;
    }
}