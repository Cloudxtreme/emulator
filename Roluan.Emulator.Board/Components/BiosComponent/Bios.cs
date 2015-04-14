using System;
using System.IO;
using System.Reflection;
using Roluan.Emulator.Common;
using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.Common.Base;

namespace Roluan.Emulator.Board.Components.BiosComponent
{
    public class Bios
    {
        public ROM ROM { get; private set; }

        public Bios()
        {
            InitializeROM();
            InitializeHardware();
        }

        void InitializeROM()
        {
            ROM = new ROM();
        }

        void InitializeHardware()
        {
            DirectoryInfo hardwareDirectory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), Config.HARDWARE_PATH));
            FileInfo[] files = hardwareDirectory.GetFiles("*.dll");
            if (files != null && files.Length > 0)
            {
                ParseHardwareFiles(files);
            }
        }

        void ParseHardwareFiles(FileInfo[] files)
        {
            Assembly hardwareFile = null;
            foreach (FileInfo file in files)
            {
                try
                {
                    hardwareFile = Assembly.LoadFrom(file.FullName);
                    object hardwareInstance = hardwareFile.CreateInstance("Roluan.Emulator.Hardware", true, BindingFlags.CreateInstance, null, null, null, null);
                    if (hardwareInstance is IHardwareInitializer)
                    {
                        (hardwareInstance as IHardwareInitializer).Initialize();
                    }
                }
                catch
                {
                    Console.Beep(800, 2000);
                }
            }
        }
    }
}