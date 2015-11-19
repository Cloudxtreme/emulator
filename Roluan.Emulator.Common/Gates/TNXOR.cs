namespace Roluan.Emulator.Common.Gates
{
    public static class TNXOR
    {
        /// <summary>
        /// Represents a Ternary NOT XOR gate.
        /// </summary>
        /// <param name="inputA">The first input <see cref="Trit"/></param>
        /// <param name="inputB">The second input <see cref="Trit"/></param>
        /// <returns>Ternary NOT XOR <see cref="Trit"/> output</returns>
        public static Trit Output(Trit inputA, Trit inputB)
        { 
            return TNOT.Output(TXOR.Output(inputA, inputB));
        }
    }
}