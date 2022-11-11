using MathGame.Interfaces.Common;
using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Interfaces.Repositories
{
    public interface IRecordRepository :
        ICreateable<Record>, IUpdateable<Record>
    {
        string GetById(int Id);

        int MyRecord(int Id);
    }
}
