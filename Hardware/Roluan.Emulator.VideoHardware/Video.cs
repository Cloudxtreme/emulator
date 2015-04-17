using Roluan.Emulator.Board.Interfaces;
using Roluan.Emulator.Common.Enums;
using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.VideoHardware
{
    public class Video: IVideo
    {
        public int Cores
        {
            get { return 8; }
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