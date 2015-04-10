using Roluan.Common;
using Roluan.Common.Base;
using Roluan.Common.Enums;
using System.Collections.Generic;

namespace Roluan.Emulator.Board.Registers
{
    public class SymbolsRegister : RegisterBase
    {
        public SymbolsRegister()
        {
            this.Name = "SymbolsRegister";
            InitializeSymbolsTable();
        }

        private  void InitializeSymbolsTable()
        {
            Trit tn = new Trit() { State = TritState.Negative };
            Trit tp = new Trit() { State = TritState.Positive };

            // '!' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '"' 
            Trits.AddRange(new List<Trit>{tn,tp,tp,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '#' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tp,tp});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '$' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '%' 
            Trits.AddRange(new List<Trit>{tn,tp,tp,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '&' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tp,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // ''' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '(' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // ')' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '*' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tp,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tp,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // ',' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '-' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '.' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '/' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '0' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tp,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tp,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '1' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '2' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '3' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '4' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '5' 
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '6' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '7' 
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '8' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '9' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // ':' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // ';' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '<' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '=' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '>' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '?' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '@' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tp,tn,tn,tp,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tp,tn,tn,tp,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'A' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'B' 
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'C' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'D' 
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'E' 
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'F' 
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'G' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'H') 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'I' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'J' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'K' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'L' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'M' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tn,tn,tn,tn,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tp,tn,tn,tp,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'N' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tp,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'O' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'P' 
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'Q' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'R' 
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'S' 
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'T' 
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'U' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'V' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'W' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'X' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'Y' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'Z' 
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '['
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '\'
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // ']'
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '^'
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tp});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '_' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tp});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'a' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'b' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'c' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'd' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'e' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'f' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'g' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});

            // 'h' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'i' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'j' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});

            // 'k' 
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'l' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'm' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tn,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'n' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'o' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'p' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'q' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
           
            // 'r' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 's' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 't' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'u' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'v' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'w' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tp,tn,tp,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'x' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'y' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // 'z' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tp,tp,tp,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '{' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '|' 
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '}' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '~' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tn,tn,tn,tn,tp});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tp,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '«' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '·' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tp,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '»' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tp,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '—' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tp,tp,tp,tp,tp,tp,tp,tp});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '•' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tp,tp,tp,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tp,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '<' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});

            // '>' 
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tp,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tp,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tp,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tp,tn,tn,tn,tn,tn,tn,tn,tn});
            Trits.AddRange(new List<Trit>{tn,tn,tn,tn,tn,tn,tn,tn,tn});
        }
    }
}