using System.Collections.Generic;
using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.Common.Base
{
    public class ControllerBase
    {
        public List<RegisterBase> Registers { get; set; }

        public IDriver Driver { get; set; }
    }
}