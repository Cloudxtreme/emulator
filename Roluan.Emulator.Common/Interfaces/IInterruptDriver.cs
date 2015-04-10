using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common;

namespace Roluan.Common.Interfaces
{
   public interface IInterruptDriver:IDriver
    {
        bool Initialize(IInterruptHardware hardwareInstance);

        List<Trit> TritMap { get; set; }
        RegisterBase Instance { get; set; }
    }
}
