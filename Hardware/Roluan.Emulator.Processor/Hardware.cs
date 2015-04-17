using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator
{
    public class Hardware : IHardwareInitializer
    {
        public IHardware Initialize()
        {
            return new Processor.Base.Processor();
        }
    }
}