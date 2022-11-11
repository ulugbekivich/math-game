using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.ViewModels
{
    public class PlayerCreateViewModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int Age { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public static implicit operator Player (PlayerCreateViewModel playerCreateViewModel)
        {
            return new Player
            {
                FirstName = playerCreateViewModel.FirstName,
                LastName = playerCreateViewModel.LastName,
                Age = playerCreateViewModel.Age,
                Username = playerCreateViewModel.Username,
            };
        }
    }
}
