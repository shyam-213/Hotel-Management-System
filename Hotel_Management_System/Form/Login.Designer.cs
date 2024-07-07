namespace Hotel_Management_System
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblforgotpass = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.btLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btSignup = new Guna.UI2.WinForms.Guna2Button();
            this.panelCopyRight = new System.Windows.Forms.Panel();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.picMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CirclePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.SecurityPictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.panelCopyRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblforgotpass);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picHide);
            this.groupBox1.Controls.Add(this.picShow);
            this.groupBox1.Controls.Add(this.btLogin);
            this.groupBox1.Controls.Add(this.btSignup);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(746, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Login First";
            // 
            // lblforgotpass
            // 
            this.lblforgotpass.AutoSize = true;
            this.lblforgotpass.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgotpass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lblforgotpass.Location = new System.Drawing.Point(26, 203);
            this.lblforgotpass.Name = "lblforgotpass";
            this.lblforgotpass.Size = new System.Drawing.Size(205, 26);
            this.lblforgotpass.TabIndex = 0;
            this.lblforgotpass.TabStop = true;
            this.lblforgotpass.Text = "Forgot Password ?";
            this.lblforgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblforgotpass_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(27, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(328, 42);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(86, 272);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(304, 23);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Invalid Username or Password";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(27, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(358, 42);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username :";
            // 
            // picHide
            // 
            this.picHide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHide.Image = global::Hotel_Management_System.Properties.Resources.hide;
            this.picHide.Location = new System.Drawing.Point(355, 158);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(30, 30);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHide.TabIndex = 3;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click);
            this.picHide.MouseHover += new System.EventHandler(this.picHide_MouseHover);
            // 
            // picShow
            // 
            this.picShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShow.Image = global::Hotel_Management_System.Properties.Resources.show;
            this.picShow.Location = new System.Drawing.Point(355, 158);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(30, 30);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShow.TabIndex = 3;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            this.picShow.MouseHover += new System.EventHandler(this.picShow_MouseHover);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.BorderRadius = 15;
            this.btLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(28, 298);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(357, 45);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Log In";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btSignup
            // 
            this.btSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSignup.BackColor = System.Drawing.Color.Transparent;
            this.btSignup.BorderRadius = 15;
            this.btSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btSignup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignup.ForeColor = System.Drawing.Color.White;
            this.btSignup.Location = new System.Drawing.Point(28, 298);
            this.btSignup.Name = "btSignup";
            this.btSignup.Size = new System.Drawing.Size(357, 45);
            this.btSignup.TabIndex = 4;
            this.btSignup.Text = "Sign Up";
            this.btSignup.Click += new System.EventHandler(this.btSignup_Click);
            // 
            // panelCopyRight
            // 
            this.panelCopyRight.Controls.Add(this.lblCopyRight);
            this.panelCopyRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCopyRight.Location = new System.Drawing.Point(0, 628);
            this.panelCopyRight.Name = "panelCopyRight";
            this.panelCopyRight.Size = new System.Drawing.Size(1278, 50);
            this.panelCopyRight.TabIndex = 0;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.Location = new System.Drawing.Point(13, 14);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(716, 23);
            this.lblCopyRight.TabIndex = 0;
            this.lblCopyRight.Text = "Copyright © 2023. All Rights Reserved by 20BCA072,20BCA087,20BCA098";
            this.lblCopyRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(666, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 390);
            this.panel2.TabIndex = 0;
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::Hotel_Management_System.Properties.Resources.icons8_minimize_window_50;
            this.picMinimize.ImageRotate = 0F;
            this.picMinimize.Location = new System.Drawing.Point(1185, 12);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(40, 40);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimize.TabIndex = 4;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click_1);
            this.picMinimize.MouseHover += new System.EventHandler(this.picMinimize_MouseHover_1);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Hotel_Management_System.Properties.Resources.icons8_close_window_50;
            this.picClose.ImageRotate = 0F;
            this.picClose.Location = new System.Drawing.Point(1226, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(40, 40);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 5;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover_1);
            // 
            // CirclePictureBox
            // 
            this.CirclePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CirclePictureBox.Image = global::Hotel_Management_System.Properties.Resources.circular_loading;
            this.CirclePictureBox.ImageRotate = 0F;
            this.CirclePictureBox.Location = new System.Drawing.Point(277, 217);
            this.CirclePictureBox.Name = "CirclePictureBox";
            this.CirclePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CirclePictureBox.Size = new System.Drawing.Size(235, 247);
            this.CirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CirclePictureBox.TabIndex = 1;
            this.CirclePictureBox.TabStop = false;
            this.CirclePictureBox.UseTransparentBackground = true;
            // 
            // SecurityPictureBox
            // 
            this.SecurityPictureBox.Image = global::Hotel_Management_System.Properties.Resources.login;
            this.SecurityPictureBox.ImageRotate = 0F;
            this.SecurityPictureBox.Location = new System.Drawing.Point(263, 220);
            this.SecurityPictureBox.Name = "SecurityPictureBox";
            this.SecurityPictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SecurityPictureBox.Size = new System.Drawing.Size(264, 255);
            this.SecurityPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SecurityPictureBox.TabIndex = 0;
            this.SecurityPictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 678);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.panelCopyRight);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CirclePictureBox);
            this.Controls.Add(this.SecurityPictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.panelCopyRight.ResumeLayout(false);
            this.panelCopyRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox SecurityPictureBox;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CirclePictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelCopyRight;
        private System.Windows.Forms.Label lblCopyRight;
        private Guna.UI2.WinForms.Guna2PictureBox picMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox picClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.LinkLabel lblforgotpass;
        private Guna.UI2.WinForms.Guna2Button btSignup;
    }
}