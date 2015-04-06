using Roluan.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roluan.Common.Interfaces
{
   public interface IInterruptDriver:IDriver
    {
        bool Initialize(IInterruptHardware hardwareInstance);

        List<Trit> TritMap { get; set; }
        RegisterBase Instance { get; set; }
    }
}
