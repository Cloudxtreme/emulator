using Roluan.Common.Enums;
using Roluan.Common.Interfaces;

namespace Roluan
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