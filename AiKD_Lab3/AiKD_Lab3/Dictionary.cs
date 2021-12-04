using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiKD_Lab3 {
    public class Dictionary {
        private Dictionary() {
            character = new List<char>(0);
            count = new List<int>(0);
        }
        public Dictionary(string text) {
            character = new List<char>(0);
            count = new List<int>(0);
            //Dodawanie do list
            for(int i = 0; i < text.Length; i++) {
                UpdateDictionary(text.ElementAt(i));
            }
        }
        //Metody
        private void UpdateDictionary(char character) {
            int index = 0;
            if (this.character.Contains(character) == true) {
                index=this.character.IndexOf(character);
                this.count[index]++;
            } else {
                this.character.Add(character);
                this.count.Add(1);
            }
        }
        public void Add(char character, int count) {
            this.character.Add(character);
            this.count.Add(count);
        }
        private Dictionary Clone() {
            Dictionary result = new Dictionary();
            for(int i=0; i<character.Count; i++) {
                result.Add(this.character[i], this.count[i]);
            }
            return result;
        }
        //Sortowanie (w miejscu)
        public void Sort(SortOrder sort_order=SortOrder.DSC) {
            if (sort_order == SortOrder.ASC) {
                SortASC();
            } else {
                SortDSC();
            }
        }
        private void SortASC() {
            int n = this.character.Count();
            int temp_count;
            char temp_character;
            do {
                for(int i=0; i<n-1; i++) {
                    if(count[i] > count[i + 1]) {
                        temp_character = character[i];
                        character[i] = character[i + 1];
                        character[i + 1] = temp_character;
                        temp_count = count[i];
                        count[i] = count[i + 1];
                        count[i + 1] = temp_count;
                    }
                }
                n--;
            } while (n > 1);
        }
        private void SortDSC() {
            int n = this.character.Count();
            int temp_count;
            char temp_character;
            do {
                for (int i = 0; i < n - 1; i++) {
                    if (count[i] < count[i + 1]) {
                        temp_character = character[i];
                        character[i] = character[i + 1];
                        character[i + 1] = temp_character;
                        temp_count = count[i];
                        count[i] = count[i + 1];
                        count[i + 1] = temp_count;
                    }
                }
                n--;
            } while (n > 1);
        }
        //Sorotwanie (zwraca posortowaną kopię)
        public Dictionary SortCopy(SortOrder sort_order = SortOrder.DSC) {
            Dictionary result = this.Clone();
            if(sort_order == SortOrder.ASC) {
                SortCopyASC(result);
            } else {
                SortCopyDSC(result);
            }
            return result;
        }
        private void SortCopyASC(Dictionary result) {
            result.Sort(SortOrder.ASC);
        }
        private void SortCopyDSC(Dictionary result) {
            result.Sort(SortOrder.DSC);
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("\tZnak:\tLiczebność:\n");
            for(int i = 0; i < this.character.Count; i++) {
                sb.Append("\t");
                sb.Append(character[i]);
                sb.Append("\t");
                sb.Append(count[i]);
                sb.Append("\n");
            }
            return sb.ToString();
        }
        //Pola
        List<char> character;
        List<int> count;
    }
}
