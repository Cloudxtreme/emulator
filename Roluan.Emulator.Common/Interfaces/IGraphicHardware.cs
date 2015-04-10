using Roluan.Emulator.Common.Interfaces;

namespace Roluan.Emulator.Common.Interfaces
{
    public interface IGraphicHardware : IHardware
    {
        long Size { get; }
    }
}