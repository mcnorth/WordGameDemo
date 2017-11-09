using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordGameDemo
{
    public class Anagrams
    {
        public Dictionary<string, List<Letter>> AnagramWords = new Dictionary<string, List<Letter>>();
        public string Word { get; set; }
        public List<Letter> LettersList { get; set; }

        public Anagrams(string word)
        {
            Word = word;
            LettersList = GetLetters(word);
            AnagramWords.Add(Word, LettersList);

        }

        private List<Letter> GetLetters(string word)
        {
            var letters = new List<Letter>();
            var letterArray = word.ToArray();

            foreach(var lett in letterArray)
            {
                Letter l = new Letter(lett);
                letters.Add(l);
            }

            return letters;
        }
    }
}