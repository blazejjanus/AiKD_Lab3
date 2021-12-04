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
        public string GetDictionary() {
            return dictionary.ToString();
        }
        private void GenKey() {
            dictionary.Sort();

        }
        private void CalcNode(char val1, char val2) {

        }
        //Właściwości

        //Pola
        private string text;
        private Dictionary dictionary;
        private Key key;
    }
}
