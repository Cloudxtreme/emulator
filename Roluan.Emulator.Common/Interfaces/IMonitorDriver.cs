using System.Collections.Generic;
using Roluan.Emulator.Common;
using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.Common.Interfaces
{
    public interface IMonitorDriver : IDriver
    {
        bool Initialize(IMonitorHardware hardwareInstance);
        RegisterBase Instance { get; set; }
        List<Resolution> Resolutions { get; set; }
    }
}