using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Interfaces.Common
{
    public interface IUpdateable<T>
    {
        bool Update(int id, T obj);
    }
}
