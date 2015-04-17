using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.VideoHardware
{
    public class Hardware : IHardwareInitializer
    {
        public HardwareBase Initialize()
        {
            return new Video();
        }
    }
}