using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace KWIC.Controllers
{
    public class Alphabetizer
    {
        //final result
        string result;

        //array of all lines
        ArrayList al = new ArrayList();

        public Alphabetizer(string c)
        {
            string [] a = c.Split('\n');

            //adds each line to array
            foreach (string s in a)
            {
                al.Add(s);
            }
        }

        public string getAlpha()
        {
            //sorts arraylist of lines
            al.Sort();

            //adds sorted array into result
            foreach(string s in al)
            {
                result += s + "\n";
            }

            //returns trimmed result
            return result.Trim();
        }

        public int getWordCount() //returns number of words in shifted result
        {
            return (result.Split(' ')).Length;
        }

        public int getLineCount() //gets number of lines of shifted result
        {
            return (result.Split('\n')).Length;
        }

    }
}