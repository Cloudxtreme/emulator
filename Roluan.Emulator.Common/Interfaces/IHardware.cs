using System;
using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common.Interfaces
{
    public interface IHardware
    {
        IController Controller { get; }

        PriorityType PriorityType { get; }
    }
}