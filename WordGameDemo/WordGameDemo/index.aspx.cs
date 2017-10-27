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

            CreateNewGame(wordList);
        }

        public void CreateNewGame(List<Word> wordlist)
        {
            Random rnd = new Random();
            int r = rnd.Next(wordlist.Count);
            Word w = wordlist[r];
            HtmlGenericControl tileControl = new HtmlGenericControl();
            tileControl.TagName = "p";
            tileControl.Attributes["class"] = "tile";
            wordPanel.Controls.Add(tileControl);

        }
    }
}