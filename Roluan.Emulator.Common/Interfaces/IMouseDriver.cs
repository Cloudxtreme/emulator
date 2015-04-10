using System.Collections.Generic;
using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.Common.Interfaces
{
    public interface IMouseDriver : IDriver
    {
        bool Initialize(IMouseHardware hardwareInstance);

        List<Tryte> MouseAction { get; set; }

        RegisterBase Instance { get; set; }
    }
}