using System;
using System.Collections.Generic;

namespace AiKD_Lab3 {
    class Program {
        public static void Print(string s) {
            Console.WriteLine(s);
        }
        static void Main(string[] args) {
            string str = "Ala ma kota, kot ma Ale.";
            //string str = GenData();
            Console.WriteLine(str);
            Huffman huffman = new Huffman(str);
            Console.WriteLine(huffman.GetDictionary());
        }
        public static string GenData() {
            string str = null;
            str += GenData("f", 5);
            str += GenData("e", 9);
            str += GenData("c", 12);
            str += GenData("b", 13);
            str += GenData("d", 16);
            str += GenData("a", 45);
            return str;
        }
        public static string GenData(string source, int number) {
            string str = null;
            for (int i = 0; i < number; i++) {
                str += source;
            }
            return str;
        }
    }
}
