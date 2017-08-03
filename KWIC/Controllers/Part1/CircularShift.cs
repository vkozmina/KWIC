using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace KWIC.Controllers
{
    public class CircularShift
    {

        string line;
        int numWords;
        ArrayList noiseWords = new ArrayList();

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
            //result += line + "\n";
            if (line.Contains(" "))
            {
                for (int o = 0; o < numWords; o++)
                {
                    
                    int place = line.IndexOf(" ");

                    string temp = line.Substring(0, place + 1).Trim();
                    
                    line = line.Substring(place + 1) + " " + temp;
                    line.Trim();

                    string t;

                    NoiseWordEliminator nw = new NoiseWordEliminator();
                    t = nw.noiseWordEliminator(line);
                    if (t.Length != 0)
                    {
                        result += t + "\n";
                    }

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
            return result.TrimEnd();
        }


    }
}