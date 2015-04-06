using Roluan.Common.Base;
namespace Roluan.Common.Interfaces
{
    public interface IRAMDriver : IDriver
    {
        bool Initialize(IRAMHardware hardwareInstance);

        RegisterBase Instance { get; set; }
    }
}
