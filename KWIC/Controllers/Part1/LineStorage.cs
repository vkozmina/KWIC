using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KWIC.Controllers
{
    public class LineStorage
    {
        //global
        string sentence;
        string[] lines;

        public LineStorage(string s)
        {
            //input
            sentence = s.Trim();

            //initialize
            setChar();
        }
        public void setChar() //initializes lines
        {
            //breaks by line
            lines = sentence.Split('\n');
            lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            
        }

        public int getWordCount(int l) //returns # of words in a line
        {
            //temp var
            string[] w;

            //splits line by spaces, then returns number of words
            w = lines[l - 1].Split(' ');
            return w.Count();
        }

        public int getLineCount() //returns number of lines
        {
            return lines.Length;
        }

        public string getLine(int i) //gets line i
        {
            return lines[i-1];
        }
    }
}