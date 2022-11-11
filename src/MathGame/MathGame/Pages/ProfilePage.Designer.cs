namespace MathGame.Pages
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LbError = new System.Windows.Forms.Label();
            this.TxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxLastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxFirstname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMainMenu = new Guna.UI2.WinForms.Guna2Button();
            this.BtnExit = new XanderUI.XUIButton();
            this.PasswordError = new System.Windows.Forms.Label();
            this.TxSuccessful = new System.Windows.Forms.Label();
            this.BtnPasswordChar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.BackColor = System.Drawing.Color.Transparent;
            this.LbError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbError.ForeColor = System.Drawing.Color.Red;
            this.LbError.Location = new System.Drawing.Point(76, 125);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(0, 15);
            this.LbError.TabIndex = 14;
            // 
            // TxUsername
            // 
            this.TxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxUsername.HintForeColor = System.Drawing.Color.Gray;
            this.TxUsername.HintText = "";
            this.TxUsername.isPassword = false;
            this.TxUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.TxUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxUsername.LineThickness = 3;
            this.TxUsername.Location = new System.Drawing.Point(29, 224);
            this.TxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TxUsername.Name = "TxUsername";
            this.TxUsername.Size = new System.Drawing.Size(240, 30);
            this.TxUsername.TabIndex = 13;
            this.TxUsername.Text = "Username";
            this.TxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxUsername.OnValueChanged += new System.EventHandler(this.TxUsername_OnValueChanged);
            // 
            // TxAge
            // 
            this.TxAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxAge.HintForeColor = System.Drawing.Color.Gray;
            this.TxAge.HintText = "";
            this.TxAge.isPassword = false;
            this.TxAge.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxAge.LineIdleColor = System.Drawing.Color.Gray;
            this.TxAge.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxAge.LineThickness = 3;
            this.TxAge.Location = new System.Drawing.Point(29, 186);
            this.TxAge.Margin = new System.Windows.Forms.Padding(4);
            this.TxAge.Name = "TxAge";
            this.TxAge.Size = new System.Drawing.Size(240, 30);
            this.TxAge.TabIndex = 12;
            this.TxAge.Text = "Age";
            this.TxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxLastname
            // 
            this.TxLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxLastname.HintForeColor = System.Drawing.Color.Gray;
            this.TxLastname.HintText = "";
            this.TxLastname.isPassword = false;
            this.TxLastname.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxLastname.LineIdleColor = System.Drawing.Color.Gray;
            this.TxLastname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxLastname.LineThickness = 3;
            this.TxLastname.Location = new System.Drawing.Point(29, 148);
            this.TxLastname.Margin = new System.Windows.Forms.Padding(4);
            this.TxLastname.Name = "TxLastname";
            this.TxLastname.Size = new System.Drawing.Size(240, 30);
            this.TxLastname.TabIndex = 11;
            this.TxLastname.Text = "Lastname";
            this.TxLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxFirstname
            // 
            this.TxFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxFirstname.HintForeColor = System.Drawing.Color.Gray;
            this.TxFirstname.HintText = "";
            this.TxFirstname.isPassword = false;
            this.TxFirstname.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxFirstname.LineIdleColor = System.Drawing.Color.Gray;
            this.TxFirstname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxFirstname.LineThickness = 3;
            this.TxFirstname.Location = new System.Drawing.Point(29, 110);
            this.TxFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.TxFirstname.Name = "TxFirstname";
            this.TxFirstname.Size = new System.Drawing.Size(240, 30);
            this.TxFirstname.TabIndex = 10;
            this.TxFirstname.Text = "Firstname";
            this.TxFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxNewPassword
            // 
            this.TxNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxNewPassword.DefaultText = "";
            this.TxNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxNewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxNewPassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.TxNewPassword.Location = new System.Drawing.Point(29, 270);
            this.TxNewPassword.Name = "TxNewPassword";
            this.TxNewPassword.PasswordChar = '\0';
            this.TxNewPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxNewPassword.PlaceholderText = "New Password";
            this.TxNewPassword.SelectedText = "";
            this.TxNewPassword.Size = new System.Drawing.Size(190, 35);
            this.TxNewPassword.TabIndex = 16;
            // 
            // BtnSave
            // 
            this.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSave.FillColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(29, 345);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(240, 35);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save Changes";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMainMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMainMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMainMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMainMenu.FillColor = System.Drawing.Color.DarkTurquoise;
            this.BtnMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMainMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMainMenu.Location = new System.Drawing.Point(29, 386);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(240, 35);
            this.BtnMainMenu.TabIndex = 18;
            this.BtnMainMenu.Text = "Main Menu";
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
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
            this.BtnExit.Location = new System.Drawing.Point(267, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 19;
            this.BtnExit.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(6, 45);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(0, 13);
            this.PasswordError.TabIndex = 20;
            // 
            // TxSuccessful
            // 
            this.TxSuccessful.AutoSize = true;
            this.TxSuccessful.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSuccessful.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxSuccessful.Location = new System.Drawing.Point(90, 67);
            this.TxSuccessful.Name = "TxSuccessful";
            this.TxSuccessful.Size = new System.Drawing.Size(0, 25);
            this.TxSuccessful.TabIndex = 21;
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
            this.BtnPasswordChar.Location = new System.Drawing.Point(234, 270);
            this.BtnPasswordChar.Name = "BtnPasswordChar";
            this.BtnPasswordChar.Size = new System.Drawing.Size(35, 35);
            this.BtnPasswordChar.TabIndex = 22;
            this.BtnPasswordChar.Click += new System.EventHandler(this.BtnPasswordChar_Click);
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.BtnPasswordChar);
            this.Controls.Add(this.TxSuccessful);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxNewPassword);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.TxUsername);
            this.Controls.Add(this.TxAge);
            this.Controls.Add(this.TxLastname);
            this.Controls.Add(this.TxFirstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfilePage";
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label LbError;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxAge;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxLastname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxFirstname;
        private Guna.UI2.WinForms.Guna2TextBox TxNewPassword;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2Button BtnMainMenu;
        private XanderUI.XUIButton BtnExit;
        private System.Windows.Forms.Label PasswordError;
        private System.Windows.Forms.Label TxSuccessful;
        private Guna.UI2.WinForms.Guna2Button BtnPasswordChar;
    }
}