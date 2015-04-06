using Roluan.Common.Enums;
using Roluan.Common.Interfaces;
namespace Roluan
{
    public class Hardware : IMouseHardware
    {
        public PriorityType PriorityType
        {
            get { return PriorityType.High; }
        }
    }
}
