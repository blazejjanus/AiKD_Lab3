using System;
using System.Collections.Generic;

namespace AiKD_Lab3 {
    class Program {
        public static class Options {
            public static bool use_file = true;
            public static bool known_example_data = true;
            public static bool use_static_example = false;
            public static bool use_static_file = true;
        }
        static void Main(string[] args) {
            string str = null;
            string filename = null;
            if (Options.use_file == false) {
                if (Options.known_example_data == false) {
                    if(Options.use_static_example == true) {
                        str = "Ala ma kota, kot ma Ale.";
                    } else {
                        str = Functions.GetText(null);
                    }
                } else {
                    str = GenData();
                }
            } else {
                if (Options.use_static_file == true) {
                    filename = "";
                } else {
                    filename = Functions.Input.FilePath("nazwę pliku:");
                }
                str = Functions.GetText(filename);
            }
            Console.WriteLine("Tekst źródłowy:");
            Functions.DisplayFormat.Info(str);
            Console.WriteLine();
            Huffman huffman = new Huffman(str);
            Console.WriteLine("Lista symboli:");
            Console.WriteLine(huffman.GetDictionary());
            Console.WriteLine();
            Console.WriteLine("Tekst zakodowany:");
            Functions.DisplayFormat.Info(huffman.Encode());
            int uncompressed_size = huffman.SourceDataSize;
            int compressed_size = huffman.CompressedDataSize;
            Console.WriteLine("Rozmiar przed skompresowaniem:\t\t\t\t\t\t" + uncompressed_size+"bit");
            Console.WriteLine("Rozmiar po skompresowaniu:\t\t\t\t\t\t" + compressed_size+"bit");
            double comp_ratio = uncompressed_size / compressed_size;
            Console.WriteLine("Średnia liczba bitów na skompresowanej reprezentacji danych na znak:\t"+huffman.BitRatio);
            Console.WriteLine("Współczynnik kompresji:\t\t\t\t\t\t\t" + comp_ratio);
            Console.WriteLine("% współczynnik kompresji:\t\t\t\t\t\t" + Math.Round((1.0 - (1/comp_ratio))*100, 2) + "%");
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
