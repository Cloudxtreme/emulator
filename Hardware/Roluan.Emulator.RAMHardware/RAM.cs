using Roluan.Emulator.Board.Interfaces;
using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator.RAMHardware
{
    public class RAM: HardwareBase, IRAM
    {
        readonly Controller controller = new Controller();

        #region Implemented abstract members of HardwareBase

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