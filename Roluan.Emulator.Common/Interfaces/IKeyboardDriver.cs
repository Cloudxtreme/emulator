using Roluan.Common.Base;
using System.Collections.Generic;

namespace Roluan.Common.Interfaces
{
    public interface IKeyboardDriver : IDriver
    {
        bool Initialize(IKeyboardHardware hardwareInstance);
        List<List<Trit>> Keys { get; set; }
        RegisterBase Instance { get; set; }
    }
}
