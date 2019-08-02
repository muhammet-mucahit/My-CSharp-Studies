using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class Translator
    {
        private Dictionary<string, string> dict = new Dictionary<string, string>();

        public Translator()
        {
            dict.Add("I", "BEN");
            dict.Add("LIKE", "SEVMEK");
            dict.Add("AND", "VE");
            dict.Add("OR", "VEYA");
            dict.Add("BEER", "BIRA");
            dict.Add("WHISKEY", "VISKI");
            dict.Add("CHIPS", "CIPS");
        }

        public string Translate(string sentence)
        {
            string[] words = sentence.ToUpper().Split('.');
            string[] translated = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
                translated[i] = dict[words[i]];

            return String.Join(".", translated);
        }
    }
}
