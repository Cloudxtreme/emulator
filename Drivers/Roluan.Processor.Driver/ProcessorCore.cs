using System.Collections;
using Roluan.Processor.Driver.Registers;

namespace Roluan.Processor.Driver
{
    public class ProcessorCore
    {
        public Stack DataStack = new Stack();

        //TODO Maybe rename it?
        public Stack ReturnStack = new Stack();

        public CommandsRegister CommandsRegister = new CommandsRegister();
    }
}