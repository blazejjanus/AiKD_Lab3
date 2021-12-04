using System;

namespace AiKD_Lab3 {
    class Program {
        static void Main(string[] args) {
            string str = "Ala ma kota, kot ma Ale.";
            CharCount chc = new CharCount(str);
            Console.WriteLine(chc.ToString());
            Huffman huffman = new Huffman(str);
            Console.WriteLine(huffman.GetDictionary());
        }
    }
}
