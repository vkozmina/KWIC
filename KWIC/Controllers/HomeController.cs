using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KWIC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult KWIC_Part1()
        {
            ViewBag.Title = "KWIC";


            return View();
        }

        public ActionResult MyKWICAction(String sentence_Input)
        {
            var result = "";
            string[] sentence_input_split = sentence_Input.Split('\n');
            sentence_input_split = sentence_input_split.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            ArrayList sorted = new ArrayList();


            for (int i = 0; i < sentence_input_split.Length; i++)
            {
                if(!sentence_input_split[i].Trim().Contains(" "))
                {
                    sorted.Add(sentence_input_split[i] + "\n");
                }
                else
                {
                    for (int o = 0; o < sentence_input_split[i].Split(' ').Count(); o++)
                    {
                        int place = sentence_input_split[i].IndexOf(" ");
                        //sentence_input_split.
                        string temp = sentence_input_split[i].Substring(0, place + 1).Trim();
                        System.Diagnostics.Debug.WriteLine(place);
                        sentence_input_split[i] = sentence_input_split[i].Substring(place + 1) + " " + temp;
                        sentence_input_split[i].Trim();
                        //temp = temp.Trim();
                        //sentence_input_split[i] += " " + temp;
                        sorted.Add(sentence_input_split[i] + "\n");
                    }
                }
            }

            sorted.Sort();
            
            foreach(string s in sorted)
            {
                result += s;
            }

            result.Trim();

            return Content(result);
        }
    }
}
