namespace AutomatedSalaryProcessingSystem
{
    partial class processSalary
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
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stepList = new AutomatedSalaryProcessingSystem.StepList();
            this.ranksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rankds = new AutomatedSalaryProcessingSystem.rankds();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixedSalaryStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stepTableAdapter = new AutomatedSalaryProcessingSystem.StepListTableAdapters.stepTableAdapter();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.ranksTableAdapter = new AutomatedSalaryProcessingSystem.rankdsTableAdapters.ranksTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbworkingHours = new System.Windows.Forms.ComboBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.genPaySlipbtn = new System.Windows.Forms.Button();
            this.proSalarybtn = new System.Windows.Forms.Button();
            this.stepcb = new System.Windows.Forms.ComboBox();
            this.rankcb = new System.Windows.Forms.ComboBox();
            this.levelcb = new System.Windows.Forms.ComboBox();
            this.levelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelds = new AutomatedSalaryProcessingSystem.levelds();
            this.hoursWorkedtxt = new System.Windows.Forms.TextBox();
            this.empIDtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.levelTableAdapter = new AutomatedSalaryProcessingSystem.leveldsTableAdapters.levelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankds)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.euiDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelds)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(167, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 31);
            this.label9.TabIndex = 35;
            this.label9.Text = "Process Employee Salary";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Image = global::AutomatedSalaryProcessingSystem.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(256, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // stepBindingSource
            // 
            this.stepBindingSource.DataMember = "step";
            this.stepBindingSource.DataSource = this.stepList;
            // 
            // stepList
            // 
            this.stepList.DataSetName = "StepList";
            this.stepList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ranksBindingSource
            // 
            this.ranksBindingSource.DataMember = "ranks";
            this.ranksBindingSource.DataSource = this.rankds;
            // 
            // rankds
            // 
            this.rankds.DataSetName = "rankds";
            this.rankds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
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
            this.fixedSalaryStaffToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.fixedSalaryStaffToolStripMenuItem.Text = "Fixed-Salary Staff";
            this.fixedSalaryStaffToolStripMenuItem.Click += new System.EventHandler(this.fixedSalaryStaffToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // stepTableAdapter
            // 
            this.stepTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Image = global::AutomatedSalaryProcessingSystem.Properties.Resources.icons8_green_arrow_96;
            this.btnBack.Location = new System.Drawing.Point(22, 433);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 39);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 47;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ranksTableAdapter
            // 
            this.ranksTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.cbworkingHours);
            this.groupBox1.Controls.Add(this.cbPosition);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.genPaySlipbtn);
            this.groupBox1.Controls.Add(this.proSalarybtn);
            this.groupBox1.Controls.Add(this.stepcb);
            this.groupBox1.Controls.Add(this.rankcb);
            this.groupBox1.Controls.Add(this.levelcb);
            this.groupBox1.Controls.Add(this.hoursWorkedtxt);
            this.groupBox1.Controls.Add(this.empIDtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(148, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 234);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Data";
            // 
            // cbworkingHours
            // 
            this.cbworkingHours.DisplayMember = "stepname";
            this.cbworkingHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbworkingHours.Enabled = false;
            this.cbworkingHours.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbworkingHours.FormattingEnabled = true;
            this.cbworkingHours.Items.AddRange(new object[] {
            "Overtime",
            "Regular hours"});
            this.cbworkingHours.Location = new System.Drawing.Point(275, 68);
            this.cbworkingHours.Name = "cbworkingHours";
            this.cbworkingHours.Size = new System.Drawing.Size(101, 26);
            this.cbworkingHours.Sorted = true;
            this.cbworkingHours.TabIndex = 62;
            this.cbworkingHours.ValueMember = "stepname";
            // 
            // cbPosition
            // 
            this.cbPosition.DisplayMember = "levelname";
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.Enabled = false;
            this.cbPosition.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Bursar",
            "Dean",
            "Director",
            "DVC",
            "HOD",
            "None",
            "Provost",
            "Registrar",
            "VC"});
            this.cbPosition.Location = new System.Drawing.Point(275, 35);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(64, 26);
            this.cbPosition.Sorted = true;
            this.cbPosition.TabIndex = 61;
            this.cbPosition.ValueMember = "levelname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(172, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Working Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(215, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "Positon";
            // 
            // genPaySlipbtn
            // 
            this.genPaySlipbtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.genPaySlipbtn.Enabled = false;
            this.genPaySlipbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genPaySlipbtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genPaySlipbtn.Location = new System.Drawing.Point(238, 198);
            this.genPaySlipbtn.Name = "genPaySlipbtn";
            this.genPaySlipbtn.Size = new System.Drawing.Size(138, 30);
            this.genPaySlipbtn.TabIndex = 58;
            this.genPaySlipbtn.Text = "Generate Payslip";
            this.genPaySlipbtn.UseVisualStyleBackColor = false;
            this.genPaySlipbtn.Click += new System.EventHandler(this.genPaySlipbtn_Click);
            // 
            // proSalarybtn
            // 
            this.proSalarybtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.proSalarybtn.Enabled = false;
            this.proSalarybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.proSalarybtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proSalarybtn.Location = new System.Drawing.Point(6, 198);
            this.proSalarybtn.Name = "proSalarybtn";
            this.proSalarybtn.Size = new System.Drawing.Size(136, 30);
            this.proSalarybtn.TabIndex = 57;
            this.proSalarybtn.Text = "Process Salary";
            this.proSalarybtn.UseVisualStyleBackColor = false;
            this.proSalarybtn.Click += new System.EventHandler(this.proSalarybtn_Click);
            // 
            // stepcb
            // 
            this.stepcb.DataSource = this.stepBindingSource;
            this.stepcb.DisplayMember = "stepname";
            this.stepcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepcb.Enabled = false;
            this.stepcb.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepcb.FormattingEnabled = true;
            this.stepcb.Location = new System.Drawing.Point(108, 121);
            this.stepcb.Name = "stepcb";
            this.stepcb.Size = new System.Drawing.Size(64, 26);
            this.stepcb.TabIndex = 56;
            this.stepcb.ValueMember = "stepname";
            // 
            // rankcb
            // 
            this.rankcb.DataSource = this.ranksBindingSource;
            this.rankcb.DisplayMember = "rankName";
            this.rankcb.DropDownHeight = 105;
            this.rankcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankcb.Enabled = false;
            this.rankcb.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankcb.FormattingEnabled = true;
            this.rankcb.IntegralHeight = false;
            this.rankcb.Location = new System.Drawing.Point(107, 151);
            this.rankcb.Name = "rankcb";
            this.rankcb.Size = new System.Drawing.Size(205, 26);
            this.rankcb.TabIndex = 55;
            this.rankcb.ValueMember = "rankName";
            // 
            // levelcb
            // 
            this.levelcb.DataSource = this.levelBindingSource;
            this.levelcb.DisplayMember = "levelname";
            this.levelcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelcb.Enabled = false;
            this.levelcb.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelcb.FormattingEnabled = true;
            this.levelcb.Location = new System.Drawing.Point(108, 92);
            this.levelcb.Name = "levelcb";
            this.levelcb.Size = new System.Drawing.Size(64, 26);
            this.levelcb.TabIndex = 54;
            this.levelcb.ValueMember = "levelname";
            // 
            // levelBindingSource
            // 
            this.levelBindingSource.DataMember = "level";
            this.levelBindingSource.DataSource = this.levelds;
            // 
            // levelds
            // 
            this.levelds.DataSetName = "levelds";
            this.levelds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoursWorkedtxt
            // 
            this.hoursWorkedtxt.Enabled = false;
            this.hoursWorkedtxt.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedtxt.Location = new System.Drawing.Point(108, 63);
            this.hoursWorkedtxt.MaxLength = 20;
            this.hoursWorkedtxt.Name = "hoursWorkedtxt";
            this.hoursWorkedtxt.Size = new System.Drawing.Size(64, 26);
            this.hoursWorkedtxt.TabIndex = 47;
            // 
            // empIDtxt
            // 
            this.empIDtxt.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDtxt.Location = new System.Drawing.Point(108, 35);
            this.empIDtxt.MaxLength = 20;
            this.empIDtxt.Name = "empIDtxt";
            this.empIDtxt.Size = new System.Drawing.Size(64, 26);
            this.empIDtxt.TabIndex = 48;
            this.empIDtxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.empIDtxt_Up);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(26, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Salary Step";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(61, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Rank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(54, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Hours Worked";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Employee ID";
            // 
            // levelTableAdapter
            // 
            this.levelTableAdapter.ClearBeforeFill = true;
            // 
            // processSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::AutomatedSalaryProcessingSystem.Properties.Resources.logoT1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "processSalary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fixedprocessSalary";
            this.Load += new System.EventHandler(this.fixedprocessSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankds)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.euiDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixedSalaryStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.BindingSource euiDataSet1BindingSource;
        private System.Windows.Forms.BindingSource euiDataSet2BindingSource;
        private StepList stepList;
        private System.Windows.Forms.BindingSource stepBindingSource;
        private StepListTableAdapters.stepTableAdapter stepTableAdapter;
        private System.Windows.Forms.PictureBox btnBack;
        private rankds rankds;
        private System.Windows.Forms.BindingSource ranksBindingSource;
        private rankdsTableAdapters.ranksTableAdapter ranksTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button genPaySlipbtn;
        private System.Windows.Forms.Button proSalarybtn;
        private System.Windows.Forms.ComboBox stepcb;
        private System.Windows.Forms.ComboBox rankcb;
        private System.Windows.Forms.ComboBox levelcb;
        private System.Windows.Forms.TextBox hoursWorkedtxt;
        private System.Windows.Forms.TextBox empIDtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private levelds levelds;
        private System.Windows.Forms.BindingSource levelBindingSource;
        private leveldsTableAdapters.levelTableAdapter levelTableAdapter;
        private System.Windows.Forms.ComboBox cbworkingHours;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}