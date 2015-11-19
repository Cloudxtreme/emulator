namespace Roluan.Emulator.Common.Gates
{
    public static class TNAND
    {
        /// <summary>
        /// Represents The Ternary NOT AND gate. It is a combination of <see cref="TNOT"/> and <see cref="TAND"/> gates.
        /// </summary>
        /// <param name="inputA">The first input <see cref="Trit"/></param>
        /// <param name="inputB">The second input <see cref="Trit"/></param>
        /// <returns>TNAND <see cref="Trit"/> output</returns>
        public static Trit Output(Trit inputA, Trit inputB)
        {
            return TNOT.Output(TAND.Output(inputA, inputB));
        }
    }
}