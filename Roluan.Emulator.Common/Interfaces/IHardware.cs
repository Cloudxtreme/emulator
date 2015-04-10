using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common.Interfaces
{
    public interface IHardware
    {
        PriorityType PriorityType { get; }
    }
}