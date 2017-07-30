using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KWIC.Controllers
{
    public class CircularShift
    {

        string line;
        int numWords;

        string result;

        public CircularShift(string l, int nw)
        {
            //sets line and word count
            line = l.Trim();
            numWords = nw;

            //initalize
            setChar();
        }

        public void setChar() //creates shifted lines
        {
            result += line + "\n";
            if (line.Contains(" "))
            {
                for (int o = 0; o < numWords-1; o++)
                {
                    int place = line.IndexOf(" ");

                    string temp = line.Substring(0, place + 1).Trim();
                    System.Diagnostics.Debug.WriteLine(place);
                    line = line.Substring(place + 1) + " " + temp;
                    line.Trim();

                    result += line + "\n";

                }
            }
        }

        public int getWordCount() //returns number of words in shifted result
        {
            return (result.Split(' ')).Length;
        }

        public int getLineCount() //gets number of lines of shifted result
        {
            return (result.Split('\n')).Length;
        }

        public string getShifted() //returns shifted result
        {
            return result;
        }
    }
}