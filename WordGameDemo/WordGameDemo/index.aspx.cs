using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI.HtmlControls;
using Newtonsoft.Json;

namespace WordGameDemo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = System.Web.HttpContext.Current.Server.MapPath("~/files/words.json");
            StreamReader rdr = new StreamReader(path);
            string json = rdr.ReadToEnd();

            var wordList = JsonConvert.DeserializeObject<List<Word>>(json);

            DisplayWord(wordList);
            
        }

        public void DisplayWord(List<Word> wordlist)
        {
            Random rnd = new Random();
            int r = rnd.Next(wordlist.Count);
            Word w = wordlist[r];
            

            var letterArray = w.Name.ToArray();
            var shuffledLetters = letterArray.OrderBy(x => rnd.Next()).ToArray();

            for(int i=0; i < shuffledLetters.Length; i++)
            {
                Button tileControl = new Button();
                tileControl.Attributes["class"] = "tile";
                tileControl.Attributes["id"] = shuffledLetters[i] + i.ToString();
                tileControl.Text = shuffledLetters[i].ToString().ToUpper();
                tileControl.Click += TileControl_Click;
                wordPanel.Controls.Add(tileControl);
                
            }

            DisplayAnswers(w);
        }

        private void TileControl_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void DisplayAnswers (Word w)
        {
            if(w.ThreeLetters.Count > 0)
            {
                HtmlGenericControl headingControl = new HtmlGenericControl();
                headingControl.TagName = "p";
                headingControl.Attributes["class"] = "aHeading";
                headingControl.InnerHtml = "Three Letter Words";
                answerPanel1.Controls.Add(headingControl);
               
                foreach (var word in w.ThreeLetters)
                {
                    var letterArray = word.ToArray();

                    for (int i = 0; i < letterArray.Length; i++)
                    {
                        HtmlGenericControl atileControl = new HtmlGenericControl();
                        atileControl.TagName = "p";
                        atileControl.Attributes["class"] = "ttile";
                        //tileControl.InnerText = letterArray[i].ToString().ToUpper();
                        answerPanel1.Controls.Add(atileControl);
                    }

                    answerPanel1.Controls.Add(new LiteralControl("<br />"));

                }

                
            }

            if (w.FourLetters.Count > 0)
            {
                HtmlGenericControl headingControl = new HtmlGenericControl();
                headingControl.TagName = "p";
                headingControl.Attributes["class"] = "aHeading";
                headingControl.InnerHtml = "Four Letter Words";
                answerPanel2.Controls.Add(headingControl);

                foreach (var word in w.FourLetters)
                {
                    var letterArray = word.ToArray();

                    for (int i = 0; i < letterArray.Length; i++)
                    {
                        HtmlGenericControl atileControl = new HtmlGenericControl();
                        atileControl.TagName = "p";
                        atileControl.Attributes["class"] = "ttile";
                        //tileControl.InnerText = letterArray[i].ToString().ToUpper();
                        answerPanel2.Controls.Add(atileControl);
                    }

                    answerPanel2.Controls.Add(new LiteralControl("<br />"));

                }
            }

            if (w.FiveLetters.Count > 0)
            {
                HtmlGenericControl headingControl = new HtmlGenericControl();
                headingControl.TagName = "p";
                headingControl.Attributes["class"] = "aHeading";
                headingControl.InnerHtml = "Five Letter Words";
                answerPanel3.Controls.Add(headingControl);

                foreach (var word in w.FiveLetters)
                {
                    var letterArray = word.ToArray();

                    for (int i = 0; i < letterArray.Length; i++)
                    {
                        HtmlGenericControl atileControl = new HtmlGenericControl();
                        atileControl.TagName = "p";
                        atileControl.Attributes["class"] = "ttile";
                        //tileControl.InnerText = letterArray[i].ToString().ToUpper();
                        answerPanel3.Controls.Add(atileControl);
                    }

                    answerPanel3.Controls.Add(new LiteralControl("<br />"));

                }
            }

            if (w.SixLetters.Count > 0)
            {
                HtmlGenericControl headingControl = new HtmlGenericControl();
                headingControl.TagName = "p";
                headingControl.Attributes["class"] = "aHeading";
                headingControl.InnerHtml = "Six Letter Words";
                answerPanel4.Controls.Add(headingControl);

                foreach (var word in w.SixLetters)
                {
                    var letterArray = word.ToArray();

                    for (int i = 0; i < letterArray.Length; i++)
                    {
                        HtmlGenericControl atileControl = new HtmlGenericControl();
                        atileControl.TagName = "p";
                        atileControl.Attributes["class"] = "ttile";
                        //tileControl.InnerText = letterArray[i].ToString().ToUpper();
                        answerPanel4.Controls.Add(atileControl);
                    }

                    answerPanel4.Controls.Add(new LiteralControl("<br />"));

                }
            }

            if (w.SevenLetters.Count > 0)
            {
                HtmlGenericControl topHeadingControl = new HtmlGenericControl();
                topHeadingControl.TagName = "p";
                topHeadingControl.Attributes["class"] = "aHeading";
                topHeadingControl.InnerHtml = "Seven Letter Words";
                nameWordPanel.Controls.Add(topHeadingControl);

                foreach (var word in w.SevenLetters)
                {
                    var letterArray = word.ToArray();

                    for (int i = 0; i < letterArray.Length; i++)
                    {
                        HtmlGenericControl topTileControl = new HtmlGenericControl();
                        topTileControl.TagName = "p";
                        topTileControl.Attributes["class"] = "toptile";
                        //tileControl.InnerText = letterArray[i].ToString().ToUpper();
                        nameWordPanel.Controls.Add(topTileControl);
                    }

                    nameWordPanel.Controls.Add(new LiteralControl("<br />"));

                }
            }

            for (int i = 0; i < 7; i++)
            {
                HtmlGenericControl guessTileControl = new HtmlGenericControl();
                guessTileControl.TagName = "p";
                guessTileControl.Attributes["class"] = "guesstile";
                //tileControl.InnerText = letterArray[i].ToString().ToUpper();
                guessPanel.Controls.Add(guessTileControl);
            }

            guessPanel.Controls.Add(new LiteralControl("<br />"));

        }

        
    }
}