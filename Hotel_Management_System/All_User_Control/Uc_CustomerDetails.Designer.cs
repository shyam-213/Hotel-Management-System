namespace Hotel_Management_System.All_User_Control
{
    partial class Uc_CustomerDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.ElipseCustomerDetails = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cmbSearchby = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.dataGVCustomerDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDetails.Location = new System.Drawing.Point(5, 8);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(277, 39);
            this.lblCustomerDetails.TabIndex = 0;
            this.lblCustomerDetails.Text = "Customer Details";
            // 
            // ElipseCustomerDetails
            // 
            this.ElipseCustomerDetails.BorderRadius = 30;
            this.ElipseCustomerDetails.TargetControl = this;
            // 
            // cmbSearchby
            // 
            this.cmbSearchby.BackColor = System.Drawing.Color.Transparent;
            this.cmbSearchby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearchby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchby.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSearchby.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSearchby.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbSearchby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbSearchby.ItemHeight = 30;
            this.cmbSearchby.Items.AddRange(new object[] {
            "All Customer Details",
            "In Hotel Customers",
            "CheckOut Customers",
            "Canceled Reservation"});
            this.cmbSearchby.Location = new System.Drawing.Point(308, 89);
            this.cmbSearchby.Name = "cmbSearchby";
            this.cmbSearchby.Size = new System.Drawing.Size(286, 36);
            this.cmbSearchby.TabIndex = 1;
            this.cmbSearchby.SelectedIndexChanged += new System.EventHandler(this.cmbSearchby_SelectedIndexChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(304, 60);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(106, 23);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Search By";
            // 
            // dataGVCustomerDetails
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVCustomerDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGVCustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGVCustomerDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVCustomerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGVCustomerDetails.ColumnHeadersHeight = 30;
            this.dataGVCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVCustomerDetails.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGVCustomerDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGVCustomerDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVCustomerDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGVCustomerDetails.Location = new System.Drawing.Point(6, 149);
            this.dataGVCustomerDetails.Margin = new System.Windows.Forms.Padding(10);
            this.dataGVCustomerDetails.Name = "dataGVCustomerDetails";
            this.dataGVCustomerDetails.ReadOnly = true;
            this.dataGVCustomerDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVCustomerDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGVCustomerDetails.RowHeadersVisible = false;
            this.dataGVCustomerDetails.RowHeadersWidth = 70;
            this.dataGVCustomerDetails.RowTemplate.Height = 35;
            this.dataGVCustomerDetails.Size = new System.Drawing.Size(913, 297);
            this.dataGVCustomerDetails.TabIndex = 0;
            this.dataGVCustomerDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGVCustomerDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGVCustomerDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGVCustomerDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGVCustomerDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGVCustomerDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGVCustomerDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVCustomerDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGVCustomerDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGVCustomerDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGVCustomerDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGVCustomerDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGVCustomerDetails.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGVCustomerDetails.ThemeStyle.ReadOnly = true;
            this.dataGVCustomerDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGVCustomerDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGVCustomerDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGVCustomerDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGVCustomerDetails.ThemeStyle.RowsStyle.Height = 35;
            this.dataGVCustomerDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVCustomerDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Uc_CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGVCustomerDetails);
            this.Controls.Add(this.cmbSearchby);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.lblCustomerDetails);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Uc_CustomerDetails";
            this.Size = new System.Drawing.Size(928, 470);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCustomerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerDetails;
        private Guna.UI2.WinForms.Guna2Elipse ElipseCustomerDetails;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearchby;
        private System.Windows.Forms.Label lblSearchBy;
        private Guna.UI2.WinForms.Guna2DataGridView dataGVCustomerDetails;
    }
}
