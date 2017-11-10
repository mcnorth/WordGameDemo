using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordGameDemo
{
    public class SessionWord
    {
        private const string SessionName = "gameData";
        private Word GameWord;

        public Word gameWord
        {
            get { return GameWord; }
            set { GameWord = value; Save(); }
        }

        public SessionWord()
        {
            InitialiseSessionObject();
        }

        private void InitialiseSessionObject()
        {
            SessionWord sWord = (SessionWord)HttpContext.Current.Session[SessionName];
            this.gameWord = sWord.gameWord;
            
        }

        private void Save()
        {
            //save object
            HttpContext.Current.Session[SessionName] = this;
        }
    }
}