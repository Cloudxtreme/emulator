using Roluan.Common;
using Roluan.Common.Base;
using Roluan.Common.Enums;
using Roluan.Common.Interfaces;
using Roluan.Keyboard.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Roluan
{
    public class Driver : IKeyboardDriver
    {
        public bool Initialize(IKeyboardHardware hardwareInstance)
        {
            try
            {
                Task task = new Task(InitializeKeys);
                task.Start();
                KeyboardRegister.Instance = new KeyboardRegister();
                KeyboardRegister.Instance.Name = "Keyboard";
                KeyboardRegister.Instance.Trits.Add(new Trit());
                this.Instance = KeyboardRegister.Instance;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public RegisterBase Instance { get; set; }

        public List<List<Trit>> Keys { get; set; }

        public async void InitializeKeys()
        {
            var result = new List<List<Trit>>();
            List<Trit> lt = null;
            Trit tn = new Trit() { State = TritState.Negative };
            Trit tp = new Trit() { State = TritState.Positive };
            Trit tz = new Trit() { State = TritState.Zero };

            // A 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // A shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // A Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // A Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // B 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // B shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // B Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // B Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // C 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // C shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // C Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // C Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // D 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // D shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // D Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // D Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // E 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // E shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // E Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // E Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // F 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // F shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // F Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // F Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // G 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // G shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // G Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // G Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // H 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // H shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // H Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // H Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // I 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // I shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // I Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // I Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // J 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // J shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // J Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // J Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // K 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // K shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // K Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // K Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // L 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // L shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // L Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // L Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // M 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // M shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // M Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // M Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // N 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // N shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // N Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // N Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // O 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // O shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // O Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // O Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // P 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // P shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // P Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // P Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Q 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // Q shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Q Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Q Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // R 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // R shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // R Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // R Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // S 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // S shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // S Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // S Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // T 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // T shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // T Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // T Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // U 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // U shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // U Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // U Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // V 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // V shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // V Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // V Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // W 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // W shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // W Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // W Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // X 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // X shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // X Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // X Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // Y 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Y shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Y Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // Y Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Z 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // Z shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Z Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Z Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // 1 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // 1 shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // 1 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // 1 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // 2 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // 2 shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // 2 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // 2 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // 3 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // 3 shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // 3 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // 3 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // 4 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // 4 shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // 4 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // 4 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // 5 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // 5 shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // 5 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // 5 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // 6 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // 6 shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // 6 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // 6 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // 7 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // 7 shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // 7 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // 7 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // 8 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // 8 shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // 8 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // 8 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // 9 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // 9 shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // 9 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // 9 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // 0 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // 0 shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // 0 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // 0 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // - 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // - shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // - Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // - Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // = 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // = shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // = Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // = Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // [ 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // [ shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // [ Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // [ Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // ] 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // ] shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // ] Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // ] Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // ; 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // ; shifted 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // ; Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // ; Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // ' 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // ' shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // ' Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // ' Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // ` 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // ` shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // ` Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // ` Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // \ 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // \ shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // \ Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // \ Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // , 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // , shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // , Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // , Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // . 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // . shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // . Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // . Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // / 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // / shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // / Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // / Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // F1 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // F1 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // F1 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // F1 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // F2 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // F2 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // F2 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // F2 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // F3 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // F3 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // F3 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // F3 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // F4 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // F4 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // F4 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // F4 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // F5 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // F5 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // F5 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // F5 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // F6 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // F6 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // F6 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // F6 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // F7 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // F7 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // F7 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // F7 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // F8 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // F8 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // F8 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // F8 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // F9 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // F9 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // F9 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // F9 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // F10 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // F10 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // F10 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // F10 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // F11 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // F11 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // F11 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // F11 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // F12 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // F12 shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // F12 Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // F12 Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // Back Space 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Back Space shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // Back Space Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Back Space Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // Del 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Del shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Del Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // Del Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Down Arrow 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // Down Arrow shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Down Arrow Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Down Arrow Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // End 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // End shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // End Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // End Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Enter 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // Enter shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // Enter Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // Enter Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Esc 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // Esc shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // Esc Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // Esc Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // Home 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // Home shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // Home Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // Home Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // Ins 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Ins shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // Ins Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // Ins Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // Keypad-(5) 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // Keypad-(5) shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Keypad-(5) Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // Keypad-(5) Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // Keypad-(*) 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Keypad-(*) shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // Keypad-(*) Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Keypad-(*) Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // Keypad-(-) 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Keypad-(-) shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Keypad-(-) Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // Keypad-(-) Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Keypad-(+) 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // Keypad-(+) shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Keypad-(+) Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Keypad-(+) Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // Keypad-(/) 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // Keypad-(/) shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // Keypad-(/) Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Keypad-(/) Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Left Arrow 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // Left Arrow shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // Left Arrow Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // Left Arrow Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Pg Dn 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // Pg Dn shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // Pg Dn Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // Pg Dn Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // Pg Up 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // Pg Up shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // Pg Up Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // Pg Up Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            result.Add(lt);
            // Prt Sc 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Prt Sc shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // Prt Sc Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // Prt Sc Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tp);
            result.Add(lt);
            // Right Arrow 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // Right Arrow shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Right Arrow Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // Right Arrow Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tn);
            result.Add(lt);
            // Space Bar 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Space Bar shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // Space Bar Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Space Bar Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tz);
            result.Add(lt);
            // Tab 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Tab shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Tab Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            // Tab Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            lt.Add(tp);
            result.Add(lt);
            // Up Arrow 
            lt = new List<Trit>();
            lt.Add(tz);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            result.Add(lt);
            // Up Arrow shifted 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tn);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tp);
            result.Add(lt);
            // Up Arrow Ctrl 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tz);
            result.Add(lt);
            // Up Arrow Alt 
            lt = new List<Trit>();
            lt.Add(tp);
            lt.Add(tp);
            lt.Add(tz);
            lt.Add(tz);
            lt.Add(tn);
            lt.Add(tn);
            result.Add(lt);
            this.Keys = result;
        }
    }
}
