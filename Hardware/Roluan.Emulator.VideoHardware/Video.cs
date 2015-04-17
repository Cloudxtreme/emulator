using Roluan.Emulator.Board.Interfaces;
using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator.VideoHardware
{
    public class Video: HardwareBase, IVideo
    {
        readonly Controller controller = new Controller();

        #region implemented abstract members of HardwareBase

        public override ControllerBase Controller
        {
            get
            {
                return controller;
            }
        }

        #endregion
    }
}