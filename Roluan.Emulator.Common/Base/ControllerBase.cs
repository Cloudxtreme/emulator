using System.Collections.Generic;
using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.Common.Base
{
    /// <summary>
    /// Represents the base for all hardware controllers
    /// </summary>
    public class ControllerBase
    {
        public IList<RegisterBase> Registers { get; set; }

        public IDriver Driver { get; set; }
    }
}