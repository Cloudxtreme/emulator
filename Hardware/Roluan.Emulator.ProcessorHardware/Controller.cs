using System.Collections.Generic;
using Roluan.Emulator.Common.Base;
using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.ProcessorHardware
{
    public class Controller : IController
    {
        public IDriver Driver
        {
            get
            {
                return new Driver();
            }
        }

        public IList<RegisterBase> Registers
        {
            get
            {
                return new List<RegisterBase>();
            }
        }
    }
}