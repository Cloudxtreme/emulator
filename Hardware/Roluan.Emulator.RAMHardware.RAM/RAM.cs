using Roluan.Emulator.Board.Interfaces;
using Roluan.Emulator.Common.Enums;
using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.RAMHardware
{
    public class RAM: IRAM
    {
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