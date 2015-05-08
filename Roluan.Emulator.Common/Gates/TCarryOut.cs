using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common.Gates
{
    public static class TCarryOut
    {
        public static Trit Output(Trit inputA, Trit inputB) 
        { 
            Check.IsNull(inputA);
            Check.IsNull(inputB);


            if (inputA.State == TritState.Negative && inputB.State == TritState.Negative)
            {
                return new Trit(TritState.Negative);
            }
            if (inputA.State == TritState.Positive && inputB.State == TritState.Positive)
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