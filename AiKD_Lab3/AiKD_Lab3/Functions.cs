using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        
    }
}
