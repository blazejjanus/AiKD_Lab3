using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AiKD_Lab3 {

    static public partial class Functions {
        public static class DisplayFormat {
            public static string FixWidth(string source, int width) {
                string result = null;
                if (source.Length > width) {
                    throw new Exception("Source is longer than desired width!");
                }
                for(int i=0; i<(width-source.Length); i++) {
                    result += " ";
                }
                result += source;
                return result;
            }

            public static string FixWidth(int source, int width) {
                string result = null;
                string temp = source.ToString();
                if (temp.Length > width) {
                    throw new Exception("Source is longer than desired width!");
                }
                for (int i = 0; i < (width - temp.Length); i++) {
                    result += " ";
                }
                result += temp;
                return result;
            }

            public static string FixWidth(double source, int width) {
                string result = null;
                string temp = source.ToString();
                if (temp.Length > width) {
                    throw new Exception("Source is longer than desired width!");
                }
                for (int i = 0; i < (width - temp.Length); i++) {
                    result += " ";
                }
                result += temp;
                return result;
            }

            static public void Error(string message) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            static public void Warning(string message) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            static public void Info(string message) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
