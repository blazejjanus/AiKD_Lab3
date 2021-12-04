using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiKD_Lab3 {
    public class Key {
        public Key(List<char> character) {
            this.character = character;
            code = new List<string>(character.Count);
            SetupCodes();
        }
        //Metody
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("\tZnak:\tKod:\n");
            for (int i = 0; i < this.character.Count; i++) {
                sb.Append("\t");
                sb.Append(character[i]);
                sb.Append("\t");
                sb.Append(code[i]);
                sb.Append("\n");
            }
            return sb.ToString();
        }
        private void SetupCodes() {
            for(int i=0; i<code.Count; i++) {
                code[i] = null;
            }
        }
        public void UpdateKey(char element, int val) {
            int index;
            if (character.Contains(element) == true) {
                index = character.IndexOf(element);
                code[index] += val;
            } else {
                throw new Exception("Podana wartość nie występuje w słowniku!");
            }
        }
        //Pola
        List<char> character;
        List<string> code;
    }
}
