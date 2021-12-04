﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiKD_Lab3 {
    public class Huffman {
        public Huffman(string text) {
            this.dictionary = new Dictionary(text);
            this.text = text;
            GenKey();
        }
        //Metody
        public string GetDictionary(bool sorted=false) {
            if(sorted == false) {
                return dictionary.ToString();
            } else {
                Dictionary sd = dictionary.SortCopy();
                return sd.ToString();
            }
        }
        private void GenKey() {
            dictionary.Sort(SortOrder.ASC);
            Dictionary temp = dictionary.Clone(); //Kopia robocza
            int size = dictionary.Size;
            CharInfo current, next;
            do {
                temp.Sort(SortOrder.ASC);
                //Console.WriteLine(temp);
                current = temp.Symbol(0);
                next = temp.Symbol(1);
                //Console.WriteLine("Current: " + current.Symbol + " Next: " + next.Symbol);
                if (current.Count < next.Count) {
                    dictionary.AddCode(current.Symbol, 0);
                    dictionary.AddCode(next.Symbol, 1);
                } else {
                    dictionary.AddCode(current.Symbol, 1);
                    dictionary.AddCode(next.Symbol, 0);
                }
                string temp_str = current.Symbol + next.Symbol;
                int temp_int = current.Count + next.Count;
                temp.Add(temp_str, temp_int);
                temp.Remove(current.Symbol);
                temp.Remove(next.Symbol);
            } while (temp.Size > 1);
            dictionary.FixCodes();
        }
        //Właściwości
        public int CompressedDataSize {
            get {
                int size = 0;
                List<CharInfo> lst = dictionary.Symbols;
                foreach(CharInfo var in lst) {
                    size += var.Code.Length;
                }
                return size * Consts.bit_size;
            }
        }
        public int SourceDataSize {
            get {
                int size = 0;
                size = text.Length;
                return size * Consts.char_size;
            }
        }
        //Pola
        private string text;
        private Dictionary dictionary;
    }
}
