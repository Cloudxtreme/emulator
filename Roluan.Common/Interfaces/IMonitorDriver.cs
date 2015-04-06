using Roluan.Common.Base;
using System.Collections.Generic;

namespace Roluan.Common.Interfaces
{
    public interface IMonitorDriver : IDriver
    {
        bool Initialize(IMonitorHardware hardwareInstance);
        RegisterBase Instance { get; set; }
        List<Resolution> Resolutions { get; set; }


    }
}
