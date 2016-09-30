//07.Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TimerDelegates
{
    class Test
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(Timer.Print, 4, 2000);
            timer.TimerExecute();
        }
    }
}
