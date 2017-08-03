using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace KWIC.Controllers
{
    public class NoiseWordEliminator
    {

        public string sentence;
        ArrayList noiseWords;


        public NoiseWordEliminator()
        {
            noiseWords = new ArrayList();
            setDefault();
        }

        public void addWord(string s)
        {
            noiseWords.Add(s);
        }

        public void setDefault()
        {
            noiseWords.Add("the ");
            noiseWords.Add("a ");

        }

        public string noiseWordEliminator(string s)
        {
            bool startsNW = false;
            foreach (string nw in noiseWords)
            {
                System.Diagnostics.Debug.WriteLine(s);
                System.Diagnostics.Debug.WriteLine(startsNW);
                if ((s.StartsWith(nw)))
                {
                    startsNW = true;
                }
            }
            if (!startsNW)
            {
               
                return s.Trim();
            }
            else
                return "";
        }

        /*public string noiseWordEliminatorFinal(string s)
        {
            string[] t = s.Split(' ');
            string output = "";
            foreach (string m in t)
            {
                //System.Diagnostics.Debug.WriteLine("work " + m);
                bool noise = false;
                foreach (string nw in noiseWords)
                {
                    if (m.Trim().ToLower().Equals(nw.Trim()))
                    {
                        noise = true;
                    }
                }
                if (!noise)
                {
                    output += m + " ";
                }
            }
            return output;
        }*/

        

        public string getNewSentence()
        {

            return sentence;
        }
    }
}