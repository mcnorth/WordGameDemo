using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WordGameDemo
{
    public class Word
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sevenLetters")]
        public List<string> SevenLetters { get; set; }

        [JsonProperty("sixLetters")]
        public List<string> SixLetters { get; set; }

        [JsonProperty("fiveLetters")]
        public List<string> FiveLetters { get; set; }

        [JsonProperty("fourLetters")]
        public List<string> FourLetters { get; set; }

        [JsonProperty("threeLetters")]
        public List<string> ThreeLetters { get; set; }

        public List<Anagrams> ThreeLetterAnagrams { get; set; }
        public List<Anagrams> FourLetterAnagrams { get; set; }
        public List<Anagrams> FiveLetterAnagrams { get; set; }
        public List<Anagrams> SixLetterAnagrams { get; set; }
        public List<Anagrams> SevenLetterAnagrams { get; set; }
        public List<Letter> ShuffledWord { get; set; }

        public Word()
        {

        }

        public void GetAnagrams (Word w)
        {
            ThreeLetterAnagrams = new List<Anagrams>();
            FourLetterAnagrams = new List<Anagrams>();
            FiveLetterAnagrams = new List<Anagrams>();
            SixLetterAnagrams = new List<Anagrams>();
            SevenLetterAnagrams = new List<Anagrams>();

            foreach (var word in w.ThreeLetters)
            {
                Anagrams anagrams = new Anagrams(word);
                ThreeLetterAnagrams.Add(anagrams);
            }

            foreach (var word in w.FourLetters)
            {
                Anagrams anagrams = new Anagrams(word);
                FourLetterAnagrams.Add(anagrams);
            }

            foreach (var word in w.FiveLetters)
            {
                Anagrams anagrams = new Anagrams(word);
                FiveLetterAnagrams.Add(anagrams);
            }

            foreach (var word in w.SixLetters)
            {
                Anagrams anagrams = new Anagrams(word);
                SixLetterAnagrams.Add(anagrams);
            }

            foreach (var word in w.SevenLetters)
            {
                Anagrams anagrams = new Anagrams(word);
                SevenLetterAnagrams.Add(anagrams);
            }

        }

        public void GetShuffleLetters(Word w)
        {
            ShuffledWord = new List<Letter>();
            Random rnd = new Random();
            var letterArray = w.Name.ToArray();
            var sLetters = letterArray.OrderBy(x => rnd.Next()).ToArray();

            foreach(var letter in sLetters)
            {
                Letter l = new Letter(letter);
                ShuffledWord.Add(l);

            }
        }
    }
}