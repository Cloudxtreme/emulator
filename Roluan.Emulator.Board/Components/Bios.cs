using Roluan.Common;
using Roluan.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Roluan.Emulator.Common.Interfaces;
using Roluan.Emulator.Common;

namespace Roluan.Emulator.Board.Components
{
    public class Bios
    {
        public ROM ROM { get; private set; }

        public Bios()
        {
            InitializeROM();
            InitializeHardware();
            Console.Beep(800, 500);
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
                ParseHardware(files);
            }
        }

        void ParseHardware(FileInfo[] files)
        {
            Assembly hardwareFile = null;
            foreach (FileInfo file in files)
            {
                hardwareFile = null;
                try
                {
                    hardwareFile = Assembly.LoadFrom(file.FullName);
                    object hardwareInstance = hardwareFile.CreateInstance("Roluan.Hardware", true, BindingFlags.CreateInstance, null, null, null, null);
                    if (hardwareInstance != null && hardwareInstance is IHardware)
                    {
                        if (hardwareInstance is IRAMHardware)
                        {
                            InitializeRAMHardware((IRAMHardware)hardwareInstance);

                        }
                        else if (hardwareInstance is IKeyboardHardware)
                        {
                            IntializeKeyboardHardware((IKeyboardHardware)hardwareInstance);
                        }
                        else if (hardwareInstance is IMouseHardware)
                        {
                            IntializeMouseHardware((IMouseHardware)hardwareInstance);
                        }
                        else if (hardwareInstance is IGraphicHardware)
                        {

                            InitializeGraphicHardware((IGraphicHardware)hardwareInstance);
                        }
                    }
                }
                catch
                {
                    Console.Beep(800, 2000);
                }
            }
        }

        void IntializeKeyboardHardware(IKeyboardHardware hardwareInstance)
        {
            Assembly driverFile = Assembly.LoadFrom(Path.Combine(Directory.GetCurrentDirectory(), Config.DRIVERS_PATH, "Roluan.Keyboard.Driver.dll"));
            object driverInstance = driverFile.CreateInstance("Roluan.Driver", true, BindingFlags.CreateInstance, null, null, null, null);
            if (driverInstance != null && (driverInstance is IKeyboardDriver) && (driverInstance as IKeyboardDriver).Initialize(hardwareInstance))
            {
                //Board.Instance.Keyboard = (driverInstance as IKeyboardDriver);
            }
            else
            {
            }
        }

        void IntializeMouseHardware(IMouseHardware hardwareInstance)
        {
            Assembly driverFile = Assembly.LoadFrom(Path.Combine(Directory.GetCurrentDirectory(), Config.DRIVERS_PATH, "Roluan.Mouse.Driver.dll"));
            object driverInstance = driverFile.CreateInstance("Roluan.Driver", true, BindingFlags.CreateInstance, null, null, null, null);
            if (driverInstance != null && (driverInstance is IMouseDriver) && (driverInstance as IMouseDriver).Initialize(hardwareInstance))
            {
                //Board.Instance.Mouse = (driverInstance as IMouseDriver);

            }
            else
            {
            }
        }



        void IntializeMonitorHardware(IMonitorHardware hardwareInstance)
        {
            Assembly driverFile = Assembly.LoadFrom(Path.Combine(Directory.GetCurrentDirectory(), Config.DRIVERS_PATH, "Roluan.Monitor.Driver.dll"));
            object driverInstance = driverFile.CreateInstance("Roluan.Driver", true, BindingFlags.CreateInstance, null, null, null, null);
            if (driverInstance != null && (driverInstance is IMonitorDriver) && (driverInstance as IMonitorDriver).Initialize(hardwareInstance))
            {
                //Board.Instance.Monitor = (driverInstance as IMonitorDriver);
            }
            else
            {
            }
        }
        void InitializeRAMHardware(IRAMHardware hardwareInstance)
        {
            Assembly driverFile = Assembly.LoadFrom(Path.Combine(Directory.GetCurrentDirectory(), Config.DRIVERS_PATH, "Roluan.RAM.Driver.dll"));
            object driverInstance = driverFile.CreateInstance("Roluan.Driver", true, BindingFlags.CreateInstance, null, null, null, null);
            if (driverInstance != null && (driverInstance is IRAMDriver) && (driverInstance as IRAMDriver).Initialize(hardwareInstance))
            {
                //Board.Instance.RAM = (driverInstance as IRAMDriver);
            }
            else
            {
                Console.Beep(800, 1000);
                Thread.Sleep(100);
                Console.Beep(800, 1000);
            }
        }

        void InitializeGraphicHardware(IGraphicHardware hardwareInstance)
        {
            Assembly driverFile = Assembly.LoadFrom(Path.Combine(Directory.GetCurrentDirectory(), Config.DRIVERS_PATH, "Roluan.Graphics.Driver.dll"));
            object driverInstance = driverFile.CreateInstance("Roluan.Driver", true, BindingFlags.CreateInstance, null, null, null, null);
            if (driverInstance != null && (driverInstance is IGraphicDriver))
            {
//                (driverInstance as IGraphicDriver).CurrentResolution = new Resolution() { Height = 500 , Width = 800 };
//                (driverInstance as IGraphicDriver).CurrentColorScheme = new ColorScheme() { Name = "2 colors", Size = 1 };
//
//                if ((driverInstance as IGraphicDriver).Initialize(hardwareInstance))
//                {
//                    //Board.Instance.Graphic = (driverInstance as IGraphicDriver);
//                    //Board.Instance.Graphic.TritMap = Roluan.Board.ROM;
//                    List<Trit> sbTrits = this.ROM.SymbolsRegister.Trits.Select(s => s).ToList();
//                    for (int i = 0; i < sbTrits.Count;i++ )
//                    {
//                        //Board.Instance.Graphic.TritMap[i] = sbTrits[i];
//                    }
//
//
//                    var hardwareMonitorFile = Assembly.LoadFrom(Path.Combine(Directory.GetCurrentDirectory(), Config.HARDWARE_PATH, "Roluan.Monitor.dll"));
//
//                    if (hardwareMonitorFile != null)
//                    {
//                        object hardwareMonitorInstance = hardwareMonitorFile.CreateInstance("Roluan.Hardware", true, BindingFlags.CreateInstance, null, null, null, null);
//
//                        if (hardwareMonitorInstance is IMonitorHardware)
//                        {
//                            IntializeMonitorHardware((IMonitorHardware)hardwareMonitorInstance);
//                        }
//                    }
//                }

            }
            else
            {
                Console.Beep(800, 1000);
                Thread.Sleep(100);
                Console.Beep(800, 1000);
            }
        }

        void InitializeIterruptHardware(IInterruptHardware hardwareInstance)
        {
            Assembly driverFile = Assembly.LoadFrom(Path.Combine(Directory.GetCurrentDirectory(), Config.DRIVERS_PATH, "Roluan.Interrupt.Driver.dll"));
            object driverInstance = driverFile.CreateInstance("Roluan.Driver", true, BindingFlags.CreateInstance, null, null, null, null);
            if (driverInstance != null && (driverInstance is IRAMDriver) && (driverInstance as IInterruptDriver).Initialize(hardwareInstance))
            {
                //Board.Instance.Interrupt = (driverInstance as IInterruptDriver);
            }
            else
            {
                Console.Beep(800, 1000);
                Thread.Sleep(100);
                Console.Beep(800, 1000);
            }
        }

    }
}