using Roluan.Common;
using Roluan.Common.Enums;
using Roluan.Common.Interfaces;

namespace Roluan
{
    public class Hardware : IRAMHardware
    {
        public long Size
        {
            get { return 6561; } //KTrytes
        }

        public PriorityType PriorityType
        {
            get { return PriorityType.High; }
        }

    }
}