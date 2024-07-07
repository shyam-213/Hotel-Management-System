namespace Hotel_Management_System.User_Control
{
    partial class Uc_CostomerCheckInOut
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
            this.lblCheckInOut = new System.Windows.Forms.Label();
            this.ElipseCheckOut = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataGV_Checkout = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.txtRoomno = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_Checkout = new System.Windows.Forms.Label();
            this.btCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.btCheckin = new Guna.UI2.WinForms.Guna2Button();
            this.btCheckOut = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Checkout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCheckInOut
            // 
            this.lblCheckInOut.AutoSize = true;
            this.lblCheckInOut.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInOut.Location = new System.Drawing.Point(5, 8);
            this.lblCheckInOut.Name = "lblCheckInOut";
            this.lblCheckInOut.Size = new System.Drawing.Size(402, 39);
            this.lblCheckInOut.TabIndex = 0;
            this.lblCheckInOut.Text = "Customer Check In - Out";
            // 
            // ElipseCheckOut
            // 
            this.ElipseCheckOut.TargetControl = this;
            // 
            // dataGV_Checkout
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGV_Checkout.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV_Checkout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGV_Checkout.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV_Checkout.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV_Checkout.ColumnHeadersHeight = 25;
            this.dataGV_Checkout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV_Checkout.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGV_Checkout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGV_Checkout.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGV_Checkout.Location = new System.Drawing.Point(3, 103);
            this.dataGV_Checkout.Name = "dataGV_Checkout";
            this.dataGV_Checkout.ReadOnly = true;
            this.dataGV_Checkout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV_Checkout.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGV_Checkout.RowHeadersVisible = false;
            this.dataGV_Checkout.RowHeadersWidth = 70;
            this.dataGV_Checkout.RowTemplate.Height = 25;
            this.dataGV_Checkout.Size = new System.Drawing.Size(912, 198);
            this.dataGV_Checkout.TabIndex = 0;
            this.dataGV_Checkout.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Checkout.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGV_Checkout.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGV_Checkout.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGV_Checkout.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGV_Checkout.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Checkout.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGV_Checkout.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGV_Checkout.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGV_Checkout.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGV_Checkout.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGV_Checkout.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGV_Checkout.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGV_Checkout.ThemeStyle.ReadOnly = true;
            this.dataGV_Checkout.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Checkout.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGV_Checkout.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGV_Checkout.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGV_Checkout.ThemeStyle.RowsStyle.Height = 25;
            this.dataGV_Checkout.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGV_Checkout.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGV_Checkout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Checkout_CellContentClick);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(10, 387);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(101, 23);
            this.lblRoomNo.TabIndex = 0;
            this.lblRoomNo.Text = "Room No";
            // 
            // txtRoomno
            // 
            this.txtRoomno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomno.DefaultText = "";
            this.txtRoomno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomno.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtRoomno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomno.Location = new System.Drawing.Point(14, 417);
            this.txtRoomno.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtRoomno.Name = "txtRoomno";
            this.txtRoomno.PasswordChar = '\0';
            this.txtRoomno.PlaceholderText = "Enter Room No";
            this.txtRoomno.ReadOnly = true;
            this.txtRoomno.SelectedText = "";
            this.txtRoomno.Size = new System.Drawing.Size(188, 32);
            this.txtRoomno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomno.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 319);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtCName
            // 
            this.txtCName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCName.DefaultText = "";
            this.txtCName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCName.Location = new System.Drawing.Point(14, 349);
            this.txtCName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCName.Name = "txtCName";
            this.txtCName.PasswordChar = '\0';
            this.txtCName.PlaceholderText = "Enter Full Name";
            this.txtCName.ReadOnly = true;
            this.txtCName.SelectedText = "";
            this.txtCName.Size = new System.Drawing.Size(188, 32);
            this.txtCName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCName.TabIndex = 2;
            // 
            // cmbDateTime
            // 
            this.cmbDateTime.Checked = true;
            this.cmbDateTime.CustomFormat = "dd-MM-yyyy  hh:mm-tt";
            this.cmbDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbDateTime.Location = new System.Drawing.Point(357, 349);
            this.cmbDateTime.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.cmbDateTime.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.cmbDateTime.Name = "cmbDateTime";
            this.cmbDateTime.Size = new System.Drawing.Size(289, 32);
            this.cmbDateTime.TabIndex = 4;
            this.cmbDateTime.Value = new System.DateTime(2023, 3, 19, 22, 29, 28, 790);
            // 
            // lbl_Checkout
            // 
            this.lbl_Checkout.AutoSize = true;
            this.lbl_Checkout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Checkout.Location = new System.Drawing.Point(530, 319);
            this.lbl_Checkout.Name = "lbl_Checkout";
            this.lbl_Checkout.Size = new System.Drawing.Size(116, 23);
            this.lbl_Checkout.TabIndex = 0;
            this.lbl_Checkout.Text = "Check Out";
            // 
            // btCancel
            // 
            this.btCancel.BorderRadius = 22;
            this.btCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btCancel.BorderThickness = 1;
            this.btCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btCancel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btCancel.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DisabledState.FillColor = System.Drawing.Color.White;
            this.btCancel.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btCancel.FillColor = System.Drawing.Color.White;
            this.btCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.Black;
            this.btCancel.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btCancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(726, 404);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(183, 45);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancellation";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
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
            this.txtName.Location = new System.Drawing.Point(589, 61);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Full Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(188, 32);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckin.Location = new System.Drawing.Point(353, 319);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(97, 23);
            this.lblCheckin.TabIndex = 0;
            this.lblCheckin.Text = "Check In";
            // 
            // btCheckin
            // 
            this.btCheckin.BorderRadius = 22;
            this.btCheckin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btCheckin.BorderThickness = 1;
            this.btCheckin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btCheckin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btCheckin.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btCheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCheckin.DisabledState.FillColor = System.Drawing.Color.White;
            this.btCheckin.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btCheckin.FillColor = System.Drawing.Color.White;
            this.btCheckin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckin.ForeColor = System.Drawing.Color.Black;
            this.btCheckin.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btCheckin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btCheckin.Location = new System.Drawing.Point(357, 404);
            this.btCheckin.Name = "btCheckin";
            this.btCheckin.Size = new System.Drawing.Size(172, 45);
            this.btCheckin.TabIndex = 5;
            this.btCheckin.Text = "Check In";
            this.btCheckin.Click += new System.EventHandler(this.btCheckin_Click);
            // 
            // btCheckOut
            // 
            this.btCheckOut.BorderRadius = 22;
            this.btCheckOut.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btCheckOut.BorderThickness = 1;
            this.btCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btCheckOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btCheckOut.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCheckOut.DisabledState.FillColor = System.Drawing.Color.White;
            this.btCheckOut.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btCheckOut.FillColor = System.Drawing.Color.White;
            this.btCheckOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btCheckOut.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btCheckOut.HoverState.ForeColor = System.Drawing.Color.White;
            this.btCheckOut.Location = new System.Drawing.Point(541, 404);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(172, 45);
            this.btCheckOut.TabIndex = 5;
            this.btCheckOut.Text = "Check Out";
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click);
            // 
            // Uc_CostomerCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btCheckin);
            this.Controls.Add(this.btCheckOut);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lblCheckin);
            this.Controls.Add(this.cmbDateTime);
            this.Controls.Add(this.lbl_Checkout);
            this.Controls.Add(this.dataGV_Checkout);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRoomno);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.lblCheckInOut);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Uc_CostomerCheckInOut";
            this.Size = new System.Drawing.Size(928, 470);
            this.Load += new System.EventHandler(this.Uc_CostomerCheckOut_Load);
            this.Leave += new System.EventHandler(this.Uc_CostomerCheckOut_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Checkout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckInOut;
        private Guna.UI2.WinForms.Guna2Elipse ElipseCheckOut;
        private Guna.UI2.WinForms.Guna2DataGridView dataGV_Checkout;
        private Guna.UI2.WinForms.Guna2TextBox txtCName;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomno;
        private System.Windows.Forms.Label lblRoomNo;
        private Guna.UI2.WinForms.Guna2DateTimePicker cmbDateTime;
        private System.Windows.Forms.Label lbl_Checkout;
        private Guna.UI2.WinForms.Guna2Button btCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btCheckin;
        private System.Windows.Forms.Label lblCheckin;
        private Guna.UI2.WinForms.Guna2Button btCheckOut;
    }
}
