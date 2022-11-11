using MathGame.Constants;
using MathGame.Interfaces.Common;
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
    public class PlayerRepository : IPlayerRepository
    {
        private readonly string _dbPath = DbConstants.PLAYER_DB;
        public bool Create(Player obj)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Players = JsonConvert.DeserializeObject<List<Player>>(json);
                Players.Add(obj);
                json = JsonConvert.SerializeObject(Players);
                File.WriteAllText(_dbPath, json);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public Player GetById(int Id)
        {
            try
            {
                var json = File.ReadAllText(_dbPath);
                var Players = JsonConvert.DeserializeObject<List<Player>>(json);

                foreach (var player in Players)
                {
                    if (player.Id == Id)
                    {
                        return player;
                    }
                }

                return null;
            }
            catch { return null; }
        }

        public Player GetByUsername(string username)
        {
            try
            {
                var json = File.ReadAllText(_dbPath);
                var Players = JsonConvert.DeserializeObject<List<Player>>(json);

                foreach (var player in Players)
                {
                    if (player.Username == username)
                    {
                        return player;
                    }
                }

                return null;
            }
            catch { return null; }
        }

        public bool Update(int id, Player obj)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Players = JsonConvert.DeserializeObject<List<Player>>(json);

                for (int i = 0; i < Players.Count; i++)
                {
                    if (Players[i].Id == id)
                    {
                        Players[i] = obj;
                    }
                }

                json = JsonConvert.SerializeObject(Players);
                File.WriteAllText(_dbPath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
