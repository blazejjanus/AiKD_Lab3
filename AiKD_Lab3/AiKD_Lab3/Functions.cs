using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace AiKD_Lab3 {
    public static partial class Functions {
        public static string GetText(string filename) {
            string result = null;
            if (filename == null) {
                result = Input.StringValue("teks źródłowy:");
            } else {
                if (File.Exists(filename) == false) {
                    throw new Exception("Podaj poprawną ścieżkę pliku źródłowego!");
                } else {
                    result = File.ReadAllText(filename);
                }
            }
            return result;
        }
        public static void SwapSymbols(ref CharInfo val1, ref CharInfo val2) {
            CharInfo temp_var;
            temp_var = val1;
            val1 = val2;
            val2 = temp_var;
        }
        public static string ShortNumbers(string source) {
            string regex = "^0+(?!$)";
            return Regex.Replace(source, regex, "");
        }
    }
}
