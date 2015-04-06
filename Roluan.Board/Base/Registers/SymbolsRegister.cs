using Roluan.Common;
using Roluan.Common.Base;
using Roluan.Common.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Roluan.Board.Registers
{
    public class SymbolsRegister : RegisterBase
    {
        public SymbolsRegister()
        {
            this.Name = "SymbolsRegister";
            InitializeSymbolsTable();
            //Task task = new Task(InitializeSymbolsTable));
            //task.Start());
        }

        private  void InitializeSymbolsTable()
        {
            //TODO: implement ASCII codes from excel
            Trit tn = new Trit() { State = TritState.Negative };
            Trit tp = new Trit() { State = TritState.Positive };
            //Trit tz = new Trit() { State = TritState.Zero };

            // '!' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '"' 
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '#' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '$' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '%' 
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '&' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // ''' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '(' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // ')' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '*' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // ',' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '-' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '.' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '/' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '0' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '1' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '2' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '3' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '4' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '5' 
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '6' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '7' 
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '8' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '9' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // ':' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // ');' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '<' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '=' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '>' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '?' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '@' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'A' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'B' 
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'C' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'D' 
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'E' 
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'F' 
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'G' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'H') 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'I' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'J' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'K' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'L' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'M' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'N' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'O' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'P' 
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'Q' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'R' 
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'S' 
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'T' 
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'U' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'V' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'W' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'X' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'Y' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'Z' 
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '[' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '\' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // ']' 
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // @0952 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '_' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'a' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'b' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'c' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'd' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'e' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'f' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'g' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'h' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'i' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'j' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'k' 
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'l' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'm' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'n' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'o' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'p' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'q' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'r' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 's' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 't' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'u' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'v' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'w' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'x' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'y' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // 'z' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '{' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '|' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '}' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '~' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '«' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '·' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '»' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '—' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '•' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '‹' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            // '›' 
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tp);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            
            
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            Trits.Add(tn);
            

        }
    }
}
