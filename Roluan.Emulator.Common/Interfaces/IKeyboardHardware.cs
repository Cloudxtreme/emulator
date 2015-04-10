using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common.Interfaces
{
    public interface IKeyboardHardware : IHardware
    {
        KeyboardType KeyboardType { get; }
    }
}