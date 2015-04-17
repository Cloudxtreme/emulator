using Roluan.Emulator.Common.Interfaces;
using System.Collections.Generic;
using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator.Processor.Base
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