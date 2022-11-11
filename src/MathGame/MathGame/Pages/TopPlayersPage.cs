using MathGame.Constants;
using MathGame.Interfaces.Repositories;
using MathGame.Models;
using MathGame.Repositories;
using MathGame.Services;
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
    public partial class TopPlayersPage : Form
    {
        public TopPlayersPage()
        {
            InitializeComponent();
        }

        private void TopPlayersPage_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText(DbConstants.RECORD_DB);
            var Records = JsonConvert.DeserializeObject<List<Record>>(json);

            Records = Records.OrderByDescending(x => x.PlayerRecord).ToList();

            IRecordRepository recordRepository = new RecordRepository();

            for (int i = 1; i <= Records.Count; i++)
            {
                TopPlayersView.Rows.Add(new object[] { i, recordRepository.GetById(Records[i - 1].PlayerId), Records[i - 1].PlayerRecord });
            }
            
        }

        private void TopPlayersView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
