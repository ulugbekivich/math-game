using MathGame.Helpers;
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
    public partial class GamePage : Form
    {
        GameService gameService = new GameService();
        System.Timers.Timer timer;
        int s, ms;

        public GamePage()
        {
            InitializeComponent();
        }

        private void BtnAnswer1_Click(object sender, EventArgs e)
        {
            int result = gameService.Answer(LbQuestion.Text, 1);
            if (result == 1)
            {
                string question = gameService.NewQuestion();
                LbQuestion.Text = question;
                gameService.ScoreAdd(question.Count() - 10);
                LbScore.Text = gameService.Score.ToString();
                timer.Stop();
                ms = 0;
                s = 0;
                timer.Start();
            }
            else if (result == 0)
            {
                gameService.Lose(gameService.Score);
                timer.Stop();
                this.Hide();
                MessageBox.Show($"You Lose!\nYour score {gameService.Score}", $"{YouLoseHelper.YouLose(0)}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainPage Mp = new MainPage();
                Mp.ShowDialog();
            }
        }

        private void BtnAnswer2_Click(object sender, EventArgs e)
        {
            int result = gameService.Answer(LbQuestion.Text, 2);
            if (result == 1)
            {
                string question = gameService.NewQuestion();
                LbQuestion.Text = question;
                gameService.ScoreAdd(question.Count() - 10);
                LbScore.Text = gameService.Score.ToString();
                timer.Stop();
                ms = 0;
                s = 0;
                timer.Start();
            }
            else if (result == 0)
            {
                gameService.Lose(gameService.Score);
                timer.Stop();
                this.Hide();
                MessageBox.Show($"You Lose!\nYour score {gameService.Score}", $"{YouLoseHelper.YouLose(0)}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainPage Mp = new MainPage();
                Mp.ShowDialog();
            }
        }
 
        private void BtnAnswer3_Click(object sender, EventArgs e)
        {
            int result = gameService.Answer(LbQuestion.Text, 3);
            if (result == 1)
            {
                string question = gameService.NewQuestion();
                LbQuestion.Text = question;
                gameService.ScoreAdd(question.Count() - 10);
                LbScore.Text = gameService.Score.ToString();
                timer.Stop();
                ms = 0;
                s = 0;
                timer.Start();
            }
            else if(result == 0)
            {
                gameService.Lose(gameService.Score);
                timer.Stop();
                this.Hide();
                MessageBox.Show($"You Lose!\nYour score {gameService.Score}", $"{YouLoseHelper.YouLose(0)}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainPage Mp = new MainPage();
                Mp.ShowDialog();
            }
        }
        private void GamePage_Load(object sender, EventArgs e)
        {
            string question = gameService.NewQuestion();
            LbQuestion.Text = question;
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                TimerCheck(s);
                ChangeColor(s, ms);
                if (LbQuestion.Text == "    You Win")
                {
                    gameService.Lose(gameService.Score);
                    timer.Stop();
                    this.Hide();
                    WinnnerPage Wp = new WinnnerPage();
                    Wp.ShowDialog();
                }
                ms += 1;
                if (ms == 100)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                }

                BtnClock.Text = String.Format("{0}:{1}",
                    (2 - s).ToString().PadLeft(2, '0'),
                    (100 - ms).ToString().PadLeft(2, '0'));
            }));
        }

        private void BtnClock_Click(object sender, EventArgs e)
        {

        }

        public void TimerCheck(int s)
        {
            if (s == 3)
            {
                gameService.Lose(gameService.Score);
                BtnClock.Text = String.Format("{0}:{1}", "0", "0");
                timer.Stop();
                MessageBox.Show($"You Lose!\nYour score {gameService.Score}", $"{YouLoseHelper.YouLose(1)}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                MainPage Mp = new MainPage();
                Mp.ShowDialog();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();
            MainPage Mp = new MainPage();
            Mp.ShowDialog();
        }

        public void ChangeColor(int s, int ms)
        {
            if (ms % 10 == 0)
            {
                BtnClock.BorderColor = Color.White;
            }
            else if (ms % 10 == 5)
            {
                BtnClock.BorderColor = Color.Black;
            }

            ///////////////////////////
            
            if(s == 0 && ms == 0)
            {
                PnlAnswers.BackColor = Color.LimeGreen;
            }
            else if(s == 0 && ms == 50)
            {
                PnlAnswers.BackColor = Color.Chartreuse;
            }
            else if (s == 1 && ms == 0)
            {
                PnlAnswers.BackColor = Color.Yellow;
            }
            else if(s == 1 && ms == 50)
            {
                PnlAnswers.BackColor = Color.FromArgb(255, 255, 100);
            }
            else if(s == 2 && ms == 0)
            {
                PnlAnswers.BackColor= Color.OrangeRed;
            }
            else if(s == 3 && ms == 50)
            {
                PnlAnswers.BackColor = Color.Red;
            }
        }
    }
}
