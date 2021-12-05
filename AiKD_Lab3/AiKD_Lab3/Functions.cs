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
                    if (is_file_binary(filename) == true) {
                        byte[] bytes = File.ReadAllBytes(filename);
                        StringBuilder sb = new StringBuilder();
                        foreach(byte b in bytes) {
                            sb.Append(b);
                        }
                        result = sb.ToString();
                    } else {
                        result = File.ReadAllText(filename);
                    }
                }
            }
            return result;
        }
        private static bool is_file_binary(string filename) {
            string ext = GetExtension(filename);
            if(ext == "bin") {
                return true;
            }
            if (ext == "exe") {
                return true;
            }
            if (ext == "msi") {
                return true;
            }
            if (ext == "dat") {
                return true;
            }
            return false;
        }
        private static string GetExtension(string filename) {
            string ext = null;
            for(int i=filename.Length-1; i>0; i--) {
                if (filename.ElementAt(i) == '.') {
                    break;
                } else {
                    ext += filename.ElementAt(i);
                }
            }
            ext = RotateString(ext);
            return ext;
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
        public static string RotateString(string source) {
            string result = null;
            for(int i = source.Length-1; i >= 0; i--) {
                result += source[i];
            }
            return result;
        }
    }
}
