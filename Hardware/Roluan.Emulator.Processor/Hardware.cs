using Roluan.Emulator.Common.Enums;
using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator
{
    public class Hardware : IHardwareInitializer
    {
        public IHardware Initialize()
        {
            return new Processor();
        }
    }
}