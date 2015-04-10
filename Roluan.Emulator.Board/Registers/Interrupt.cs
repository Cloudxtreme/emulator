using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Board.Registers
{
    public class Interrupt
    {
        public InterruptType InterruptType { get; set; }

        public int Address { get; set; }

        public InterruptPriorityLevel InterruptPriority { get; set; }

        public int RegisterAllocated { get; set; }
    }
}