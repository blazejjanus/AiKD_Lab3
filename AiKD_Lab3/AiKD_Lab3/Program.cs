using System;
using System.Collections.Generic;

namespace AiKD_Lab3 {
    class Program {
        public static void Print(string s) {
            Console.WriteLine(s);
        }
        static void Main(string[] args) {
            string str = "Ala ma kota, kot ma Ale.";
            //CharCount chc = new CharCount(str);
            //Console.WriteLine(chc.ToString());
            Huffman huffman = new Huffman(str);
            Console.WriteLine(huffman.GetDictionary());
            Console.WriteLine();
            Console.WriteLine(huffman.GetDictionary(true));
            Dictionary d = new Dictionary(str);
            Console.WriteLine(d);
            List<string> lst = d.Values();
            
        }
    }
}
