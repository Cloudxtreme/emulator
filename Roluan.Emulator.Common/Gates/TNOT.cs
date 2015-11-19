using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common.Gates
{
    public static class TNOT
    {
        /// <summary>
        /// Represents a ternary NOT gate.
        /// </summary>
        /// <param name="input">The input <see cref="Trit"/></param>
        /// <returns>Ternary NOT <see cref="Trit"/> output</returns>
        public static Trit Output(Trit input)
        {
            Check.IsNull(input);

            switch (input.State)
            {
                case TritState.Negative:
                    {
                        return new Trit(TritState.Positive);
                    }
                case TritState.Positive:
                    {
                        return new Trit(TritState.Negative);
                    }
                default:
                    {
                        return new Trit(TritState.Zero);
                    }
            }
        }
    }
}
