using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class Timer
    {
        private int time;

        public Timer(int t)
        {
            time = t;
        }

        public void Start()
        {
            Thread.Sleep(TimeSpan.FromSeconds(time));
            OnCountDownfinished("Countdown has finished!");
        }

        public event Action<string> CountDownfinished;

        public virtual void OnCountDownfinished(string str)
        {
            CountDownfinished?.Invoke(str);
        }
    }
}
