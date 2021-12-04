using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiKD_Lab3 {
    public class Huffman {
        public Huffman(string text) {
            this.dictionary = new Dictionary(text);
            this.text = text;
            GenKey();
        }
        //Metody
        public string GetDictionary(bool sorted=false) {
            if(sorted == false) {
                return dictionary.ToString();
            } else {
                Dictionary sd = dictionary.SortCopy();
                return sd.ToString();
            }
        }
        private void GenKey() {
            dictionary.Sort(SortOrder.ASC);
            Dictionary temp = dictionary.Clone(); //Kopia robocza
            int size = dictionary.Size;
            CharInfo current, next;
            int i = 0;
            do {
                temp.Sort(SortOrder.ASC);
                Console.WriteLine(temp);
                current = temp.Symbol(0);
                next = temp.Symbol(1);
                Console.WriteLine("Current: " + current.Symbol + " Next: " + next.Symbol);
                if (current.Count < next.Count) {
                    dictionary.AddCode(current.Symbol, 0);
                    dictionary.AddCode(next.Symbol, 1);
                } else {
                    dictionary.AddCode(current.Symbol, 1);
                    dictionary.AddCode(next.Symbol, 0);
                }
                string temp_str = current.Symbol + next.Symbol;
                int temp_int = current.Count + next.Count;
                temp.Add(temp_str, temp_int);
                temp.Remove(current.Symbol);
                temp.Remove(next.Symbol);
                i++;
            } while (temp.Size - i >= 0);
        }
        private void CalcNode(char val1, char val2) {

        }
        //Właściwości

        //Pola
        private string text;
        private Dictionary dictionary;
    }
}
