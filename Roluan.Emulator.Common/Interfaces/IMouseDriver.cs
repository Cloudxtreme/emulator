using System.Collections.Generic;
using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.Common.Base;

namespace Roluan.Common.Interfaces
{
    public interface IMouseDriver : IDriver
    {
        bool Initialize(IMouseHardware hardwareInstance);
        List<Tryte> MouseAction { get; set; }
        RegisterBase Instance { get; set; }
    }
}
