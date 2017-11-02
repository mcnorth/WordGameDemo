using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordGameDemo
{
    public class Letter
    {
        public char Element { get; set; }
        public string ID { get; set; }


        public Letter (char elem)
        {
            Element = elem;
            ID = "";
        }

    }



}