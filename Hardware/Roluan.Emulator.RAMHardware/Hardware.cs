using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.RAMHardware;

namespace Roluan.Emulator
{
    public class Hardware : IHardwareInitializer
    {
        public HardwareBase Initialize()
        {
            return new RAM();
        }
    }
}