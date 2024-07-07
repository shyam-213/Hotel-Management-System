namespace Hotel_Management_System.User_Control
{
    partial class Uc_CostomerRegistration
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
            this.lblCustomerRegistration = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblMobileno = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMobileno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_IDproof = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.txt_IDproof = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbReservation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblBed = new System.Windows.Forms.Label();
            this.cmbBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRoomtype = new System.Windows.Forms.Label();
            this.cmbRoomno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRoomno = new System.Windows.Forms.Label();
            this.cmbRoomtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btReserve = new Guna.UI2.WinForms.Guna2Button();
            this.ElipseRegistration = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // lblCustomerRegistration
            // 
            this.lblCustomerRegistration.AutoSize = true;
            this.lblCustomerRegistration.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerRegistration.Location = new System.Drawing.Point(5, 8);
            this.lblCustomerRegistration.Name = "lblCustomerRegistration";
            this.lblCustomerRegistration.Size = new System.Drawing.Size(356, 39);
            this.lblCustomerRegistration.TabIndex = 0;
            this.lblCustomerRegistration.Text = "Customer Registration";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(8, 63);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(71, 23);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // lblMobileno
            // 
            this.lblMobileno.AutoSize = true;
            this.lblMobileno.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileno.Location = new System.Drawing.Point(8, 142);
            this.lblMobileno.Name = "lblMobileno";
            this.lblMobileno.Size = new System.Drawing.Size(109, 23);
            this.lblMobileno.TabIndex = 0;
            this.lblMobileno.Text = "Mobile No";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.Location = new System.Drawing.Point(8, 218);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(114, 23);
            this.lblNationality.TabIndex = 0;
            this.lblNationality.Text = "Nationality";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(8, 298);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(85, 23);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.txtName.Location = new System.Drawing.Point(12, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Full Name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(252, 37);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 1;
            // 
            // txtMobileno
            // 
            this.txtMobileno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobileno.DefaultText = "";
            this.txtMobileno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMobileno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMobileno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobileno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobileno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobileno.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMobileno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobileno.Location = new System.Drawing.Point(12, 171);
            this.txtMobileno.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMobileno.Name = "txtMobileno";
            this.txtMobileno.PasswordChar = '\0';
            this.txtMobileno.PlaceholderText = "Enter Contact No";
            this.txtMobileno.SelectedText = "";
            this.txtMobileno.Size = new System.Drawing.Size(252, 32);
            this.txtMobileno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMobileno.TabIndex = 2;
            this.txtMobileno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileno_KeyPress);
            // 
            // txtNationality
            // 
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.DefaultText = "";
            this.txtNationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.Location = new System.Drawing.Point(12, 247);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.PlaceholderText = "Nationality";
            this.txtNationality.SelectedText = "";
            this.txtNationality.Size = new System.Drawing.Size(252, 32);
            this.txtNationality.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNationality.TabIndex = 3;
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
            this.cmbGender.Location = new System.Drawing.Point(12, 327);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(252, 36);
            this.cmbGender.TabIndex = 4;
            // 
            // lbl_IDproof
            // 
            this.lbl_IDproof.AutoSize = true;
            this.lbl_IDproof.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDproof.Location = new System.Drawing.Point(327, 63);
            this.lbl_IDproof.Name = "lbl_IDproof";
            this.lbl_IDproof.Size = new System.Drawing.Size(86, 23);
            this.lbl_IDproof.TabIndex = 0;
            this.lbl_IDproof.Text = "ID Proof";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(327, 145);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(88, 23);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckin.Location = new System.Drawing.Point(327, 300);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(124, 23);
            this.lblCheckin.TabIndex = 0;
            this.lblCheckin.Text = "Reservation";
            // 
            // txt_IDproof
            // 
            this.txt_IDproof.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IDproof.DefaultText = "";
            this.txt_IDproof.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IDproof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IDproof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDproof.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDproof.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDproof.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_IDproof.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_IDproof.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDproof.Location = new System.Drawing.Point(331, 93);
            this.txt_IDproof.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_IDproof.Name = "txt_IDproof";
            this.txt_IDproof.PasswordChar = '\0';
            this.txt_IDproof.PlaceholderText = "Enter ID";
            this.txt_IDproof.SelectedText = "";
            this.txt_IDproof.Size = new System.Drawing.Size(252, 32);
            this.txt_IDproof.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_IDproof.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(329, 168);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Complate Address";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(264, 111);
            this.txtAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddress.TabIndex = 6;
            this.txtAddress.WordWrap = false;
            // 
            // cmbReservation
            // 
            this.cmbReservation.Checked = true;
            this.cmbReservation.CustomFormat = "dd-MM-yyyy  hh:mm-tt";
            this.cmbReservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbReservation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbReservation.Location = new System.Drawing.Point(331, 327);
            this.cmbReservation.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.cmbReservation.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.cmbReservation.Name = "cmbReservation";
            this.cmbReservation.Size = new System.Drawing.Size(262, 32);
            this.cmbReservation.TabIndex = 7;
            this.cmbReservation.Value = new System.DateTime(2023, 3, 19, 22, 29, 28, 790);
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBed.Location = new System.Drawing.Point(644, 63);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(48, 23);
            this.lblBed.TabIndex = 0;
            this.lblBed.Text = "Bed";
            // 
            // cmbBed
            // 
            this.cmbBed.BackColor = System.Drawing.Color.Transparent;
            this.cmbBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbBed.ItemHeight = 30;
            this.cmbBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Twin"});
            this.cmbBed.Location = new System.Drawing.Point(648, 93);
            this.cmbBed.Name = "cmbBed";
            this.cmbBed.Size = new System.Drawing.Size(252, 36);
            this.cmbBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbBed.TabIndex = 8;
            this.cmbBed.SelectedIndexChanged += new System.EventHandler(this.cmbBed_SelectedIndexChanged);
            // 
            // lblRoomtype
            // 
            this.lblRoomtype.AutoSize = true;
            this.lblRoomtype.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomtype.Location = new System.Drawing.Point(644, 142);
            this.lblRoomtype.Name = "lblRoomtype";
            this.lblRoomtype.Size = new System.Drawing.Size(119, 23);
            this.lblRoomtype.TabIndex = 0;
            this.lblRoomtype.Text = "Room Type";
            // 
            // cmbRoomno
            // 
            this.cmbRoomno.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoomno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoomno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomno.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomno.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbRoomno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbRoomno.ItemHeight = 30;
            this.cmbRoomno.Location = new System.Drawing.Point(648, 243);
            this.cmbRoomno.Name = "cmbRoomno";
            this.cmbRoomno.Size = new System.Drawing.Size(252, 36);
            this.cmbRoomno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbRoomno.TabIndex = 10;
            this.cmbRoomno.SelectedIndexChanged += new System.EventHandler(this.cmbRoomno_SelectedIndexChanged);
            // 
            // lblRoomno
            // 
            this.lblRoomno.AutoSize = true;
            this.lblRoomno.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomno.Location = new System.Drawing.Point(644, 213);
            this.lblRoomno.Name = "lblRoomno";
            this.lblRoomno.Size = new System.Drawing.Size(101, 23);
            this.lblRoomno.TabIndex = 0;
            this.lblRoomno.Text = "Room No";
            // 
            // cmbRoomtype
            // 
            this.cmbRoomtype.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoomtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomtype.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbRoomtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbRoomtype.ItemHeight = 30;
            this.cmbRoomtype.Items.AddRange(new object[] {
            "Ac",
            "Non-Ac"});
            this.cmbRoomtype.Location = new System.Drawing.Point(648, 171);
            this.cmbRoomtype.Name = "cmbRoomtype";
            this.cmbRoomtype.Size = new System.Drawing.Size(252, 36);
            this.cmbRoomtype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbRoomtype.TabIndex = 9;
            this.cmbRoomtype.SelectedIndexChanged += new System.EventHandler(this.cmbRoomtype_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(644, 301);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 23);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.Enabled = false;
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(648, 331);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Enter Price";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(252, 32);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 11;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // btReserve
            // 
            this.btReserve.BorderRadius = 22;
            this.btReserve.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btReserve.BorderThickness = 1;
            this.btReserve.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btReserve.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btReserve.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReserve.DisabledState.FillColor = System.Drawing.Color.White;
            this.btReserve.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btReserve.FillColor = System.Drawing.Color.White;
            this.btReserve.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReserve.ForeColor = System.Drawing.Color.Black;
            this.btReserve.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btReserve.HoverState.ForeColor = System.Drawing.Color.White;
            this.btReserve.Location = new System.Drawing.Point(648, 404);
            this.btReserve.Name = "btReserve";
            this.btReserve.Size = new System.Drawing.Size(252, 45);
            this.btReserve.TabIndex = 12;
            this.btReserve.Text = "Reserve Room";
            this.btReserve.Click += new System.EventHandler(this.btReserve_Click);
            // 
            // ElipseRegistration
            // 
            this.ElipseRegistration.TargetControl = this;
            // 
            // Uc_CostomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btReserve);
            this.Controls.Add(this.cmbReservation);
            this.Controls.Add(this.cmbRoomtype);
            this.Controls.Add(this.cmbRoomno);
            this.Controls.Add(this.cmbBed);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.lblRoomno);
            this.Controls.Add(this.txt_IDproof);
            this.Controls.Add(this.lblRoomtype);
            this.Controls.Add(this.txtMobileno);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCheckin);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lbl_IDproof);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMobileno);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblCustomerRegistration);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Uc_CostomerRegistration";
            this.Size = new System.Drawing.Size(928, 470);
            this.Load += new System.EventHandler(this.Uc_CostomerRegistration_Load);
            this.Leave += new System.EventHandler(this.Uc_CostomerRegistration_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerRegistration;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblMobileno;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtMobileno;
        private Guna.UI2.WinForms.Guna2TextBox txtNationality;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGender;
        private System.Windows.Forms.Label lbl_IDproof;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCheckin;
        private Guna.UI2.WinForms.Guna2TextBox txt_IDproof;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2DateTimePicker cmbReservation;
        private System.Windows.Forms.Label lblBed;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBed;
        private System.Windows.Forms.Label lblRoomtype;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRoomno;
        private System.Windows.Forms.Label lblRoomno;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRoomtype;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Button btReserve;
        private Guna.UI2.WinForms.Guna2Elipse ElipseRegistration;
    }
}
