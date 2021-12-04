using System;
using System.Collections.Generic;

namespace AiKD_Lab3 {
    class Program {
        public static class Options {
            public static bool use_file = false;
            public static bool known_example_data = true;
        }
        static void Main(string[] args) {
            string str = null;
            if (Options.use_file == false) {
                if (Options.known_example_data == false) {
                    str = "Ala ma kota, kot ma Ale.";
                } else {
                    str = GenData();
                }
            } else {

            }
            Console.WriteLine("Tekst źródłowy:");
            Console.Write(str);
            Console.WriteLine();
            Huffman huffman = new Huffman(str);
            Console.WriteLine("Lista symboli:");
            Console.WriteLine(huffman.GetDictionary());
            Console.WriteLine();
            int uncompressed_size = huffman.SourceDataSize;
            int compressed_size = huffman.CompressedDataSize;
            Console.WriteLine("Rozmiar przed skompresowaniem: " + uncompressed_size);
            Console.WriteLine("Rozmiar po skompresowaniu: " + compressed_size);
            double comp_ratio = uncompressed_size / compressed_size;
            Console.WriteLine("Współczynnik kompresji: " + comp_ratio);
            Console.WriteLine("% współczynnik kompresji: " + (1.0 - (1/comp_ratio))*100 + "%");
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
