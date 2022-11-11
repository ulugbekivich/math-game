using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Helpers
{
    public static class YouLoseHelper
    {
        public static string YouLose(int n)
        {
            if(n == 0)
            {
                return "Wrong answer!";
            }
            else
            {
                return "Time is up";
            }
        }
    }
}
