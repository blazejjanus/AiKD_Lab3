using System;

namespace AiKD_Lab3 {
    class Program {
        static void Main(string[] args) {
            string str = "Ala ma kota, kot ma Ale.";
            Dictionary d = new Dictionary(str);
            Console.WriteLine(d.ToString());
            Console.WriteLine();
            Console.WriteLine(d.SortCopy(SortOrder.ASC));
            Console.WriteLine();
            Console.WriteLine(d.SortCopy(SortOrder.DSC));
        }
    }
}
