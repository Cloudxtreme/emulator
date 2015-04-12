using Roluan.Emulator.Common.Enums;
using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator
{
    public class Hardware : IProcessorHardware
    {
        public PriorityType PriorityType
        {
            get
            {
                return PriorityType.High;
            }
        }

        public int Cores
        {
            get { return 8; }
        }
    }
}