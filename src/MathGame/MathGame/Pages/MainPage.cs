using MathGame.Interfaces.Repositories;
using MathGame.Repositories;
using MathGame.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MathGame.Pages
{
    public partial class MainPage : Form
    {

        GameService gameService = new GameService();
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            IRecordRepository recordRepository = new RecordRepository();
            string Firstname = recordRepository.GetById(GameService.PlayerId);
            LbPlayerName.Text = Firstname;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            gameService.Score = 0;
            this.Hide();
            GamePage Gp = new GamePage();
            Gp.ShowDialog();
            
        }

        private void BtnMyRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You best score {gameService.MyRecord()}");
        }

        private void BtnTopPlayers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TopPlayersPage topPlayersPage = new TopPlayersPage();
            topPlayersPage.ShowDialog();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LbPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void BtnMyProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfilePage profilePage = new ProfilePage();
            profilePage.ShowDialog();
        }
    }
}
