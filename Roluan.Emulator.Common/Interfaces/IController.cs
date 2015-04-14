using System.Collections.Generic;
using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator.Common.Interfaces
{
    public interface IController
    {
        IList<RegisterBase> Registers { get; }

        IDriver Driver { get; }
    }
}