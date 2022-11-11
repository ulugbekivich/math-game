namespace MathGame.Pages
{
    partial class GamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PnlAnswers = new System.Windows.Forms.Panel();
            this.BtnAnswer3 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAnswer2 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAnswer1 = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbQuestion = new System.Windows.Forms.Label();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BtnClock = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PnScore = new System.Windows.Forms.Panel();
            this.LbScore = new System.Windows.Forms.Label();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BtnExit = new XanderUI.XUIButton();
            this.BtnBack = new XanderUI.XUIButton();
            this.PnlAnswers.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PnlAnswers
            // 
            this.PnlAnswers.BackColor = System.Drawing.Color.LimeGreen;
            this.PnlAnswers.Controls.Add(this.BtnAnswer3);
            this.PnlAnswers.Controls.Add(this.BtnAnswer2);
            this.PnlAnswers.Controls.Add(this.BtnAnswer1);
            this.PnlAnswers.Location = new System.Drawing.Point(53, 294);
            this.PnlAnswers.Name = "PnlAnswers";
            this.PnlAnswers.Size = new System.Drawing.Size(200, 150);
            this.PnlAnswers.TabIndex = 0;
            // 
            // BtnAnswer3
            // 
            this.BtnAnswer3.BackColor = System.Drawing.Color.Transparent;
            this.BtnAnswer3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAnswer3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAnswer3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAnswer3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAnswer3.FillColor = System.Drawing.Color.Aquamarine;
            this.BtnAnswer3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnswer3.ForeColor = System.Drawing.Color.Black;
            this.BtnAnswer3.Location = new System.Drawing.Point(15, 99);
            this.BtnAnswer3.Name = "BtnAnswer3";
            this.BtnAnswer3.Size = new System.Drawing.Size(170, 35);
            this.BtnAnswer3.TabIndex = 2;
            this.BtnAnswer3.Text = "3";
            this.BtnAnswer3.Click += new System.EventHandler(this.BtnAnswer3_Click);
            // 
            // BtnAnswer2
            // 
            this.BtnAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.BtnAnswer2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAnswer2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAnswer2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAnswer2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAnswer2.FillColor = System.Drawing.Color.Aquamarine;
            this.BtnAnswer2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnswer2.ForeColor = System.Drawing.Color.Black;
            this.BtnAnswer2.Location = new System.Drawing.Point(15, 58);
            this.BtnAnswer2.Name = "BtnAnswer2";
            this.BtnAnswer2.Size = new System.Drawing.Size(170, 35);
            this.BtnAnswer2.TabIndex = 1;
            this.BtnAnswer2.Text = "2";
            this.BtnAnswer2.Click += new System.EventHandler(this.BtnAnswer2_Click);
            // 
            // BtnAnswer1
            // 
            this.BtnAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.BtnAnswer1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAnswer1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAnswer1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAnswer1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAnswer1.FillColor = System.Drawing.Color.Aquamarine;
            this.BtnAnswer1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnswer1.ForeColor = System.Drawing.Color.Black;
            this.BtnAnswer1.Location = new System.Drawing.Point(15, 17);
            this.BtnAnswer1.Name = "BtnAnswer1";
            this.BtnAnswer1.Size = new System.Drawing.Size(170, 35);
            this.BtnAnswer1.TabIndex = 0;
            this.BtnAnswer1.Text = "1";
            this.BtnAnswer1.Click += new System.EventHandler(this.BtnAnswer1_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.PnlAnswers;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.LbQuestion);
            this.panel2.Location = new System.Drawing.Point(53, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 1;
            // 
            // LbQuestion
            // 
            this.LbQuestion.AutoSize = true;
            this.LbQuestion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbQuestion.Location = new System.Drawing.Point(14, 10);
            this.LbQuestion.Name = "LbQuestion";
            this.LbQuestion.Size = new System.Drawing.Size(163, 30);
            this.LbQuestion.TabIndex = 0;
            this.LbQuestion.Text = "   1 + 1 + 1 =  ?";
            this.LbQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.panel2;
            // 
            // BtnClock
            // 
            this.BtnClock.BackColor = System.Drawing.Color.Transparent;
            this.BtnClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClock.BackgroundImage")));
            this.BtnClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClock.BorderThickness = 2;
            this.BtnClock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClock.FillColor = System.Drawing.Color.Transparent;
            this.BtnClock.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClock.ForeColor = System.Drawing.Color.Black;
            this.BtnClock.Location = new System.Drawing.Point(108, 99);
            this.BtnClock.Name = "BtnClock";
            this.BtnClock.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnClock.Size = new System.Drawing.Size(80, 80);
            this.BtnClock.TabIndex = 2;
            this.BtnClock.Click += new System.EventHandler(this.BtnClock_Click);
            // 
            // PnScore
            // 
            this.PnScore.BackColor = System.Drawing.Color.Turquoise;
            this.PnScore.Controls.Add(this.LbScore);
            this.PnScore.Location = new System.Drawing.Point(108, 37);
            this.PnScore.Name = "PnScore";
            this.PnScore.Size = new System.Drawing.Size(80, 30);
            this.PnScore.TabIndex = 2;
            // 
            // LbScore
            // 
            this.LbScore.AutoSize = true;
            this.LbScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbScore.Location = new System.Drawing.Point(22, 0);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(31, 30);
            this.LbScore.TabIndex = 2;
            this.LbScore.Text = " 0";
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this.PnScore;
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
            this.BtnExit.Location = new System.Drawing.Point(268, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 17;
            this.BtnExit.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackgroundColor = System.Drawing.Color.White;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBack.ButtonImage = null;
            this.BtnBack.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.BtnBack.ButtonText = "<<";
            this.BtnBack.ClickBackColor = System.Drawing.Color.Black;
            this.BtnBack.ClickTextColor = System.Drawing.Color.Black;
            this.BtnBack.CornerRadius = 0;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBack.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnBack.HoverTextColor = System.Drawing.Color.White;
            this.BtnBack.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnBack.Location = new System.Drawing.Point(2, 1);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnBack.Size = new System.Drawing.Size(30, 30);
            this.BtnBack.TabIndex = 18;
            this.BtnBack.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.PnScore);
            this.Controls.Add(this.BtnClock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlAnswers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePage";
            this.Load += new System.EventHandler(this.GamePage_Load);
            this.PnlAnswers.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnScore.ResumeLayout(false);
            this.PnScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PnlAnswers;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Guna.UI2.WinForms.Guna2CircleButton BtnClock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbQuestion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Guna.UI2.WinForms.Guna2Button BtnAnswer3;
        private Guna.UI2.WinForms.Guna2Button BtnAnswer2;
        private Guna.UI2.WinForms.Guna2Button BtnAnswer1;
        private System.Windows.Forms.Panel PnScore;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Label LbScore;
        private XanderUI.XUIButton BtnExit;
        private XanderUI.XUIButton BtnBack;
    }
}