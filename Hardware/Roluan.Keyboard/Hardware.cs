using Roluan.Common.Enums;
using Roluan.Common.Interfaces;

namespace Roluan
{
    public class Hardware : IKeyboardHardware
    {

        public PriorityType PriorityType
        {
            get { return PriorityType.High; }
        }

        public KeyboardType KeyboardType
        {
            get { return Common.Enums.KeyboardType.Standard; }
        }

    }
}
