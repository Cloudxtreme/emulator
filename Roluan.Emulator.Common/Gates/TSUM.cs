using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common.Gates
{
    public static class TSUM
    {
        /// <summary>
        /// Represents Ternary summator
        /// </summary>
        /// <param name="inputA">The first input <see cref="Trit"/></param>
        /// <param name="inputB">The second input <see cref="Trit"/></param>
        /// <returns>Ternary SUM <see cref="Trit"/> output</returns>
        public static Trit Output(Trit inputA, Trit inputB)
        {
            Check.IsNull(inputA);
            Check.IsNull(inputB);

            if (inputA.State == TritState.Negative && inputB.State == TritState.Negative)
            {
                return new Trit(TritState.Positive);
            }
            else if (inputA.State == TritState.Positive && inputB.State == TritState.Positive)
            {
                return new Trit(TritState.Negative);
            }
            else if ((inputA.State == TritState.Negative && inputB.State == TritState.Zero) || (inputA.State == TritState.Zero && inputB.State == TritState.Negative))
            {
                return new Trit(TritState.Negative);
            }
            else if ((inputA.State == TritState.Positive && inputB.State == TritState.Zero) || (inputA.State == TritState.Zero && inputB.State == TritState.Positive))
            {
                return new Trit(TritState.Positive);
            }
            else
            {
                return new Trit(TritState.Zero);
            }
        }
    }
}