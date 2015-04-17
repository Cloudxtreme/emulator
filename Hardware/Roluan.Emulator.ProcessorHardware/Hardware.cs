using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.ProcessorHardware;

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