using Roluan.Emulator.Common.Enums;
using Roluan.Emulator.Common.Interfaces;
using Roluan.Processor;

namespace Roluan.Emulator
{
    public class Processor: IHardware
    {
        public int Cores
        {
            get { return 8; }
        }

        public int Cores2
        {
            get { return 8888; }
        }


        public PriorityType PriorityType
        {
            get
            {
                return PriorityType.High;
            }
        }

        public IController Controller
        {
            get
            {
                return new Controller();
            }
        }
    }
}