using NAudio.Wave;
using System;
using MathGame.Pages;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathGame.Interfaces.Repositories;
using MathGame.Repositories;
using MathGame.Services;

namespace MathGame.Pages
{
    public partial class WinnnerPage : Form
    {
        private WaveStream stream;
        private WasapiOut out1;
        private int TimerLimit = 30;
        public WinnnerPage()
        {
            InitializeComponent();
            stream = new AudioFileReader("Musics/winner.mp3");
            out1 = new WasapiOut();
            out1.Init(stream);
            stream.CurrentTime = new TimeSpan(0L);
            out1.Play();
        }

        private void WinnnerPage_Load(object sender, EventArgs e)
        {
            BtnOk.FillColor = Color.Transparent;
            BtnOk.ForeColor = Color.Transparent;
            IRecordRepository recordRepository = new RecordRepository();
            string Firstname = recordRepository.GetById(GameService.PlayerId);
            if (Firstname.Length < 10)
            {
                for (int i = 0; i < 10 - Firstname.Length; i++)
                {
                    label1.Text += " ";
                }
                label1.Text += Firstname;
            }
            else
            {
                label1.Text = Firstname;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(TimerLimit > 0)
            {
                TimerLimit--;
            }
            else
            {
                timer1.Stop();
                out1.Stop();
                BtnOk.FillColor = Color.FromArgb(94, 148, 255);
                BtnOk.ForeColor = Color.White;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage Mp = new MainPage();
            Mp.ShowDialog();
        }
    }
}
