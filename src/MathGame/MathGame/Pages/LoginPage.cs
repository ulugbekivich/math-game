using MathGame.Interfaces.Services;
using MathGame.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame.Pages
{
    public partial class LoginPage : Form
    {
        GameService gameService = new GameService();
        public LoginPage()
        {
            InitializeComponent();
        }

        public object MainPge { get; private set; }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            IPlayerService playerService = new PlayerService();
            string username = TxUsername.Text;
            string password = TxPassword.Text;

            var player = await playerService.LoginAsync(username, password);

            if(player is null)
            {
                LbIncorrect.Text = "Username or Password is incorrect!";
            }
            else
            {
                gameService.GetId(player.Id);
                this.Hide();
                MainPage Mp = new MainPage();
                Mp.ShowDialog();
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LbIncorrect_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            TxPassword.PasswordChar = '*';
        }

        private void LbLinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterPage Rp = new RegisterPage();
            Rp.ShowDialog();
        }

        private void BtnPasswordChar_Click(object sender, EventArgs e)
        {
            if(TxPassword.PasswordChar == '*')
            {
                TxPassword.PasswordChar = '\0';
            }
            else
            {
                TxPassword.PasswordChar = '*';
            }
        }
    }
}
