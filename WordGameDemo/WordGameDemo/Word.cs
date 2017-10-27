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

        public Word()
        {

        }
    }
}