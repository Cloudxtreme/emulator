using System.Collections.Generic;

namespace Roluan.Emulator.Common.Base
{
    /// <summary>
    /// Represents the base for all memory registers
    /// </summary>
    public class RegisterBase
    {
        public List<Trit> Trits { get; set; }
    }
}