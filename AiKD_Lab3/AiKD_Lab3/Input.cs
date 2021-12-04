using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AiKD_Lab3 {
    static public partial class Functions {
        static public class Input {
            static public string Path(string message = "", bool ignore_check = false) {
                string path = null;
                bool is_good = false;
                Console.WriteLine("Podaj ścieżkę " + message);
                do {
                    path = Console.ReadLine();
                    path = path.Trim(); //Usuwamy białe znaki z początku i końca
                    path = path.Trim('\"'); //Usuwamy dodawane przy kopiowaniu ścieżki cudzysłowy z początku i końca
                    path = path.ToLower(); //Windows ignoruje wielkość znaków
                    if (Directory.Exists(path) == true) {
                        is_good = true;
                    } else {
                        if (File.Exists(path) == true) {
                            is_good = true;
                        } else {
                            is_good = false;
                            DisplayFormat.Error("Błędna ścieżka!");
                            Console.WriteLine("Podaj poprawną ścieżkę:");
                        }
                    }
                } while (is_good == false || ignore_check == true);
                return path;
            }
            static public string FilePath(string message = "", bool search_in_folder = false) {
                string path = null;
                bool is_good = false;
                Console.WriteLine("Podaj ścieżkę " + message);
                do {
                    path = Console.ReadLine();
                    path = path.Trim(); //Usuwamy białe znaki z początku i końca
                    path = path.Trim('\"'); //Usuwamy dodawane przy kopiowaniu ścieżki cudzysłowy z początku i końca
                    path = path.ToLower(); //Windows ignoruje wielkość znaków
                    if (File.Exists(path) == false) {
                        if (Directory.Exists(path) == false) {
                            is_good = false;
                            DisplayFormat.Error("Błędna ścieżka!");
                            Console.WriteLine("Podaj poprawną ścieżkę:");
                        } else {
                            if (search_in_folder == true) {
                                if (File.Exists(path + "\\7z.exe")) {
                                    path += "\\7z.exe";
                                    is_good = true;
                                } else {
                                    is_good = false;
                                    DisplayFormat.Error("Podaj ścieżkę do pliku wykonywalnego, a nie do folderu!");
                                }
                            }
                        }
                    } else {
                        is_good = true;
                    }
                } while (is_good == false);
                return path;
            }
            static public string DirPath(string message = "") {
                string path = null;
                bool is_good = false;
                Console.WriteLine("Podaj ścieżkę " + message);
                do {
                    path = Console.ReadLine();
                    path = path.Trim(); //Usuwamy białe znaki z początku i końca
                    path = path.Trim('\"'); //Usuwamy dodawane przy kopiowaniu ścieżki cudzysłowy z początku i końca
                    path = path.ToLower(); //Windows ignoruje wielkość znaków
                    if (Directory.Exists(path) == false) {
                        is_good = false;
                        DisplayFormat.Error("Błędna ścieżka!");
                        Console.WriteLine("Podaj poprawną ścieżkę:");
                    } else {
                        is_good = true;
                    }
                } while (is_good == false);
                return path;
            }
            static public string StringValue(string message, List<string> Possibilities) {
                int i = 1;
                bool is_good = false;
                Console.WriteLine("Wybierz " + message);
                foreach(string Possibility in Possibilities) {
                    Console.WriteLine("\t" + i + ". " + Possibility);
                    i++;
                }
                int choosen = 0;
                string response = null;
                do {
                    is_good = true;
                    response = Console.ReadLine();
                    response = response.Trim();
                    if (Int32.TryParse(response, out choosen) == false) {
                        Functions.DisplayFormat.Error("Podaj poprawną wartość!");
                        is_good = false;
                    }
                    if (choosen > i || choosen < 1) {
                        is_good = false;
                    }
                } while (is_good == false);
                return Possibilities[choosen - 1];
            }
            static public double DoubleValue(string message, List<double> Possibilities) {
                int i = 1;
                bool is_good = false;
                Console.WriteLine("Wybierz " + message);
                foreach (double Possibility in Possibilities) {
                    Console.WriteLine("\t" + i + ". " + Possibility);
                    i++;
                }
                int choosen = 0;
                string response = null;
                do {
                    is_good = true;
                    response = Console.ReadLine();
                    response = response.Trim();
                    if (Int32.TryParse(response, out choosen) == false) {
                        Functions.DisplayFormat.Error("Podaj poprawną wartość!");
                        is_good = false;
                    }
                    if (choosen > i || choosen < 1) {
                        is_good = false;
                    }
                } while (is_good == false);
                return Possibilities[choosen - 1];
            }
            static public int IntValue(string message, List<int> Possibilities) {
                int i = 1;
                bool is_good = false;
                Console.WriteLine("Wybierz " + message);
                foreach (int Possibility in Possibilities) {
                    Console.WriteLine("\t" + i + ". " + Possibility);
                    i++;
                }
                int choosen = 0;
                string response = null;
                do {
                    is_good = true;
                    response = Console.ReadLine();
                    response = response.Trim();
                    if(Int32.TryParse(response, out choosen) == false) {
                        Functions.DisplayFormat.Error("Podaj poprawną wartość!");
                        is_good = false;
                    }
                    if (choosen > i || choosen < 1) {
                        is_good = false;
                    }
                } while (is_good == false);
                return Possibilities[choosen-1];
            }
            static public string StringValue(string message) {
                Console.WriteLine("Wybierz " + message);
                string response = null;
                response = Console.ReadLine();
                response = response.Trim();
                return response;
            }
            static public double DoubleValue(string message) {
                bool is_good = false;
                Console.WriteLine("Wybierz " + message);
                string response = null;
                double result;
                do {
                    is_good = true;
                    response = Console.ReadLine();
                    response = response.Trim();
                    if (Double.TryParse(response, out result) == false) {
                        Functions.DisplayFormat.Error("Podaj poprawną wartość!");
                        is_good = false;
                    }
                } while (is_good == false);
                return result;
            }
            static public int IntValue(string message) {
                bool is_good = false;
                Console.WriteLine("Wybierz " + message);
                int result;
                string response = null;
                do {
                    is_good = true;
                    response = Console.ReadLine();
                    response = response.Trim();
                    if (Int32.TryParse(response, out result) == false) {
                        Functions.DisplayFormat.Error("Podaj poprawną wartość!");
                        is_good = false;
                    }
                } while (is_good == false);
                return result;
            }
        }
    }
}
