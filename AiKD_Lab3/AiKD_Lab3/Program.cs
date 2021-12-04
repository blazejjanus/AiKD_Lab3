using System;
using System.Collections.Generic;

namespace AiKD_Lab3 {
    class Program {
        public static void Print(string s) {
            Console.WriteLine(s);
        }
        static void Main(string[] args) {
            string str = "Alamakota,kotmaAle.";
            Huffman huffman = new Huffman(str);
            Console.WriteLine(huffman.GetDictionary());
            char c1 = ' ';
            string str1 = null;
            str1 += c1;
            str1 += "abc";
            Console.WriteLine(str1);
        }
    }
}
