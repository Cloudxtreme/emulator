using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.RAMHardware;

namespace Roluan.Emulator
{
    public class Hardware : IHardwareInitializer
    {
        public IHardware Initialize()
        {
            return new RAM();
        }
    }
}