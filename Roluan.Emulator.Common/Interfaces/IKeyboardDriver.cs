using System.Collections.Generic;
using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.Common;
using Roluan.Emulator.Common.Base;

namespace Roluan.Common.Interfaces
{
    public interface IKeyboardDriver : IDriver
    {
        bool Initialize(IKeyboardHardware hardwareInstance);
        List<List<Trit>> Keys { get; set; }
        RegisterBase Instance { get; set; }
    }
}
