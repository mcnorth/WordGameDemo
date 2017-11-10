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
            if (!IsPostBack)
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/files/words.json");
                StreamReader rdr = new StreamReader(path);
                string json = rdr.ReadToEnd();

                var wordList = JsonConvert.DeserializeObject<List<Word>>(json);

                DisplayWord(wordList);
            }
            else
            {
                //get data from session obj
                Word sessionData = (Word)Session["word"];
                DisplaySavedWord(sessionData);
            }




        }

        public void DisplayWord(List<Word> wordlist)
        {
            Random rnd = new Random();
            int r = rnd.Next(wordlist.Count);
            Word w = wordlist[r];
            Session["word"] = w;
            w.GetAnagrams(w);
            w.GetShuffleLetters(w);

            t1.Text = w.ShuffledWord[0].Element.ToString();
            t2.Text = w.ShuffledWord[1].Element.ToString();
            t3.Text = w.ShuffledWord[2].Element.ToString();
            t4.Text = w.ShuffledWord[3].Element.ToString();
            t5.Text = w.ShuffledWord[4].Element.ToString();
            t6.Text = w.ShuffledWord[5].Element.ToString();
            t7.Text = w.ShuffledWord[6].Element.ToString();

            //for(int i=0; i < w.ShuffledWord.Count; i++)
            //{
            //    var tile = w.ShuffledWord[i];
            //    var id = w.ShuffledWord[i].Element + i.ToString();
            //    Button tileControl = new Button();
            //    tileControl.Attributes["class"] = "tile";
            //    tileControl.Attributes["id"] = id;
            //    tileControl.Text = tile.Element.ToString().ToUpper();
            //    tileControl.Click += TileControl_Click;
            //    wordPanel.Controls.Add(tileControl);
            //    tile.ID = id;

            //}


            DisplayAnswers(w);
        }

        public void DisplaySavedWord(Word w)
        {
            t1.Text = w.ShuffledWord[0].Element.ToString();
            t2.Text = w.ShuffledWord[1].Element.ToString();
            t3.Text = w.ShuffledWord[2].Element.ToString();
            t4.Text = w.ShuffledWord[3].Element.ToString();
            t5.Text = w.ShuffledWord[4].Element.ToString();
            t6.Text = w.ShuffledWord[5].Element.ToString();
            t7.Text = w.ShuffledWord[6].Element.ToString();
        }

        

        public void TileControl1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnId = btn.ID;

            if(g1.Text == "")
            {
                g1.Text = btn.Text;
                btn.Enabled = false;
                btn.Visible = false;
                
            }
            else if(g2.Text == "")
            {
                g2.Text = btn.Text;
                btn.Enabled = false;
                btn.Visible = false;

            }
            else if (g3.Text == "")
            {
                g3.Text = btn.Text;
                btn.Enabled = false;
                btn.Visible = false;

            }
            else if (g4.Text == "")
            {
                g4.Text = btn.Text;
                btn.Enabled = false;
                btn.Visible = false;

            }
            else if (g5.Text == "")
            {
                g5.Text = btn.Text;
                btn.Enabled = false;
                btn.Visible = false;

            }
            else if (g6.Text == "")
            {
                g6.Text = btn.Text;
                btn.Enabled = false;
                btn.Visible = false;

            }
            else if (g7.Text == "")
            {
                g7.Text = btn.Text;
                btn.Enabled = false;
                btn.Visible = false;

            }

        }

        public void DisplayAnswers (Word w)
        {
            if(w.ThreeLetterAnagrams.Count > 0)
            {
                HtmlGenericControl headingControl = new HtmlGenericControl();
                headingControl.TagName = "p";
                headingControl.Attributes["class"] = "aHeading";
                headingControl.InnerHtml = "Three Letter Words";
                answerPanel1.Controls.Add(headingControl);

                foreach (var word in w.ThreeLetterAnagrams)
                {
                    foreach(var letter in word.LettersList)
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

            if (w.FourLetterAnagrams.Count > 0)
            {
                HtmlGenericControl headingControl = new HtmlGenericControl();
                headingControl.TagName = "p";
                headingControl.Attributes["class"] = "aHeading";
                headingControl.InnerHtml = "Four Letter Words";
                answerPanel2.Controls.Add(headingControl);

                foreach (var word in w.FourLetterAnagrams)
                {
                    foreach(var letter in word.LettersList)
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

            if (w.FiveLetterAnagrams.Count > 0)
            {
                HtmlGenericControl headingControl = new HtmlGenericControl();
                headingControl.TagName = "p";
                headingControl.Attributes["class"] = "aHeading";
                headingControl.InnerHtml = "Five Letter Words";
                answerPanel3.Controls.Add(headingControl);

                foreach (var word in w.FiveLetterAnagrams)
                {
                    foreach(var letter in word.LettersList)
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

            if (w.SixLetterAnagrams.Count > 0)
            {
                HtmlGenericControl headingControl = new HtmlGenericControl();
                headingControl.TagName = "p";
                headingControl.Attributes["class"] = "aHeading";
                headingControl.InnerHtml = "Six Letter Words";
                answerPanel4.Controls.Add(headingControl);

                foreach (var word in w.SixLetterAnagrams)
                {
                    foreach(var letter in word.LettersList)
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

            if (w.SevenLetterAnagrams.Count > 0)
            {
                HtmlGenericControl topHeadingControl = new HtmlGenericControl();
                topHeadingControl.TagName = "p";
                topHeadingControl.Attributes["class"] = "aHeading";
                topHeadingControl.InnerHtml = "Seven Letter Words";
                nameWordPanel.Controls.Add(topHeadingControl);

                foreach (var word in w.SevenLetterAnagrams)
                {
                    foreach(var letter in word.LettersList)
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

           

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            g1.Text = "";
            g2.Text = "";
            g3.Text = "";
            g4.Text = "";
            g5.Text = "";
            g6.Text = "";
            g7.Text = "";
        }

        protected void btnGuess_Click(object sender, EventArgs e)
        {

        }
    }
}