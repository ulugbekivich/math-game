using MathGame.Models;
using MathGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Interfaces.Services
{
    public interface IPlayerService
    {
        Task<bool> RegisterAsync(PlayerCreateViewModel playerCreateViewModel);

        Task<Player> LoginAsync(string username, string password);
    }
}
