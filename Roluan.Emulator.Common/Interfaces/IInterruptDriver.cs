using System.Collections.Generic;
using Roluan.Emulator.Common;
using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.Common.Interfaces
{
   public interface IInterruptDriver:IDriver
    {
        bool Initialize(IInterruptHardware hardwareInstance);
        List<Trit> TritMap { get; set; }
        RegisterBase Instance { get; set; }
    }
}