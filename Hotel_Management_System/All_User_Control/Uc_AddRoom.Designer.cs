namespace Hotel_Management_System
{
    partial class Uc_AddRoom
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
            this.lblAddroom = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.ElipseAddroom = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataGVAddRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbRoomtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVAddRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddroom
            // 
            this.lblAddroom.AutoSize = true;
            this.lblAddroom.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddroom.Location = new System.Drawing.Point(5, 8);
            this.lblAddroom.Name = "lblAddroom";
            this.lblAddroom.Size = new System.Drawing.Size(184, 39);
            this.lblAddroom.TabIndex = 0;
            this.lblAddroom.Text = "Add Room";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(654, 47);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(151, 23);
            this.lblRoomNo.TabIndex = 0;
            this.lblRoomNo.Text = "Room Number";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(654, 118);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(119, 23);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBed.Location = new System.Drawing.Point(654, 188);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(48, 23);
            this.lblBed.TabIndex = 0;
            this.lblBed.Text = "Bed";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(654, 265);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 23);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // btAddRoom
            // 
            this.btAddRoom.BorderRadius = 22;
            this.btAddRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btAddRoom.BorderThickness = 1;
            this.btAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btAddRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btAddRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddRoom.DisabledState.FillColor = System.Drawing.Color.White;
            this.btAddRoom.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btAddRoom.FillColor = System.Drawing.Color.White;
            this.btAddRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddRoom.ForeColor = System.Drawing.Color.Black;
            this.btAddRoom.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btAddRoom.HoverState.ForeColor = System.Drawing.Color.White;
            this.btAddRoom.Location = new System.Drawing.Point(735, 395);
            this.btAddRoom.Name = "btAddRoom";
            this.btAddRoom.Size = new System.Drawing.Size(180, 45);
            this.btAddRoom.TabIndex = 5;
            this.btAddRoom.Text = "Add Room";
            this.btAddRoom.Click += new System.EventHandler(this.btAddRoom_Click_1);
            // 
            // ElipseAddroom
            // 
            this.ElipseAddroom.TargetControl = this;
            // 
            // dataGVAddRoom
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVAddRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVAddRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVAddRoom.ColumnHeadersHeight = 25;
            this.dataGVAddRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVAddRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVAddRoom.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGVAddRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVAddRoom.Location = new System.Drawing.Point(3, 50);
            this.dataGVAddRoom.Name = "dataGVAddRoom";
            this.dataGVAddRoom.ReadOnly = true;
            this.dataGVAddRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVAddRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGVAddRoom.RowHeadersVisible = false;
            this.dataGVAddRoom.RowHeadersWidth = 70;
            this.dataGVAddRoom.RowTemplate.Height = 25;
            this.dataGVAddRoom.Size = new System.Drawing.Size(593, 403);
            this.dataGVAddRoom.TabIndex = 0;
            this.dataGVAddRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGVAddRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGVAddRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGVAddRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGVAddRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGVAddRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGVAddRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVAddRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGVAddRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGVAddRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGVAddRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGVAddRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGVAddRoom.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGVAddRoom.ThemeStyle.ReadOnly = true;
            this.dataGVAddRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGVAddRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGVAddRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGVAddRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGVAddRoom.ThemeStyle.RowsStyle.Height = 25;
            this.dataGVAddRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVAddRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.cmbRoomtype.Location = new System.Drawing.Point(658, 144);
            this.cmbRoomtype.Name = "cmbRoomtype";
            this.cmbRoomtype.Size = new System.Drawing.Size(257, 36);
            this.cmbRoomtype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbRoomtype.TabIndex = 2;
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
            this.cmbBed.Location = new System.Drawing.Point(658, 214);
            this.cmbBed.Name = "cmbBed";
            this.cmbBed.Size = new System.Drawing.Size(257, 36);
            this.cmbBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbBed.TabIndex = 3;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.DefaultText = "";
            this.txtRoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.Location = new System.Drawing.Point(658, 77);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.PasswordChar = '\0';
            this.txtRoomNo.PlaceholderText = "";
            this.txtRoomNo.SelectedText = "";
            this.txtRoomNo.Size = new System.Drawing.Size(257, 36);
            this.txtRoomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomNo.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(658, 293);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(257, 36);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 4;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress_1);
            // 
            // Uc_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.cmbRoomtype);
            this.Controls.Add(this.cmbBed);
            this.Controls.Add(this.dataGVAddRoom);
            this.Controls.Add(this.btAddRoom);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.lblAddroom);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Uc_AddRoom";
            this.Size = new System.Drawing.Size(928, 470);
            this.Load += new System.EventHandler(this.Uc_AddRoom_Load);
            this.Enter += new System.EventHandler(this.Uc_AddRoom_Enter);
            this.Leave += new System.EventHandler(this.Uc_AddRoom_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVAddRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddroom;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Button btAddRoom;
        private Guna.UI2.WinForms.Guna2Elipse ElipseAddroom;
        private Guna.UI2.WinForms.Guna2DataGridView dataGVAddRoom;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRoomtype;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBed;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
    }
}
