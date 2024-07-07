namespace Hotel_Management_System.All_User_Control
{
    partial class Uc_Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAddroom = new System.Windows.Forms.Label();
            this.ElipseEmployee = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Employee = new System.Windows.Forms.TabControl();
            this.EmpRegi = new System.Windows.Forms.TabPage();
            this.btRegister = new Guna.UI2.WinForms.Guna2Button();
            this.cmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtEmailid = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMobileNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMobileno = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRedid = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.EmpDetails = new System.Windows.Forms.TabPage();
            this.dataGVEmpDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Empdelete = new System.Windows.Forms.TabPage();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.dataGVDeleted = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.Employee.SuspendLayout();
            this.EmpRegi.SuspendLayout();
            this.EmpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVEmpDetails)).BeginInit();
            this.Empdelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDeleted)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddroom
            // 
            this.lblAddroom.AutoSize = true;
            this.lblAddroom.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddroom.Location = new System.Drawing.Point(5, 8);
            this.lblAddroom.Name = "lblAddroom";
            this.lblAddroom.Size = new System.Drawing.Size(172, 39);
            this.lblAddroom.TabIndex = 2;
            this.lblAddroom.Text = "Employee";
            // 
            // ElipseEmployee
            // 
            this.ElipseEmployee.BorderRadius = 30;
            this.ElipseEmployee.TargetControl = this;
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.EmpRegi);
            this.Employee.Controls.Add(this.EmpDetails);
            this.Employee.Controls.Add(this.Empdelete);
            this.Employee.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(12, 63);
            this.Employee.Name = "Employee";
            this.Employee.SelectedIndex = 0;
            this.Employee.Size = new System.Drawing.Size(903, 404);
            this.Employee.TabIndex = 3;
            this.Employee.SelectedIndexChanged += new System.EventHandler(this.Employee_SelectedIndexChanged);
            // 
            // EmpRegi
            // 
            this.EmpRegi.Controls.Add(this.btRegister);
            this.EmpRegi.Controls.Add(this.cmbGender);
            this.EmpRegi.Controls.Add(this.lblGender);
            this.EmpRegi.Controls.Add(this.txtEmailid);
            this.EmpRegi.Controls.Add(this.lblEmail);
            this.EmpRegi.Controls.Add(this.txtPassword);
            this.EmpRegi.Controls.Add(this.txtUserName);
            this.EmpRegi.Controls.Add(this.txtMobileNo);
            this.EmpRegi.Controls.Add(this.lblPassword);
            this.EmpRegi.Controls.Add(this.txtName);
            this.EmpRegi.Controls.Add(this.lblMobileno);
            this.EmpRegi.Controls.Add(this.lblUserName);
            this.EmpRegi.Controls.Add(this.lblRedid);
            this.EmpRegi.Controls.Add(this.lblID);
            this.EmpRegi.Controls.Add(this.lblname);
            this.EmpRegi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpRegi.Location = new System.Drawing.Point(4, 34);
            this.EmpRegi.Name = "EmpRegi";
            this.EmpRegi.Padding = new System.Windows.Forms.Padding(3);
            this.EmpRegi.Size = new System.Drawing.Size(895, 366);
            this.EmpRegi.TabIndex = 0;
            this.EmpRegi.Text = "Employee Registration";
            this.EmpRegi.UseVisualStyleBackColor = true;
            this.EmpRegi.Leave += new System.EventHandler(this.EmpRegi_Leave);
            // 
            // btRegister
            // 
            this.btRegister.BorderRadius = 22;
            this.btRegister.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btRegister.BorderThickness = 1;
            this.btRegister.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btRegister.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btRegister.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegister.DisabledState.FillColor = System.Drawing.Color.White;
            this.btRegister.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btRegister.FillColor = System.Drawing.Color.White;
            this.btRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.Color.Black;
            this.btRegister.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btRegister.HoverState.ForeColor = System.Drawing.Color.White;
            this.btRegister.Location = new System.Drawing.Point(566, 275);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(252, 45);
            this.btRegister.TabIndex = 7;
            this.btRegister.Text = "Register";
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGender.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbGender.ItemHeight = 30;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(31, 241);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(252, 36);
            this.cmbGender.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(27, 212);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(85, 23);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // txtEmailid
            // 
            this.txtEmailid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailid.DefaultText = "";
            this.txtEmailid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailid.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtEmailid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmailid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailid.Location = new System.Drawing.Point(31, 326);
            this.txtEmailid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmailid.Name = "txtEmailid";
            this.txtEmailid.PasswordChar = '\0';
            this.txtEmailid.PlaceholderText = "Enter Email Id";
            this.txtEmailid.SelectedText = "";
            this.txtEmailid.Size = new System.Drawing.Size(252, 32);
            this.txtEmailid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEmailid.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(27, 297);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email Id";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(566, 162);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Enter Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(252, 32);
            this.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(566, 91);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "Enter Username";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(252, 32);
            this.txtUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUserName.TabIndex = 5;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobileNo.DefaultText = "";
            this.txtMobileNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMobileNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMobileNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobileNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobileNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobileNo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtMobileNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMobileNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobileNo.Location = new System.Drawing.Point(31, 162);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.PasswordChar = '\0';
            this.txtMobileNo.PlaceholderText = "Enter Contact No";
            this.txtMobileNo.SelectedText = "";
            this.txtMobileNo.Size = new System.Drawing.Size(252, 32);
            this.txtMobileNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMobileNo.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(562, 133);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 23);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(31, 91);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Full Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(252, 32);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 1;
            // 
            // lblMobileno
            // 
            this.lblMobileno.AutoSize = true;
            this.lblMobileno.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileno.Location = new System.Drawing.Point(27, 133);
            this.lblMobileno.Name = "lblMobileno";
            this.lblMobileno.Size = new System.Drawing.Size(109, 23);
            this.lblMobileno.TabIndex = 0;
            this.lblMobileno.Text = "Mobile No";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(562, 62);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(117, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // lblRedid
            // 
            this.lblRedid.AutoSize = true;
            this.lblRedid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedid.ForeColor = System.Drawing.Color.Red;
            this.lblRedid.Location = new System.Drawing.Point(80, 24);
            this.lblRedid.Name = "lblRedid";
            this.lblRedid.Size = new System.Drawing.Size(42, 28);
            this.lblRedid.TabIndex = 0;
            this.lblRedid.Text = "---";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(27, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(49, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID  -";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(27, 62);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(71, 23);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // EmpDetails
            // 
            this.EmpDetails.Controls.Add(this.dataGVEmpDetails);
            this.EmpDetails.Controls.Add(this.label6);
            this.EmpDetails.Location = new System.Drawing.Point(4, 34);
            this.EmpDetails.Name = "EmpDetails";
            this.EmpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.EmpDetails.Size = new System.Drawing.Size(895, 366);
            this.EmpDetails.TabIndex = 1;
            this.EmpDetails.Text = "Employee Details";
            this.EmpDetails.UseVisualStyleBackColor = true;
            // 
            // dataGVEmpDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGVEmpDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVEmpDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGVEmpDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVEmpDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVEmpDetails.ColumnHeadersHeight = 25;
            this.dataGVEmpDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVEmpDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVEmpDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGVEmpDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVEmpDetails.Location = new System.Drawing.Point(3, 52);
            this.dataGVEmpDetails.Name = "dataGVEmpDetails";
            this.dataGVEmpDetails.ReadOnly = true;
            this.dataGVEmpDetails.RowHeadersVisible = false;
            this.dataGVEmpDetails.RowHeadersWidth = 70;
            this.dataGVEmpDetails.RowTemplate.Height = 25;
            this.dataGVEmpDetails.Size = new System.Drawing.Size(889, 308);
            this.dataGVEmpDetails.TabIndex = 4;
            this.dataGVEmpDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGVEmpDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGVEmpDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGVEmpDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGVEmpDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGVEmpDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGVEmpDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVEmpDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGVEmpDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGVEmpDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGVEmpDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGVEmpDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGVEmpDetails.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGVEmpDetails.ThemeStyle.ReadOnly = true;
            this.dataGVEmpDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGVEmpDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGVEmpDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGVEmpDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGVEmpDetails.ThemeStyle.RowsStyle.Height = 25;
            this.dataGVEmpDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVEmpDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 34);
            this.label6.TabIndex = 3;
            this.label6.Text = "Employee Details";
            // 
            // Empdelete
            // 
            this.Empdelete.Controls.Add(this.lbl_ID);
            this.Empdelete.Controls.Add(this.dataGVDeleted);
            this.Empdelete.Controls.Add(this.btDelete);
            this.Empdelete.Controls.Add(this.txtID);
            this.Empdelete.Location = new System.Drawing.Point(4, 34);
            this.Empdelete.Name = "Empdelete";
            this.Empdelete.Padding = new System.Windows.Forms.Padding(3);
            this.Empdelete.Size = new System.Drawing.Size(895, 366);
            this.Empdelete.TabIndex = 2;
            this.Empdelete.Text = "Delete Employee";
            this.Empdelete.UseVisualStyleBackColor = true;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(325, 25);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(49, 23);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID  -";
            // 
            // dataGVDeleted
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGVDeleted.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGVDeleted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGVDeleted.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVDeleted.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGVDeleted.ColumnHeadersHeight = 25;
            this.dataGVDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVDeleted.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGVDeleted.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGVDeleted.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVDeleted.Location = new System.Drawing.Point(3, 166);
            this.dataGVDeleted.Name = "dataGVDeleted";
            this.dataGVDeleted.ReadOnly = true;
            this.dataGVDeleted.RowHeadersVisible = false;
            this.dataGVDeleted.RowHeadersWidth = 70;
            this.dataGVDeleted.RowTemplate.Height = 25;
            this.dataGVDeleted.Size = new System.Drawing.Size(889, 194);
            this.dataGVDeleted.TabIndex = 10;
            this.dataGVDeleted.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGVDeleted.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGVDeleted.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGVDeleted.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGVDeleted.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGVDeleted.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGVDeleted.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVDeleted.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGVDeleted.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGVDeleted.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGVDeleted.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGVDeleted.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGVDeleted.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGVDeleted.ThemeStyle.ReadOnly = true;
            this.dataGVDeleted.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGVDeleted.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGVDeleted.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGVDeleted.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGVDeleted.ThemeStyle.RowsStyle.Height = 25;
            this.dataGVDeleted.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVDeleted.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGVDeleted.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVDeleted_CellContentClick);
            // 
            // btDelete
            // 
            this.btDelete.BorderRadius = 22;
            this.btDelete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btDelete.BorderThickness = 1;
            this.btDelete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btDelete.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btDelete.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.DisabledState.FillColor = System.Drawing.Color.White;
            this.btDelete.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btDelete.FillColor = System.Drawing.Color.White;
            this.btDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.Black;
            this.btDelete.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btDelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(440, 108);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(195, 45);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(329, 48);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "Enter ID";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(306, 47);
            this.txtID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtID.TabIndex = 1;
            // 
            // Uc_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.lblAddroom);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Uc_Employee";
            this.Size = new System.Drawing.Size(928, 470);
            this.Load += new System.EventHandler(this.Uc_Employee_Load);
            this.Leave += new System.EventHandler(this.Uc_Employee_Leave);
            this.Employee.ResumeLayout(false);
            this.EmpRegi.ResumeLayout(false);
            this.EmpRegi.PerformLayout();
            this.EmpDetails.ResumeLayout(false);
            this.EmpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVEmpDetails)).EndInit();
            this.Empdelete.ResumeLayout(false);
            this.Empdelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDeleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddroom;
        private Guna.UI2.WinForms.Guna2Elipse ElipseEmployee;
        private System.Windows.Forms.TabControl Employee;
        private System.Windows.Forms.TabPage EmpRegi;
        private System.Windows.Forms.TabPage EmpDetails;
        private System.Windows.Forms.TabPage Empdelete;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailid;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtMobileNo;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblMobileno;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblname;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private Guna.UI2.WinForms.Guna2Button btRegister;
        private Guna.UI2.WinForms.Guna2DataGridView dataGVEmpDetails;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dataGVDeleted;
        private Guna.UI2.WinForms.Guna2Button btDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lblRedid;
    }
}
