using MathGame.Constants;
using MathGame.Interfaces.Repositories;
using MathGame.Interfaces.Services;
using MathGame.Models;
using MathGame.Repositories;
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
    public partial class ProfilePage : Form
    {
        IPlayerRepository playerRepository = new PlayerRepository();
        private readonly string _dbPath = DbConstants.PLAYER_DB;

        public ProfilePage()
        {
            InitializeComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            var Player = playerRepository.GetById(GameService.PlayerId);
            TxFirstname.Text = Player.FirstName;
            TxLastname.Text = Player.LastName;
            TxAge.Text = Player.Age.ToString();
            TxUsername.Text = Player.Username;

            TxNewPassword.PasswordChar = '*';
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var Player = playerRepository.GetById(GameService.PlayerId);
            var NewPlayer = new PlayerCreateViewModel()
            {
                FirstName = TxFirstname.Text == "" ? Player.FirstName : TxFirstname.Text,
                LastName = TxLastname.Text == "" ? Player.LastName : TxLastname.Text,
                Age = TxAge.Text == "" ? Player.Age : int.Parse(TxAge.Text),
                Username = TxUsername.Text == "" ? Player.Username : UsernameTrue(TxUsername.Text),
                Password = TxNewPassword.Text
            };
            var player = (Player)NewPlayer;
            string salt = Guid.NewGuid().ToString();
            string hash = BCrypt.Net.BCrypt.HashPassword(NewPlayer.Password + salt);
            player.Id = GameService.PlayerId;
            player.PasswordHash = hash;
            player.Salt = salt;

            if(UsernameTrue(TxUsername.Text) == "This username is already occupied!")
            {
                TxUsername.ForeColor = Color.Red;
            }
            else if (PasswordTrue(TxNewPassword.Text))
            {
                PasswordError.Text = "Password must be at least 8 characters long.\nPassword must contain at least 3 of the following:\nlowercase, uppercase, alphabetic, numeric, special symbols.";
            }
            else
            {
                Task.Run(() => playerRepository.Update(GameService.PlayerId, player));
                PasswordError.Text = "";
                TxUsername.ForeColor = Color.Green;
                TxSuccessful.Text = "Successful";
            }
        }

        private string UsernameTrue(string username)
        {
            var Player = playerRepository.GetById(GameService.PlayerId);

            if(Player.Username != username)
            {
                try
                {
                    var json = File.ReadAllText(_dbPath);
                    var Players = JsonConvert.DeserializeObject<List<Player>>(json);

                    foreach (var player in Players)
                    {
                        if (player.Username == username)
                        {
                            return "This username is already occupied!";
                            TxUsername.Text = "This username is already occupied!";
                        }
                    }

                    return username;
                }
                catch { return username; }
            }
            return username;
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

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage Mp = new MainPage();
            Mp.ShowDialog();
        }

        private void TxUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnPasswordChar_Click(object sender, EventArgs e)
        {
            if (TxNewPassword.PasswordChar == '*')
            {
                TxNewPassword.PasswordChar = '\0';
            }
            else
            {
                TxNewPassword.PasswordChar = '*';
            }
        }
    }
}
