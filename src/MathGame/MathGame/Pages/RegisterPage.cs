using MathGame.Constants;
using MathGame.Interfaces.Services;
using MathGame.Models;
using MathGame.Services;
using MathGame.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame.Pages
{
    public partial class RegisterPage : Form
    {
        private readonly string _dbPath = DbConstants.PLAYER_DB;
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            IPlayerService playerService = new PlayerService();

            if(TxFirstname.Text == "" || TxLastname.Text == "" || TxAge.Text == "" ||
                TxUsername.Text == "" || TxPassword.Text == "")
            {
                LbErrorMessage.Text = "Some text box is empty!";
            }
            else if (UsernameTrue(TxUsername.Text))
            {
                TxUsername.Text = "";
                TxUsername.HintText = "This username is already occupied!";
            }
            else if (PasswordTrue(TxPassword.Text))
            {
                PasswordError.Text = "Password must be at least 8 characters long.\nPassword must contain at least 3 of the following:\nlowercase, uppercase, alphabetic, numeric, special symbols.";
            }
            else
            {
                var playerCreateViewModel = new PlayerCreateViewModel()
                {
                    FirstName = TxFirstname.Text,
                    LastName = TxLastname.Text,
                    Age = int.Parse(TxAge.Text),
                    Username = TxUsername.Text,
                    Password = TxPassword.Text
                };

                var result = await playerService.RegisterAsync(playerCreateViewModel);
                if (result == true)
                {
                    this.Hide();
                    LoginPage Lp = new LoginPage();
                    Lp.ShowDialog();
                }
                else
                {
                    LbError.Text = "Error waiting";
                }
            }
        }


        private void RegisterPage_Load(object sender, EventArgs e)
        {
            TxPassword.PasswordChar = '*';
        }

        private void LbLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage Lp = new LoginPage();
            Lp.ShowDialog();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private bool UsernameTrue(string username)
        {
            try
            {
                var json = File.ReadAllText(_dbPath);
                var Players = JsonConvert.DeserializeObject<List<Player>>(json);

                foreach (var player in Players)
                {
                    if (player.Username == username)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch { return false; }
        }

        private bool PasswordTrue(string password)
        {
            bool intCount = false;
            bool LowerCount = false;
            bool UpperCount = false;
            bool symbolCount = false;
            int TrueCount = 0;

            if (password.Length < 8)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsDigit(password[i]))
                    {
                        intCount = true;
                    }
                    else if (Char.IsLower(password[i]))
                    {
                        LowerCount = true;
                    }
                    else if (Char.IsUpper(password[i]))
                    {
                        UpperCount = true;
                    }
                    else if (Char.IsSymbol(password[i]))
                    {
                        symbolCount = true;
                    }
                }
                if (intCount)
                {
                    TrueCount++;
                }
                if (LowerCount)
                {
                    TrueCount++;
                }
                if (UpperCount)
                {
                    TrueCount++;
                }
                if (symbolCount)
                {
                    TrueCount++;
                }

                if (TrueCount < 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        private void TxFirstname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnPasswordChar_Click(object sender, EventArgs e)
        {
            if (TxPassword.PasswordChar == '*')
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
