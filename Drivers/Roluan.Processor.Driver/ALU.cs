using Roluan.Common;
using System.Linq;
using Roluan.Common.Enums;
using System.Collections.Generic;
using System;

namespace Roluan.Processor.Driver
{
    /* public enum ALU
     {
         ADD,
         SUBSTRACT,
         INCREMENT,
         DECREMENT, 
         MULTIPLY,
         OR,
         XOR,
         AND,
         NOT,
         JUMP
     }*/

    public class ALU
    {
        Trit extraState = new Trit() { State = TritState.Zero };
        private ALU()
        {

            ALUOperations.Add(new ALUOperation()
            {
                OperationName = "ADD",
                OperationCode = new List<Trit>(){
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Negative}}
            });

            ALUOperations.Add(new ALUOperation()
            {
                OperationName = "SUBSTRACT",
                OperationCode = new List<Trit>(){
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Zero}}
            });

            ALUOperations.Add(new ALUOperation()
            {
                OperationName = "INCREMENT",
                OperationCode = new List<Trit>(){
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Positive}}
            });

            ALUOperations.Add(new ALUOperation()
            {
                OperationName = "DECREMENT",
                OperationCode = new List<Trit>(){
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Zero},
            new Trit(){State=TritState.Negative}}
            });
            ALUOperations.Add(new ALUOperation()
            {
                OperationName = "MULTIPLY",
                OperationCode = new List<Trit>(){
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Zero},
            new Trit(){State=TritState.Zero}}
            });
            ALUOperations.Add(new ALUOperation()
            {
                OperationName = "OR",
                OperationCode = new List<Trit>(){
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Zero},
            new Trit(){State=TritState.Positive}}
            });
            ALUOperations.Add(new ALUOperation()
            {
                OperationName = "XOR",
                OperationCode = new List<Trit>(){
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Positive},
            new Trit(){State=TritState.Negative}}
            });

            ALUOperations.Add(new ALUOperation()
            {
                OperationName = "NOT",
                OperationCode = new List<Trit>(){
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Positive},
            new Trit(){State=TritState.Zero}}
            });

            ALUOperations.Add(new ALUOperation()
            {
                OperationName = "JUMP",
                OperationCode = new List<Trit>(){
            new Trit(){State=TritState.Negative},
            new Trit(){State=TritState.Positive},
            new Trit(){State=TritState.Positive}}
            });

        }

        public bool MaxTrit(Trit FirstNumber, Trit SecondNumber)
        {
            if (FirstNumber.State == TritState.Positive && SecondNumber.State == TritState.Zero) { return true; }
            if (FirstNumber.State == TritState.Positive && SecondNumber.State == TritState.Negative) { return true; }
            if (FirstNumber.State == TritState.Zero && SecondNumber.State == TritState.Positive) { return false; }
            if (FirstNumber.State == TritState.Zero && SecondNumber.State == TritState.Negative) { return true; }
            if (FirstNumber.State == TritState.Negative && SecondNumber.State == TritState.Positive) { return false; }
            if (FirstNumber.State == TritState.Negative && SecondNumber.State == TritState.Zero) { return false; }
            return false;
        }
        public Trit ADDWithoutExtraState(Trit FirstState, Trit SecondState)
        {
            if (FirstState.State == TritState.Negative && SecondState.State == TritState.Negative)
            {
                extraState.State = TritState.Negative;
                return new Trit() { State = TritState.Positive };
            }

            if (FirstState.State == TritState.Negative && SecondState.State == TritState.Zero)
            {
                extraState.State = TritState.Zero;
                return new Trit() { State = TritState.Negative };
            }

            if (FirstState.State == TritState.Negative && SecondState.State == TritState.Positive)
            {
                extraState.State = TritState.Zero;
                return new Trit() { State = TritState.Zero };
            }

            if (FirstState.State == TritState.Zero && SecondState.State == TritState.Negative)
            {
                extraState.State = TritState.Zero;
                return new Trit() { State = TritState.Negative };
            }

            if (FirstState.State == TritState.Zero && SecondState.State == TritState.Zero)
            {
                extraState.State = TritState.Zero;
                return new Trit() { State = TritState.Zero };
            }
            if (FirstState.State == TritState.Zero && SecondState.State == TritState.Positive)
            {
                extraState.State = TritState.Zero;
                return new Trit() { State = TritState.Positive };
            }

            if (FirstState.State == TritState.Positive && SecondState.State == TritState.Negative)
            {
                extraState.State = TritState.Zero;
                return new Trit() { State = TritState.Zero };
            }
            if (FirstState.State == TritState.Positive && SecondState.State == TritState.Zero)
            {
                extraState.State = TritState.Zero;
                return new Trit() { State = TritState.Positive };
            }
            if (FirstState.State == TritState.Positive && SecondState.State == TritState.Positive)
            {
                extraState.State = TritState.Positive;
                return new Trit() { State = TritState.Negative };
            }
            return null;
        }
        public Trit ADDWithExtraState(Trit FirstState, Trit SecondState, Trit Extrastate)
        {
            if (FirstState.State != Extrastate.State)
            {
                return ADDWithoutExtraState(SecondState, ADDWithoutExtraState(FirstState, Extrastate));

            }
            else if (SecondState.State != Extrastate.State)
            {
                return ADDWithoutExtraState(FirstState, ADDWithoutExtraState(SecondState, Extrastate));
            }
            else { return new Trit() { State = TritState.Zero }; }
        }
        public List<Trit> NOT(List<Trit> input)
        {
            List<Trit> result = new List<Trit>();
            for (int i = 0; i < input.Count; i++)
            {

                if (input.ElementAt(i).State == TritState.Negative) { result.Add(new Trit { State = TritState.Positive }); }
                else if (input.ElementAt(i).State == TritState.Positive) { result.Add(new Trit { State = TritState.Negative }); }
                else result.Add(new Trit { State = TritState.Zero });
            }

            return result;
        }
        private List<Trit> DECRIMENT(List<Trit> firstnumber)
        {
            List<Trit> Decriment = new List<Trit>();
            Decriment.Add(new Trit() { State = TritState.Negative });
            for (int i = 1; i < firstnumber.Count; i++)
            {
                Decriment.Add(new Trit() { State = TritState.Zero });
            }
            return ADDTwoNumbers(firstnumber, Decriment);
        }
        private List<Trit> INCREMENT(List<Trit> firstnumber)
        {
            List<Trit> Increment = new List<Trit>();
            Increment.Add(new Trit() { State = TritState.Positive });
            for (int i = 1; i < firstnumber.Count; i++)
            {
                Increment.Add(new Trit() { State = TritState.Zero });
            }
            return ADDTwoNumbers(firstnumber, Increment);

        }
        private List<Trit> XOR(List<Trit> firstnumber, List<Trit> secondnumber)
        {
            List<Trit> result = new List<Trit>();
            result = OR(AND(firstnumber, NOT(secondnumber)), AND(NOT(firstnumber), secondnumber));
            return result;
        }
        private List<Trit> OR(List<Trit> firstnumber, List<Trit> secondnumber)
        {
            List<Trit> result = new List<Trit>();

            for (int i = 0; i < setMaxNumber(firstnumber, secondnumber); i++)
            {

                if (firstnumber.ElementAt(i).State == TritState.Negative && secondnumber.ElementAt(i).State == TritState.Negative)
                {
                    result.Add(new Trit() { State = TritState.Negative });
                }

                if (firstnumber.ElementAt(i).State == TritState.Negative && secondnumber.ElementAt(i).State == TritState.Zero)
                {
                    result.Add(new Trit() { State = TritState.Zero });
                }

                if (firstnumber.ElementAt(i).State == TritState.Negative && secondnumber.ElementAt(i).State == TritState.Positive)
                {
                    result.Add(new Trit() { State = TritState.Positive });
                }

                if (firstnumber.ElementAt(i).State == TritState.Zero && secondnumber.ElementAt(i).State == TritState.Negative)
                {
                    result.Add(new Trit() { State = TritState.Zero });
                }

                if (firstnumber.ElementAt(i).State == TritState.Zero && secondnumber.ElementAt(i).State == TritState.Zero)
                {
                    result.Add(new Trit() { State = TritState.Zero });
                }
                if (firstnumber.ElementAt(i).State == TritState.Zero && secondnumber.ElementAt(i).State == TritState.Positive)
                {
                    result.Add(new Trit() { State = TritState.Positive });
                }

                if (firstnumber.ElementAt(i).State == TritState.Positive && secondnumber.ElementAt(i).State == TritState.Negative)
                {
                    result.Add(new Trit() { State = TritState.Positive });
                }
                if (firstnumber.ElementAt(i).State == TritState.Positive && secondnumber.ElementAt(i).State == TritState.Zero)
                {
                    result.Add(new Trit() { State = TritState.Positive });
                }
                if (firstnumber.ElementAt(i).State == TritState.Positive && secondnumber.ElementAt(i).State == TritState.Positive)
                {
                    result.Add(new Trit() { State = TritState.Positive });
                }
            }
            return result;
        }
        private List<Trit> AND(List<Trit> firstnumber, List<Trit> secondnumber)
        {
            List<Trit> result = new List<Trit>();

            for (int i = 0; i < setMaxNumber(firstnumber, secondnumber); i++)
            {

                if (firstnumber.ElementAt(i).State == TritState.Negative && secondnumber.ElementAt(i).State == TritState.Negative)
                {
                    result.Add(new Trit() { State = TritState.Negative });
                }

                if (firstnumber.ElementAt(i).State == TritState.Negative && secondnumber.ElementAt(i).State == TritState.Zero)
                {
                    result.Add(new Trit() { State = TritState.Negative });
                }

                if (firstnumber.ElementAt(i).State == TritState.Negative && secondnumber.ElementAt(i).State == TritState.Positive)
                {
                    result.Add(new Trit() { State = TritState.Negative });
                }

                if (firstnumber.ElementAt(i).State == TritState.Zero && secondnumber.ElementAt(i).State == TritState.Negative)
                {
                    result.Add(new Trit() { State = TritState.Negative });
                }

                if (firstnumber.ElementAt(i).State == TritState.Zero && secondnumber.ElementAt(i).State == TritState.Zero)
                {
                    result.Add(new Trit() { State = TritState.Zero });
                }
                if (firstnumber.ElementAt(i).State == TritState.Zero && secondnumber.ElementAt(i).State == TritState.Positive)
                {
                    result.Add(new Trit() { State = TritState.Zero });
                }

                if (firstnumber.ElementAt(i).State == TritState.Positive && secondnumber.ElementAt(i).State == TritState.Negative)
                {
                    result.Add(new Trit() { State = TritState.Negative });
                }
                if (firstnumber.ElementAt(i).State == TritState.Positive && secondnumber.ElementAt(i).State == TritState.Zero)
                {
                    result.Add(new Trit() { State = TritState.Zero });
                }
                if (firstnumber.ElementAt(i).State == TritState.Positive && secondnumber.ElementAt(i).State == TritState.Positive)
                {
                    result.Add(new Trit() { State = TritState.Positive });
                }

            }

            return result;
        }
        private List<Trit> MULTIPLY(List<Trit> FirstOperand, List<Trit> SecondOperand)
        {
            {
                List<List<Trit>> Temp = new List<List<Trit>>();
                List<Trit> tempTritList = new List<Trit>();
                List<Trit> tmp = new List<Trit>();

                if (FirstOperand.Count >= SecondOperand.Count)
                {
                    tmp = SecondOperand;
                    SecondOperand = new List<Trit>();
                    for (int i = 0; i < FirstOperand.Count - tmp.Count; i++)
                    {
                        SecondOperand.Add(new Trit() { State = TritState.Zero });
                    }
                    SecondOperand.AddRange(tmp);
                }
                else
                {
                    tmp = FirstOperand;
                    FirstOperand = new List<Trit>();
                    for (int i = 0; i < SecondOperand.Count - tmp.Count; i++)
                    {
                        FirstOperand.Add(new Trit() { State = TritState.Zero });
                    }
                    FirstOperand.AddRange(tmp);
                }

                int count = 0;
                for (int i = setMaxNumber(FirstOperand, SecondOperand); i > 0; i--, count++)
                {
                    for (int j = setMaxNumber(FirstOperand, SecondOperand); j > 0; j--)
                    {
                        tempTritList.Add(MultiplyState(FirstOperand.ElementAt(j - 1), SecondOperand.ElementAt(i - 1)));

                    }
                    tempTritList.Reverse();
                    for (int z = 0; z < count; z++)
                    {
                        tempTritList.Add(new Trit() { State = TritState.Zero });

                    }

                    Temp.Add(tempTritList);
                    tempTritList = new List<Trit>();
                }
                List<Trit> result = Temp.ElementAt(0);
                List<Trit> temporaryResult = new List<Trit>();
                extraState = new Trit() { State = TritState.Zero };


                for (int i = 1; i < Temp.Count; i++)
                {
                    temporaryResult = result;
                    result = ADDTwoNumbers(temporaryResult, Temp.ElementAt(i));
                }

                while (result[0].State == TritState.Zero)
                {
                    List<Trit> WhileTmp = new List<Trit>();
                    if (result[0].State == TritState.Zero)
                    {
                        for (int i = 1; i < result.Count; i++)
                        {
                            WhileTmp.Add(result[i]);
                        }
                        result = WhileTmp;

                    }
                }
                return result;
            }
        }
        private int setMaxNumber(List<Trit> firstnumber, List<Trit> secondnumber)
        {
            //List<Trit> tmp = new List<Trit>();
            if (firstnumber.Count >= secondnumber.Count)
            {
                return firstnumber.Count;
            }
            else
            {
                return secondnumber.Count;
            }
        }
        private List<Trit> SUBSTRACT(List<Trit> firstnumber, List<Trit> secondnumber)
        {
            return ADDTwoNumbers(firstnumber, NOT(secondnumber));
        }
        private List<Trit> ADDTwoNumbers(List<Trit> firstnumber, List<Trit> secondnumber)
        {
            List<Trit> result = Enumerable.Repeat(new Trit() { }, setMaxNumber(firstnumber, secondnumber)).ToList();

            for (int i = 1; i <= setMaxNumber(firstnumber, secondnumber); i++)
            {
                var fV = firstnumber.Count - i < 0 ? new Trit { State = TritState.Zero } : firstnumber[firstnumber.Count - i];
                var sV = secondnumber.Count - i < 0 ? new Trit { State = TritState.Zero } : secondnumber[secondnumber.Count - i];

                if (extraState.State == TritState.Zero)
                {
                    result[result.Count - i] = ADDWithoutExtraState(fV, sV);
                }
                else
                {
                    result[result.Count - i] = ADDWithExtraState(fV, sV, extraState);
                }
            }

            if (extraState.State == TritState.Negative)
            {
                result.Insert(0, new Trit() { State = TritState.Negative });
            }
            else if (extraState.State == TritState.Positive)
            {
                result.Insert(0, new Trit() { State = TritState.Positive });
            }
            else
            {
                result.Insert(0, new Trit() { State = TritState.Zero });
            }

            extraState.State = TritState.Zero;
            return result;
        }
        private Trit MultiplyState(Trit firstState, Trit secondState)
        {
            if (firstState.State == TritState.Negative && secondState.State == TritState.Negative)
            {
                return new Trit() { State = TritState.Positive };
            }
            if (firstState.State == TritState.Negative && secondState.State == TritState.Positive)
            {
                return new Trit() { State = TritState.Negative };
            }
            if (firstState.State == TritState.Negative && secondState.State == TritState.Zero)
            {
                return new Trit() { State = TritState.Zero };
            }
            if (firstState.State == TritState.Zero && secondState.State == TritState.Negative)
            {
                return new Trit() { State = TritState.Zero };
            }
            if (firstState.State == TritState.Zero && secondState.State == TritState.Positive)
            {
                return new Trit() { State = TritState.Zero };
            }
            if (firstState.State == TritState.Zero && secondState.State == TritState.Zero)
            {
                return new Trit() { State = TritState.Zero };
            }
            if (firstState.State == TritState.Positive && secondState.State == TritState.Negative)
            {
                return new Trit() { State = TritState.Negative };
            }
            if (firstState.State == TritState.Positive && secondState.State == TritState.Zero)
            {
                return new Trit() { State = TritState.Zero };
            }
            if (firstState.State == TritState.Positive && secondState.State == TritState.Positive)
            {
                return new Trit() { State = TritState.Positive };
            }
            return null;
        }
        public List<ALUOperation> ALUOperations { get; set; }

    }
}