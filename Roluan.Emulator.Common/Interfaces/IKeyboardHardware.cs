using Roluan.Common.Enums;
namespace Roluan.Common.Interfaces
{
    public interface IKeyboardHardware : IHardware
    {
        KeyboardType KeyboardType { get; }
    }
}
