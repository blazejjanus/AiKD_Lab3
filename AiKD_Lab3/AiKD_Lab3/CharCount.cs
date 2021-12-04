using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiKD_Lab3 {
    public class CharCount {
        public CharCount(string str) {
            chars = new List<char>(0);
            counts = new List<int>(0);
            for(int i=0; i<str.Length; i++) {
                this.Add(str.ElementAt(i));
            }
        }
        private void Add(char val) {
            if (chars.Contains(val) == true) {
                int index = chars.IndexOf(val);
                counts[index]++;
            } else {
                chars.Add(val);
                counts.Add(1);
            }
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("\tZnak:\tLiczebność:\n");
            for (int i = 0; i < this.Size; i++) {
                sb.Append("\t");
                sb.Append(chars[i]);
                sb.Append("\t");
                sb.Append(counts[i]);
                sb.Append("\n");
            }
            return sb.ToString();
        }
        //Właściwości
        public List<char> Chars {
            get { return chars; }
        }
        public List<int> Counts {
            get { return counts; }
        }
        public int Size {
            get { return chars.Count; }
        }
        //Pola
        List<char> chars;
        List<int> counts;
    }
}
