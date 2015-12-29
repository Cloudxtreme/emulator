namespace Roluan.Emulator.Common.Gates
{
    public static class TXOR
    {
        /// <summary>
        /// Represents Ternary XOR Gate
        /// </summary>
        /// <param name="inputA">The first input <see cref="Trit"/></param>
        /// <param name="inputB">The second input <see cref="Trit"/></param>
        /// <returns>Ternary XOR <see cref="Trit"/> output</returns>
        public static Trit Output(Trit inputA, Trit inputB)
        {
            return TAND.Output(TNAND.Output(inputA, inputB), TOR.Output(inputA, inputB));
        }
    }
}