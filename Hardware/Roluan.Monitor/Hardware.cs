using Roluan.Common.Enums;
using Roluan.Common.Interfaces;
namespace Roluan
{
    public class Hardware : IMonitorHardware
    {
        public long Width
        {
            get
            {
                return 1024;
            }

        }
        public long Height
        {
            get
            {
                return 1024;
            }

        }
        public PriorityType PriorityType
        {
            get { return PriorityType.High; }
        }
    }
}
