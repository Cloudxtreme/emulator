using Roluan.Common.Base;
using System.Collections.Generic;

namespace Roluan.Common.Interfaces
{
    public interface IMouseDriver : IDriver
    {
        bool Initialize(IMouseHardware hardwareInstance);
        List<Tryte> MouseAction { get; set; }
        RegisterBase Instance { get; set; }
    }
}
