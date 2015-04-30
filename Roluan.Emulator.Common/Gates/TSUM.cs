using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common.Gates
{
    public static class TSUM
    {
        public static Trit Output(Trit inputA, Trit inputB) 
        { 
            Check.IsNull(inputA);
            Check.IsNull(inputB);


            if (inputA.State == TritState.Negative && inputB.State == TritState.Negative)
            {
                return new Trit(TritState.Negative);
            }
            else if ((inputA.State == TritState.Negative && inputB.State == TritState.Zero) || (inputA.State == TritState.Zero && inputB.State == TritState.Negative))
            {
                return new Trit(TritState.Negative);   
            }
            else if ((inputA.State == TritState.Positive && inputB.State == TritState.Zero) || (inputA.State == TritState.Zero && inputB.State == TritState.Positive))
            {
                return new Trit();   
            }
            else if ((inputA.State == TritState.Positive && inputB.State == TritState.Negative) || (inputA.State == TritState.Negative && inputB.State == TritState.Positive))
            {
                return new Trit(TritState.Negative);   
            }
            else if (inputA.State == TritState.Zero && inputB.State == TritState.Zero)
            {
                return new Trit();   
            }
            else
            {
                return new Trit(TritState.Positive);
            }
        }
    }
}

