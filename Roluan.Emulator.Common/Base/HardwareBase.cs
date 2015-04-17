using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator.Common.Base
{
    public abstract class HardwareBase
    {
        public abstract ControllerBase Controller { get; }
    }
}