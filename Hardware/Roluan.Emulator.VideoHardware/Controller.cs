using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator.VideoHardware
{
    public class Controller : ControllerBase
    {
        readonly DriverBase driver = new Driver();

        #region implemented abstract members of ControllerBase

        public override DriverBase Driver
        {
            get
            {
                return driver;
            }
        }

        #endregion
    }
}