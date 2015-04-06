using System.Collections.Generic;
using Roluan.Common;

namespace Roluan.Processor.Driver
{
    public class Processor
    {
        public List<ProcessorCore> Cores = new List<ProcessorCore>();
        //public Clock Clock = new Clock();

        public Processor()
        {
            InitializeCores();
        }

        void InitializeCores()
        {
//            for (int i = 0; i < Config.CORES_PER_PROCESSOR; i++)
//            {
//                Cores.Add(new ProcessorCore());
//            }
        }
    }
}