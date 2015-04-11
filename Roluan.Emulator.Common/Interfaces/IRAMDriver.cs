using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator.Common.Interfaces
{
    public interface IRAMDriver : IDriver
    {
        bool Initialize(IRAMHardware hardwareInstance);

        RegisterBase Instance { get; set; }
    }
}