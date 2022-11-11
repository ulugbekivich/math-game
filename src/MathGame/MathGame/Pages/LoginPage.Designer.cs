namespace MathGame.Pages
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.TxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LbIsIncorrect = new System.Windows.Forms.Label();
            this.LbIncorrect = new System.Windows.Forms.Label();
            this.LbLinkRegister = new System.Windows.Forms.LinkLabel();
            this.BtnExit = new XanderUI.XUIButton();
            this.BtnPasswordChar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.Color.DarkTurquoise;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(22, 260);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(240, 35);
            this.BtnLogin.TabIndex = 13;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
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
            this.TxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxPassword.IconLeft")));
            this.TxPassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.TxPassword.Location = new System.Drawing.Point(22, 193);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.PasswordChar = '\0';
            this.TxPassword.PlaceholderText = "Password";
            this.TxPassword.SelectedText = "";
            this.TxPassword.Size = new System.Drawing.Size(200, 35);
            this.TxPassword.TabIndex = 12;
            // 
            // TxUsername
            // 
            this.TxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxUsername.DefaultText = "";
            this.TxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxUsername.IconLeft")));
            this.TxUsername.IconLeftSize = new System.Drawing.Size(25, 25);
            this.TxUsername.Location = new System.Drawing.Point(22, 138);
            this.TxUsername.Name = "TxUsername";
            this.TxUsername.PasswordChar = '\0';
            this.TxUsername.PlaceholderText = "Username";
            this.TxUsername.SelectedText = "";
            this.TxUsername.Size = new System.Drawing.Size(240, 35);
            this.TxUsername.TabIndex = 11;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LbIsIncorrect
            // 
            this.LbIsIncorrect.AutoSize = true;
            this.LbIsIncorrect.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIsIncorrect.ForeColor = System.Drawing.Color.Red;
            this.LbIsIncorrect.Location = new System.Drawing.Point(46, 110);
            this.LbIsIncorrect.Name = "LbIsIncorrect";
            this.LbIsIncorrect.Size = new System.Drawing.Size(0, 15);
            this.LbIsIncorrect.TabIndex = 16;
            // 
            // LbIncorrect
            // 
            this.LbIncorrect.AutoSize = true;
            this.LbIncorrect.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIncorrect.ForeColor = System.Drawing.Color.Red;
            this.LbIncorrect.Location = new System.Drawing.Point(52, 97);
            this.LbIncorrect.Name = "LbIncorrect";
            this.LbIncorrect.Size = new System.Drawing.Size(0, 15);
            this.LbIncorrect.TabIndex = 17;
            this.LbIncorrect.Click += new System.EventHandler(this.LbIncorrect_Click);
            // 
            // LbLinkRegister
            // 
            this.LbLinkRegister.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.LbLinkRegister.AutoSize = true;
            this.LbLinkRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLinkRegister.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.LbLinkRegister.Location = new System.Drawing.Point(64, 358);
            this.LbLinkRegister.Name = "LbLinkRegister";
            this.LbLinkRegister.Size = new System.Drawing.Size(150, 17);
            this.LbLinkRegister.TabIndex = 18;
            this.LbLinkRegister.TabStop = true;
            this.LbLinkRegister.Text = "Don\'t have an account?";
            this.LbLinkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbLinkRegister_LinkClicked);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundColor = System.Drawing.Color.White;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExit.ButtonImage = null;
            this.BtnExit.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.BtnExit.ButtonText = "x";
            this.BtnExit.ClickBackColor = System.Drawing.Color.Black;
            this.BtnExit.ClickTextColor = System.Drawing.Color.Black;
            this.BtnExit.CornerRadius = 0;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnExit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnExit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnExit.HoverTextColor = System.Drawing.Color.White;
            this.BtnExit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnExit.Location = new System.Drawing.Point(251, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnExit.Click += new System.EventHandler(this.BtExit_Click);
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
            this.BtnPasswordChar.Location = new System.Drawing.Point(227, 193);
            this.BtnPasswordChar.Name = "BtnPasswordChar";
            this.BtnPasswordChar.Size = new System.Drawing.Size(35, 35);
            this.BtnPasswordChar.TabIndex = 19;
            this.BtnPasswordChar.Click += new System.EventHandler(this.BtnPasswordChar_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.BtnPasswordChar);
            this.Controls.Add(this.LbLinkRegister);
            this.Controls.Add(this.LbIncorrect);
            this.Controls.Add(this.LbIsIncorrect);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxPassword);
            this.Controls.Add(this.TxUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Guna.UI2.WinForms.Guna2TextBox TxPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxUsername;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label LbIsIncorrect;
        private System.Windows.Forms.Label LbIncorrect;
        private System.Windows.Forms.LinkLabel LbLinkRegister;
        private XanderUI.XUIButton BtnExit;
        private Guna.UI2.WinForms.Guna2Button BtnPasswordChar;
    }
}