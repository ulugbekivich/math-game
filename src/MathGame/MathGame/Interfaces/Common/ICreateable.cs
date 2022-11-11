using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Interfaces.Common
{
    public interface ICreateable<T>
    {
        bool Create(T obj);
    }
}
