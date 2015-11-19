namespace Roluan.Emulator.Common.Gates
{
    public static class TNOR
    {
        /// <summary>
        /// Represents a Ternary NOR gate
        /// </summary>
        /// <param name="inputA">The first input <see cref="Trit"/></param>
        /// <param name="inputB">The second input <see cref="Trit"/></param>
        /// <returns>TNOR <see cref="Trit"/> output</returns>
        public static Trit Output(Trit inputA, Trit inputB)
        {
            return TNOT.Output(TOR.Output(inputA, inputB));
        }
    }
}