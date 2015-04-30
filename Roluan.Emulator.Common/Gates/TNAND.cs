namespace Roluan.Emulator.Common.Gates
{
    public static class TNAND
    {
        public static Trit Output(Trit inputA, Trit inputB)
        { 
            return TNOT.Output(TAND.Output(inputA, inputB));
        }
    }
}