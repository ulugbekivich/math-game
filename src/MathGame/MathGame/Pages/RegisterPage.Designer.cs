namespace MathGame.Pages
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TxFirstname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxLastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.LbError = new System.Windows.Forms.Label();
            this.LbLinkLogin = new System.Windows.Forms.LinkLabel();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.PasswordError = new System.Windows.Forms.Label();
            this.BtnPasswordChar = new Guna.UI2.WinForms.Guna2Button();
            this.TxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.LbErrorMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TxFirstname
            // 
            this.TxFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxFirstname.HintForeColor = System.Drawing.Color.Gray;
            this.TxFirstname.HintText = "Firstname";
            this.TxFirstname.isPassword = false;
            this.TxFirstname.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxFirstname.LineIdleColor = System.Drawing.Color.Gray;
            this.TxFirstname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxFirstname.LineThickness = 3;
            this.TxFirstname.Location = new System.Drawing.Point(30, 103);
            this.TxFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.TxFirstname.Name = "TxFirstname";
            this.TxFirstname.Size = new System.Drawing.Size(240, 30);
            this.TxFirstname.TabIndex = 1;
            this.TxFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxFirstname.OnValueChanged += new System.EventHandler(this.TxFirstname_OnValueChanged);
            // 
            // TxLastname
            // 
            this.TxLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxLastname.HintForeColor = System.Drawing.Color.Gray;
            this.TxLastname.HintText = "Lastname";
            this.TxLastname.isPassword = false;
            this.TxLastname.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxLastname.LineIdleColor = System.Drawing.Color.Gray;
            this.TxLastname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxLastname.LineThickness = 3;
            this.TxLastname.Location = new System.Drawing.Point(30, 141);
            this.TxLastname.Margin = new System.Windows.Forms.Padding(4);
            this.TxLastname.Name = "TxLastname";
            this.TxLastname.Size = new System.Drawing.Size(240, 30);
            this.TxLastname.TabIndex = 2;
            this.TxLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxAge
            // 
            this.TxAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxAge.HintForeColor = System.Drawing.Color.Gray;
            this.TxAge.HintText = "Age";
            this.TxAge.isPassword = false;
            this.TxAge.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxAge.LineIdleColor = System.Drawing.Color.Gray;
            this.TxAge.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxAge.LineThickness = 3;
            this.TxAge.Location = new System.Drawing.Point(30, 179);
            this.TxAge.Margin = new System.Windows.Forms.Padding(4);
            this.TxAge.Name = "TxAge";
            this.TxAge.Size = new System.Drawing.Size(240, 30);
            this.TxAge.TabIndex = 3;
            this.TxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxUsername
            // 
            this.TxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxUsername.HintForeColor = System.Drawing.Color.Gray;
            this.TxUsername.HintText = "Username";
            this.TxUsername.isPassword = false;
            this.TxUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.TxUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxUsername.LineThickness = 3;
            this.TxUsername.Location = new System.Drawing.Point(30, 217);
            this.TxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TxUsername.Name = "TxUsername";
            this.TxUsername.Size = new System.Drawing.Size(240, 30);
            this.TxUsername.TabIndex = 4;
            this.TxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnRegister
            // 
            this.BtnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRegister.FillColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(30, 315);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(240, 30);
            this.BtnRegister.TabIndex = 7;
            this.BtnRegister.Text = "SUBMIT";
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.BackColor = System.Drawing.Color.Transparent;
            this.LbError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbError.ForeColor = System.Drawing.Color.Red;
            this.LbError.Location = new System.Drawing.Point(68, 265);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(0, 15);
            this.LbError.TabIndex = 9;
            // 
            // LbLinkLogin
            // 
            this.LbLinkLogin.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.LbLinkLogin.AutoSize = true;
            this.LbLinkLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLinkLogin.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.LbLinkLogin.Location = new System.Drawing.Point(63, 405);
            this.LbLinkLogin.Name = "LbLinkLogin";
            this.LbLinkLogin.Size = new System.Drawing.Size(164, 17);
            this.LbLinkLogin.TabIndex = 10;
            this.LbLinkLogin.TabStop = true;
            this.LbLinkLogin.Text = "Have already an account?";
            this.LbLinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbLinkLogin_LinkClicked);
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.xuiButton1.ButtonText = "x";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.Black;
            this.xuiButton1.ClickTextColor = System.Drawing.Color.Black;
            this.xuiButton1.CornerRadius = 0;
            this.xuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(267, 1);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xuiButton1.Size = new System.Drawing.Size(30, 30);
            this.xuiButton1.TabIndex = 17;
            this.xuiButton1.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(6, 48);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(0, 13);
            this.PasswordError.TabIndex = 18;
            // 
            // BtnPasswordChar
            // 
            this.BtnPasswordChar.BorderColor = System.Drawing.Color.Turquoise;
            this.BtnPasswordChar.BorderRadius = 1;
            this.BtnPasswordChar.BorderThickness = 1;
            this.BtnPasswordChar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPasswordChar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPasswordChar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPasswordChar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPasswordChar.FillColor = System.Drawing.Color.White;
            this.BtnPasswordChar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPasswordChar.ForeColor = System.Drawing.Color.White;
            this.BtnPasswordChar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPasswordChar.Image")));
            this.BtnPasswordChar.Location = new System.Drawing.Point(235, 254);
            this.BtnPasswordChar.Name = "BtnPasswordChar";
            this.BtnPasswordChar.Size = new System.Drawing.Size(35, 35);
            this.BtnPasswordChar.TabIndex = 24;
            this.BtnPasswordChar.Click += new System.EventHandler(this.BtnPasswordChar_Click);
            // 
            // TxPassword
            // 
            this.TxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxPassword.DefaultText = "";
            this.TxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxPassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.TxPassword.Location = new System.Drawing.Point(30, 254);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.PasswordChar = '\0';
            this.TxPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxPassword.PlaceholderText = "Password";
            this.TxPassword.SelectedText = "";
            this.TxPassword.Size = new System.Drawing.Size(190, 35);
            this.TxPassword.TabIndex = 23;
            // 
            // LbErrorMessage
            // 
            this.LbErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.LbErrorMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.LbErrorMessage.Location = new System.Drawing.Point(71, 77);
            this.LbErrorMessage.Name = "LbErrorMessage";
            this.LbErrorMessage.Size = new System.Drawing.Size(3, 2);
            this.LbErrorMessage.TabIndex = 25;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.LbErrorMessage);
            this.Controls.Add(this.BtnPasswordChar);
            this.Controls.Add(this.TxPassword);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.LbLinkLogin);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TxUsername);
            this.Controls.Add(this.TxAge);
            this.Controls.Add(this.TxLastname);
            this.Controls.Add(this.TxFirstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPage";
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxFirstname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxAge;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxLastname;
        private Guna.UI2.WinForms.Guna2Button BtnRegister;
        private System.Windows.Forms.Label LbError;
        private System.Windows.Forms.LinkLabel LbLinkLogin;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.Label PasswordError;
        private Guna.UI2.WinForms.Guna2Button BtnPasswordChar;
        private Guna.UI2.WinForms.Guna2TextBox TxPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbErrorMessage;
    }
}