using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiKD_Lab3 {
    public class Dictionary {
        private Dictionary() {
            symbols = new List<CharInfo>();
        }
        public Dictionary(string text) {
            CharInfo symbol;
            symbols = new List<CharInfo>();
            CharCount chc = new CharCount(text);
            List<char> temp_char = chc.Chars;
            List<int> temp_count = chc.Counts;
            for (int i = 0; i < chc.Size; i++) {
                symbol = new CharInfo(temp_char[i], temp_count[i]);
                symbols.Add(symbol);
            }
        }
        //Metody
        public void Add(char character, int count) {
            CharInfo symbol = new CharInfo(character, count);
            this.symbols.Add(symbol);
        }
        public void Add(CharInfo symbol) {
            this.symbols.Add(symbol);
        }
        private Dictionary Clone() {
            Dictionary result = new Dictionary();
            for(int i=0; i<symbols.Count; i++) {
                result.Add(this.symbols[i]);
            }
            return result;
        }
        //Sortowanie (w miejscu)
        public void Sort(SortOrder sort_order=SortOrder.DSC) {
            if (sort_order == SortOrder.ASC) {
                SortASC();
            } else {
                SortDSC();
            }
        }
        private void SortASC() {
            int n = this.symbols.Count();
            do {
                for (int i = 0; i < n - 1; i++) {
                    if (symbols[i].Count > symbols[i + 1].Count) {
                        Functions.SwapSymbols(symbols[i], symbols[i + 1]);
                    }
                }
                n--;
            } while (n > 1);
        }
        private void SortDSC() {
            int n = this.symbols.Count();
            do {
                for (int i = 0; i < n - 1; i++) {
                    if (symbols[i].Count < symbols[i + 1].Count) {
                        Functions.SwapSymbols(symbols[i], symbols[i + 1]);
                    }
                }
                n--;
            } while (n > 1);
        }
        //Sorotwanie (zwraca posortowaną kopię)
        public Dictionary SortCopy(SortOrder sort_order = SortOrder.DSC) {
            Dictionary result = this.Clone();
            if(sort_order == SortOrder.ASC) {
                SortCopyASC(result);
            } else {
                SortCopyDSC(result);
            }
            return result;
        }
        private void SortCopyASC(Dictionary result) {
            result.Sort(SortOrder.ASC);
        }
        private void SortCopyDSC(Dictionary result) {
            result.Sort(SortOrder.DSC);
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("\tZnak:\tLiczebność:\tKod:\n");
            for(int i = 0; i < this.symbols.Count; i++) {
                sb.Append(symbols[i].ToString());
            }
            return sb.ToString();
        }
        //Właściwości
        public List<CharInfo> Symbols {
            get { return this.symbols; }
        }
        //Pola
        List<CharInfo> symbols;
    }
}
