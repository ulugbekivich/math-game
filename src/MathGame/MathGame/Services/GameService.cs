using MathGame.Constants;
using MathGame.Interfaces.Repositories;
using MathGame.MockData;
using MathGame.Models;
using MathGame.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Services
{
    
    public class GameService
    {
        MathService mathService = new MathService();
        QuestionsData questionsData = new QuestionsData();

        public int Score = 0;
        public static int PlayerId;
        public bool Win;
        public void GetId(int id)
        {
            PlayerId = id;
        }
        public void ScoreAdd(int num)
        {
            Score+=num;
        }

        public int MyRecord()
        {
            string json = File.ReadAllText(DbConstants.RECORD_DB);
            var Records = JsonConvert.DeserializeObject<List<Record>>(json);

            IRecordRepository recordRepository = new RecordRepository();

            return recordRepository.MyRecord(PlayerId);
        }

        public async void Lose(int score)
        {
            
            string json = File.ReadAllText(DbConstants.RECORD_DB);
            var Records = JsonConvert.DeserializeObject<List<Record>>(json);
            IRecordRepository recordRepository = new RecordRepository();
            var NewRecord = new Record();
            bool check = false;
            foreach (var record in Records)
            {
                if(record.PlayerId == PlayerId)
                {
                    NewRecord.Id = record.Id;
                    NewRecord.PlayerId = record.PlayerId;
                    NewRecord.PlayerRecord = score > record.PlayerRecord ? score : record.PlayerRecord;

                    await Task.Run(() => recordRepository.Update(record.Id, NewRecord));
                    check = true;
                    break;
                }
            }

            if(check == false)
            {
                NewRecord.Id = Records.Count() + 1;
                NewRecord.PlayerId = PlayerId;
                NewRecord.PlayerRecord = score;

                await Task.Run(() => recordRepository.Create(NewRecord));
            }
        }

        public string NewQuestion()
        {
            Random rand = new Random();

            try
            {
                if (questionsData.Questions[0].Count == 0)
                {
                    questionsData.Questions.RemoveAt(0);
                }
            }
            catch
            {
                Win = true;
                return "    You Win";
            }

            if (questionsData.Questions.Count == 0)
            {
                Win = true;
                return "    You Win";
            }
            else
            {
                Win = false;
            }

            string Question = questionsData.Questions[0][rand.Next(0, questionsData.Questions[0].Count)];
            questionsData.Questions[0].Remove(Question);
            return Question;
        }

        public int Answer(string question, int answer)
        {
            if(question != "    You Win")
            {
                int result = mathService.Evaluate(question.Substring(0, question.IndexOf('=') - 1));
                if (result == answer) return 1;
                return 0;
            }
            return 3;
        }
    }
}
