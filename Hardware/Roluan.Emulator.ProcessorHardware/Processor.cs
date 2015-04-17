using Roluan.Emulator.Board.Interfaces;
using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator.ProcessorHardware
{
    public class Processor: HardwareBase, IProcessor
    {
        readonly Controller controller = new Controller();

        public int Cores
        {
            get { return 8; }
        }

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