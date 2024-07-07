namespace Hotel_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btClientDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btClientRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.btAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltitle2 = new System.Windows.Forms.Label();
            this.lbltitle1 = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.panelCopyright = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelTimeLogout = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.llLogout = new System.Windows.Forms.LinkLabel();
            this.picAccount = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.uc_Employee1 = new Hotel_Management_System.All_User_Control.Uc_Employee();
            this.uc_CustomerDetails1 = new Hotel_Management_System.All_User_Control.Uc_CustomerDetails();
            this.uc_CostomerCheckInOut1 = new Hotel_Management_System.User_Control.Uc_CostomerCheckInOut();
            this.uc_CostomerRegistration1 = new Hotel_Management_System.User_Control.Uc_CostomerRegistration();
            this.uc_AddRoom1 = new Hotel_Management_System.Uc_AddRoom();
            this.Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ButtonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.panelCopyright.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.panelTimeLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.ButtonPanel.Controls.Add(this.panelSlide);
            this.ButtonPanel.Controls.Add(this.btEmployee);
            this.ButtonPanel.Controls.Add(this.btClientDetails);
            this.ButtonPanel.Controls.Add(this.btCheckout);
            this.ButtonPanel.Controls.Add(this.btClientRegistration);
            this.ButtonPanel.Controls.Add(this.btAddRoom);
            this.ButtonPanel.Controls.Add(this.panel2);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(356, 720);
            this.ButtonPanel.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(15, 233);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(8, 56);
            this.panelSlide.TabIndex = 0;
            this.panelSlide.Visible = false;
            // 
            // btEmployee
            // 
            this.btEmployee.BorderRadius = 26;
            this.btEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.btEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btEmployee.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployee.ForeColor = System.Drawing.Color.White;
            this.btEmployee.Image = global::Hotel_Management_System.Properties.Resources.icons8_employee_64;
            this.btEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btEmployee.ImageSize = new System.Drawing.Size(45, 45);
            this.btEmployee.Location = new System.Drawing.Point(23, 495);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Size = new System.Drawing.Size(333, 60);
            this.btEmployee.TabIndex = 5;
            this.btEmployee.Text = "Employee";
            this.btEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
            // 
            // btClientDetails
            // 
            this.btClientDetails.BorderRadius = 26;
            this.btClientDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btClientDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btClientDetails.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.btClientDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btClientDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btClientDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btClientDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btClientDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btClientDetails.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientDetails.ForeColor = System.Drawing.Color.White;
            this.btClientDetails.Image = global::Hotel_Management_System.Properties.Resources.icons8_client_64;
            this.btClientDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btClientDetails.ImageSize = new System.Drawing.Size(45, 45);
            this.btClientDetails.Location = new System.Drawing.Point(23, 429);
            this.btClientDetails.Name = "btClientDetails";
            this.btClientDetails.Size = new System.Drawing.Size(333, 60);
            this.btClientDetails.TabIndex = 4;
            this.btClientDetails.Text = "Customer Details";
            this.btClientDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btClientDetails.Click += new System.EventHandler(this.btClientDetails_Click);
            // 
            // btCheckout
            // 
            this.btCheckout.BorderRadius = 26;
            this.btCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCheckout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btCheckout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.btCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btCheckout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckout.ForeColor = System.Drawing.Color.White;
            this.btCheckout.Image = global::Hotel_Management_System.Properties.Resources.icons8_check_out_64;
            this.btCheckout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btCheckout.ImageSize = new System.Drawing.Size(45, 45);
            this.btCheckout.Location = new System.Drawing.Point(23, 363);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(333, 60);
            this.btCheckout.TabIndex = 3;
            this.btCheckout.Text = "Check In , Out";
            this.btCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btCheckout.Click += new System.EventHandler(this.btCheckout_Click);
            // 
            // btClientRegistration
            // 
            this.btClientRegistration.BorderRadius = 26;
            this.btClientRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btClientRegistration.CheckedState.FillColor = System.Drawing.Color.White;
            this.btClientRegistration.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.btClientRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btClientRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btClientRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btClientRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btClientRegistration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btClientRegistration.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientRegistration.ForeColor = System.Drawing.Color.White;
            this.btClientRegistration.Image = global::Hotel_Management_System.Properties.Resources.icons8_registration_100;
            this.btClientRegistration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btClientRegistration.ImageSize = new System.Drawing.Size(45, 45);
            this.btClientRegistration.Location = new System.Drawing.Point(23, 297);
            this.btClientRegistration.Name = "btClientRegistration";
            this.btClientRegistration.Size = new System.Drawing.Size(333, 60);
            this.btClientRegistration.TabIndex = 2;
            this.btClientRegistration.Text = "Customer Registration";
            this.btClientRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btClientRegistration.Click += new System.EventHandler(this.btClientRegistration_Click);
            // 
            // btAddRoom
            // 
            this.btAddRoom.BorderRadius = 26;
            this.btAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btAddRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.btAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btAddRoom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddRoom.ForeColor = System.Drawing.Color.White;
            this.btAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btAddRoom.Image")));
            this.btAddRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btAddRoom.ImageSize = new System.Drawing.Size(45, 45);
            this.btAddRoom.Location = new System.Drawing.Point(23, 231);
            this.btAddRoom.Name = "btAddRoom";
            this.btAddRoom.Size = new System.Drawing.Size(333, 60);
            this.btAddRoom.TabIndex = 1;
            this.btAddRoom.Text = "Add Room";
            this.btAddRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btAddRoom.Click += new System.EventHandler(this.btAddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.lbltitle2);
            this.panel2.Controls.Add(this.lbltitle1);
            this.panel2.Controls.Add(this.picHome);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 201);
            this.panel2.TabIndex = 0;
            // 
            // lbltitle2
            // 
            this.lbltitle2.AutoSize = true;
            this.lbltitle2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle2.ForeColor = System.Drawing.Color.White;
            this.lbltitle2.Location = new System.Drawing.Point(119, 137);
            this.lbltitle2.Name = "lbltitle2";
            this.lbltitle2.Size = new System.Drawing.Size(143, 43);
            this.lbltitle2.TabIndex = 0;
            this.lbltitle2.Text = "System";
            // 
            // lbltitle1
            // 
            this.lbltitle1.AutoSize = true;
            this.lbltitle1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle1.ForeColor = System.Drawing.Color.White;
            this.lbltitle1.Location = new System.Drawing.Point(52, 99);
            this.lbltitle1.Name = "lbltitle1";
            this.lbltitle1.Size = new System.Drawing.Size(358, 43);
            this.lbltitle1.TabIndex = 0;
            this.lbltitle1.Text = "Hotel Management";
            // 
            // picHome
            // 
            this.picHome.Image = global::Hotel_Management_System.Properties.Resources.icons8_home_page_100;
            this.picHome.Location = new System.Drawing.Point(103, 0);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(120, 99);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 0;
            this.picHome.TabStop = false;
            // 
            // panelCopyright
            // 
            this.panelCopyright.Controls.Add(this.lblCopyright);
            this.panelCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCopyright.Location = new System.Drawing.Point(356, 671);
            this.panelCopyright.Name = "panelCopyright";
            this.panelCopyright.Size = new System.Drawing.Size(1010, 49);
            this.panelCopyright.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(6, 14);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(716, 23);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Copyright © 2023. All Rights Reserved by 20BCA072,20BCA087,20BCA098";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panelWelcome.Controls.Add(this.lblUsername);
            this.panelWelcome.Controls.Add(this.lblWelcome);
            this.panelWelcome.Controls.Add(this.panelTimeLogout);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(356, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1010, 201);
            this.panelWelcome.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(173, 137);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(31, 34);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "?";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(6, 137);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(161, 34);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome :";
            // 
            // panelTimeLogout
            // 
            this.panelTimeLogout.BackColor = System.Drawing.Color.White;
            this.panelTimeLogout.Controls.Add(this.lblDateTime);
            this.panelTimeLogout.Controls.Add(this.llLogout);
            this.panelTimeLogout.Controls.Add(this.picAccount);
            this.panelTimeLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimeLogout.Location = new System.Drawing.Point(0, 0);
            this.panelTimeLogout.Name = "panelTimeLogout";
            this.panelTimeLogout.Size = new System.Drawing.Size(1010, 90);
            this.panelTimeLogout.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lblDateTime.Location = new System.Drawing.Point(16, 54);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(27, 30);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "?";
            // 
            // llLogout
            // 
            this.llLogout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.llLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llLogout.AutoSize = true;
            this.llLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llLogout.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.llLogout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.llLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.llLogout.Location = new System.Drawing.Point(897, 44);
            this.llLogout.Name = "llLogout";
            this.llLogout.Size = new System.Drawing.Size(86, 23);
            this.llLogout.TabIndex = 0;
            this.llLogout.TabStop = true;
            this.llLogout.Text = "Log Out";
            this.llLogout.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.llLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLogout_LinkClicked);
            // 
            // picAccount
            // 
            this.picAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAccount.Image = ((System.Drawing.Image)(resources.GetObject("picAccount.Image")));
            this.picAccount.Location = new System.Drawing.Point(830, 12);
            this.picAccount.Name = "picAccount";
            this.picAccount.Size = new System.Drawing.Size(65, 65);
            this.picAccount.TabIndex = 0;
            this.picAccount.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.uc_Employee1);
            this.mainPanel.Controls.Add(this.uc_CustomerDetails1);
            this.mainPanel.Controls.Add(this.uc_CostomerCheckInOut1);
            this.mainPanel.Controls.Add(this.uc_CostomerRegistration1);
            this.mainPanel.Controls.Add(this.uc_AddRoom1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(356, 201);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1010, 470);
            this.mainPanel.TabIndex = 1;
            // 
            // uc_Employee1
            // 
            this.uc_Employee1.BackColor = System.Drawing.Color.White;
            this.uc_Employee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_Employee1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Employee1.Location = new System.Drawing.Point(0, 0);
            this.uc_Employee1.Name = "uc_Employee1";
            this.uc_Employee1.Size = new System.Drawing.Size(1010, 470);
            this.uc_Employee1.TabIndex = 4;
            // 
            // uc_CustomerDetails1
            // 
            this.uc_CustomerDetails1.BackColor = System.Drawing.Color.White;
            this.uc_CustomerDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_CustomerDetails1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_CustomerDetails1.Location = new System.Drawing.Point(0, 0);
            this.uc_CustomerDetails1.Name = "uc_CustomerDetails1";
            this.uc_CustomerDetails1.Size = new System.Drawing.Size(1010, 470);
            this.uc_CustomerDetails1.TabIndex = 3;
            // 
            // uc_CostomerCheckInOut1
            // 
            this.uc_CostomerCheckInOut1.BackColor = System.Drawing.Color.White;
            this.uc_CostomerCheckInOut1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_CostomerCheckInOut1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_CostomerCheckInOut1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uc_CostomerCheckInOut1.Location = new System.Drawing.Point(0, 0);
            this.uc_CostomerCheckInOut1.Name = "uc_CostomerCheckInOut1";
            this.uc_CostomerCheckInOut1.Size = new System.Drawing.Size(1010, 470);
            this.uc_CostomerCheckInOut1.TabIndex = 2;
            // 
            // uc_CostomerRegistration1
            // 
            this.uc_CostomerRegistration1.BackColor = System.Drawing.Color.White;
            this.uc_CostomerRegistration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_CostomerRegistration1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_CostomerRegistration1.Location = new System.Drawing.Point(0, 0);
            this.uc_CostomerRegistration1.Name = "uc_CostomerRegistration1";
            this.uc_CostomerRegistration1.Size = new System.Drawing.Size(1010, 470);
            this.uc_CostomerRegistration1.TabIndex = 1;
            // 
            // uc_AddRoom1
            // 
            this.uc_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uc_AddRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_AddRoom1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_AddRoom1.Location = new System.Drawing.Point(0, 0);
            this.uc_AddRoom1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uc_AddRoom1.Name = "uc_AddRoom1";
            this.uc_AddRoom1.Size = new System.Drawing.Size(1010, 470);
            this.uc_AddRoom1.TabIndex = 0;
            // 
            // Elipse1
            // 
            this.Elipse1.BorderRadius = 30;
            this.Elipse1.TargetControl = this;
            // 
            // Elipse2
            // 
            this.Elipse2.BorderRadius = 30;
            this.Elipse2.TargetControl = this;
            // 
            // Elipse3
            // 
            this.Elipse3.BorderRadius = 30;
            this.Elipse3.TargetControl = this;
            // 
            // Elipse4
            // 
            this.Elipse4.BorderRadius = 30;
            this.Elipse4.TargetControl = this;
            // 
            // Elipse5
            // 
            this.Elipse5.BorderRadius = 30;
            this.Elipse5.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelCopyright);
            this.Controls.Add(this.ButtonPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System | Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ButtonPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.panelCopyright.ResumeLayout(false);
            this.panelCopyright.PerformLayout();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelTimeLogout.ResumeLayout(false);
            this.panelTimeLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCopyright;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Panel panelTimeLogout;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox picAccount;
        private System.Windows.Forms.LinkLabel llLogout;
        private System.Windows.Forms.Label lbltitle1;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lbltitle2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDateTime;
        private Guna.UI2.WinForms.Guna2Button btAddRoom;
        private Guna.UI2.WinForms.Guna2Button btEmployee;
        private Guna.UI2.WinForms.Guna2Button btClientDetails;
        private Guna.UI2.WinForms.Guna2Button btCheckout;
        private Guna.UI2.WinForms.Guna2Button btClientRegistration;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Elipse Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse Elipse5;
        private All_User_Control.Uc_Employee uc_Employee1;
        private All_User_Control.Uc_CustomerDetails uc_CustomerDetails1;
        private User_Control.Uc_CostomerCheckInOut uc_CostomerCheckInOut1;
        private User_Control.Uc_CostomerRegistration uc_CostomerRegistration1;
        private Uc_AddRoom uc_AddRoom1;
    }
}