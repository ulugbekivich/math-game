namespace MathGame.Pages
{
    partial class MainPage
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.LbPlayerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BtnStart = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMyRecord = new Guna.UI2.WinForms.Guna2Button();
            this.BtnTopPlayers = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMyProfile = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.xuiButton1);
            this.panel1.Controls.Add(this.LbPlayerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 143);
            this.panel1.TabIndex = 1;
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
            this.xuiButton1.Location = new System.Drawing.Point(250, 3);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xuiButton1.Size = new System.Drawing.Size(30, 30);
            this.xuiButton1.TabIndex = 16;
            this.xuiButton1.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // LbPlayerName
            // 
            this.LbPlayerName.AutoSize = true;
            this.LbPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.LbPlayerName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPlayerName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LbPlayerName.Location = new System.Drawing.Point(17, 85);
            this.LbPlayerName.Name = "LbPlayerName";
            this.LbPlayerName.Size = new System.Drawing.Size(65, 25);
            this.LbPlayerName.TabIndex = 3;
            this.LbPlayerName.Text = "Player";
            this.LbPlayerName.Click += new System.EventHandler(this.LbPlayerName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hello,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "1+2=3";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // BtnStart
            // 
            this.BtnStart.BorderColor = System.Drawing.Color.Transparent;
            this.BtnStart.BorderRadius = 18;
            this.BtnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnStart.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(41, 211);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(200, 40);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "START";
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnMyRecord
            // 
            this.BtnMyRecord.BorderRadius = 18;
            this.BtnMyRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMyRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMyRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMyRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMyRecord.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMyRecord.ForeColor = System.Drawing.Color.White;
            this.BtnMyRecord.Location = new System.Drawing.Point(41, 323);
            this.BtnMyRecord.Name = "BtnMyRecord";
            this.BtnMyRecord.Size = new System.Drawing.Size(200, 40);
            this.BtnMyRecord.TabIndex = 3;
            this.BtnMyRecord.Text = "My Record";
            this.BtnMyRecord.Click += new System.EventHandler(this.BtnMyRecord_Click);
            // 
            // BtnTopPlayers
            // 
            this.BtnTopPlayers.BorderRadius = 18;
            this.BtnTopPlayers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTopPlayers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTopPlayers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTopPlayers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTopPlayers.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTopPlayers.ForeColor = System.Drawing.Color.White;
            this.BtnTopPlayers.Location = new System.Drawing.Point(41, 379);
            this.BtnTopPlayers.Name = "BtnTopPlayers";
            this.BtnTopPlayers.Size = new System.Drawing.Size(200, 40);
            this.BtnTopPlayers.TabIndex = 4;
            this.BtnTopPlayers.Text = "Top Players";
            this.BtnTopPlayers.Click += new System.EventHandler(this.BtnTopPlayers_Click);
            // 
            // BtnMyProfile
            // 
            this.BtnMyProfile.BorderRadius = 18;
            this.BtnMyProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMyProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMyProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMyProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMyProfile.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMyProfile.ForeColor = System.Drawing.Color.White;
            this.BtnMyProfile.Location = new System.Drawing.Point(41, 267);
            this.BtnMyProfile.Name = "BtnMyProfile";
            this.BtnMyProfile.Size = new System.Drawing.Size(200, 40);
            this.BtnMyProfile.TabIndex = 5;
            this.BtnMyProfile.Text = "My Profile";
            this.BtnMyProfile.Click += new System.EventHandler(this.BtnMyProfile_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.BtnMyProfile);
            this.Controls.Add(this.BtnTopPlayers);
            this.Controls.Add(this.BtnMyRecord);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button BtnStart;
        private Guna.UI2.WinForms.Guna2Button BtnTopPlayers;
        private Guna.UI2.WinForms.Guna2Button BtnMyRecord;
        private System.Windows.Forms.Label LbPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButton1;
        private Guna.UI2.WinForms.Guna2Button BtnMyProfile;
        private System.Windows.Forms.Timer timer1;
    }
}