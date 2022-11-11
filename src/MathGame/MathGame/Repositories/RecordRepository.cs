using MathGame.Constants;
using MathGame.Interfaces.Repositories;
using MathGame.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Repositories
{
    public class RecordRepository : IRecordRepository
    {
        private readonly string _dbPath = DbConstants.RECORD_DB;
        private readonly string _dbPathPlayer = DbConstants.PLAYER_DB;
        public bool Create(Record obj)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Records = JsonConvert.DeserializeObject<List<Record>>(json);
                Records.Add(obj);
                json = JsonConvert.SerializeObject(Records);
                File.WriteAllText(_dbPath, json);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Update(int id, Record obj)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Records = JsonConvert.DeserializeObject<List<Record>>(json);

                for (int i = 0; i < Records.Count; i++)
                {
                    if (Records[i].Id == id)
                    {
                        Records[i] = obj;
                    }
                }

                json = JsonConvert.SerializeObject(Records);
                File.WriteAllText(_dbPath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetById(int id)
        {
            try
            {
                var json = File.ReadAllText(_dbPathPlayer);
                var Players = JsonConvert.DeserializeObject<List<Player>>(json);

                foreach (var player in Players)
                {
                    if (player.Id == id)
                    {
                        return player.Username;
                    }
                }

                return null;
            }
            catch { return null; }
        }

        public int MyRecord(int Id)
        {
            List<int> records = new List<int>();
            try
            {
                var json = File.ReadAllText(_dbPath);
                var Records = JsonConvert.DeserializeObject<List<Record>>(json);

                foreach (var record in Records)
                {
                    if (record.PlayerId == Id)
                    {
                        records.Add(record.PlayerRecord);
                    }
                }

                records.Sort(); ;
                return records[records.Count - 1];
            }
            catch { return 0; }
        }
    }
}
