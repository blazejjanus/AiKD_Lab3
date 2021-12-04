using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiKD_Lab3 {
    public class CharInfo {
        public CharInfo(char symbol, int count) {
            this.symbol = symbol;
            this.count = count;
            this.code = null;
        }
        //Metody
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("\t");
            sb.Append(symbol);
            sb.Append("\t");
            sb.Append(count);
            sb.Append("\t");
            sb.Append(code);
            sb.Append("\n");
            return sb.ToString();
        }
        //Właściwości
        public char Symbol {
            get { return symbol; }
        }
        public int Count {
            get { return count; }
            set { count = value; }
        }
        public string Code {
            get { return code; }
            set { code = value; }
        }
        //Pola
        private char symbol;
        private int count;
        private string code;
    }
}
