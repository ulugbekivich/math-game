using MathGame.Interfaces.Common;
using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Interfaces.Repositories
{
    public interface IPlayerRepository :
        ICreateable<Player>, IUpdateable<Player>
    {
        Player GetById(int Id);
        Player GetByUsername(string username);
    }
}
