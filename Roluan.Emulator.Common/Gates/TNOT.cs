using Roluan.Emulator.Common.Enums;

namespace Roluan.Emulator.Common.Gates
{
    public static class TNOT
    {
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
                        return new Trit(TritState.Positive);
                    }
            }
        }
    }
}