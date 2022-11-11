using MathGame.Constants;
using MathGame.Interfaces.Repositories;
using MathGame.Interfaces.Services;
using MathGame.Models;
using MathGame.Repositories;
using MathGame.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly string _dbPath = DbConstants.PLAYER_DB;

        private IPlayerRepository _playerRepository;

        public PlayerService()
        {
            this._playerRepository = new PlayerRepository();
        }

        public async Task<Player> LoginAsync(string username, string password)
        {
            var player = await Task.Run(() => _playerRepository.GetByUsername(username));
            if (player is null) return null;
            else
            {
                var HasherRsult = BCrypt.Net.BCrypt.Verify(password + player.Salt, player.PasswordHash);
                if (HasherRsult) return player;
                else return null;
            }
        }

        public async Task<bool> RegisterAsync(PlayerCreateViewModel playerCreateViewModel)
        {
            string json = File.ReadAllText(_dbPath);
            var Players = JsonConvert.DeserializeObject<List<Player>>(json);
            var player = (Player)playerCreateViewModel;
            string salt = Guid.NewGuid().ToString();
            string hash = BCrypt.Net.BCrypt.HashPassword(playerCreateViewModel.Password + salt);
            player.PasswordHash = hash;
            player.Salt = salt;
            player.Id = Players.Count + 1;
            await Task.Run(() => _playerRepository.Create(player));
            return true;
        }
    }
}
