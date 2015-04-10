using System.Collections.Generic;
using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.Common.Base;

namespace Roluan.Common.Interfaces
{
    public interface IMonitorDriver : IDriver
    {
        bool Initialize(IMonitorHardware hardwareInstance);
        RegisterBase Instance { get; set; }
        List<Resolution> Resolutions { get; set; }


    }
}
