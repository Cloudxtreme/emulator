using System.Collections.Generic;
using Roluan.Emulator.Board.Interfaces;

namespace Roluan.Emulator.Board.Components.Bus
{
    public class NorthBridge
    {
        #region Constructors

        public NorthBridge()
        {
            Processors = new List<IProcessor>();
            RAM = new List<IRAM>();
            Video = new List<IVideo>();
        }

        #endregion

        #region Properties

        public List<IProcessor> Processors { get; private set; }

        public List<IRAM> RAM { get; private set; }

        public List<IVideo> Video { get; private set; }

        #endregion
    }
}