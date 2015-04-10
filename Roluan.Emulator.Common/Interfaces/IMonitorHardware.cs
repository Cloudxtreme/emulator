namespace Roluan.Emulator.Common.Interfaces
{
    public   interface IMonitorHardware: IHardware
    {
        // in points
        long Width { get; }

        // in points
        long Height { get; }
    }
}