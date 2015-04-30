﻿using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common.Gates
{
    public static class TOR
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
                return new Trit(TritState.Zero);   
            }
            else if (inputA.State == TritState.Zero && inputB.State == TritState.Zero)
            {
                return new Trit(TritState.Zero);   
            }
            else
            {
                return new Trit(TritState.Positive);
            }
        }
    }
}