using System;
using System.Collections.Generic;
using System.Text;

namespace PalabrasApp
{
    class WordOccurance
    {
        // word string keeps the word inside the file
        public string word { get; set; }
        // occurance integer keeps track of how many times the word is repeated 
        public int occurance { get; set; }

        public WordOccurance(string word, int occurance)
        {
            this.word = word;
            this.occurance = occurance;
        }
    }
}
