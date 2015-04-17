using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.VideoHardware
{
    public class Hardware : IHardwareInitializer
    {
        public IHardware Initialize()
        {
            return new Video();
        }
    }
}