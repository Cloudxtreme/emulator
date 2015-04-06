using System.Timers;
using Roluan.Common;

namespace Roluan.Processor.Driver
{
    public class Clock
    {
        Timer Timer { get; set;}

        public Clock()
        {
//            Timer = new Timer(Config.TIMER_FREQUENCY);
//            Timer.Elapsed += OnTick;
//            Timer.Start();
        }

        public virtual void OnTick(System.Object source, ElapsedEventArgs e)
        {

        }
    }
}