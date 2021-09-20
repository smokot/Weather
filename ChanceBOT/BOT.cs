using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Leaf.xNet;
using Fizzler;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System.Collections;

namespace ChanceBOT
{
    class BOT
    {
        public string proxy;
        private StreamReader sw;
        private string response;
        private HtmlAgilityPack.HtmlDocument take;
        private List<int> numbers = new List<int>();
        public List<int> Team_A = new List<int>();
        public List<int> Team_B = new List<int>();
        
        ArrayList listerr = new ArrayList();
        
        public void LoadProxy(string path)
        {
            sw = new StreamReader(path);
            proxy = sw.ReadLine();
        }

        public void NextProxy()
        {
            proxy = sw.ReadLine();
        }


        public string ResponseByRequest(string way)
        {
            var test = new HttpRequest();
            response = test.Get(way).ToString();
            return response;
        }

        public ArrayList Load_HTML()
        {

            ArrayList lister = new ArrayList();
            take = new HtmlAgilityPack.HtmlDocument();
            take.LoadHtml(response);
            var time = take.DocumentNode.QuerySelector("time.time.fact__time");

            int count = 0;
            string temperature="";
            string feels_like = "";
            foreach (var item in take.DocumentNode.QuerySelectorAll("span.temp__value.temp__value_with-unit"))
            {                                                        

                if (count == 1)
                {
                    temperature = item.InnerText.ToString();
                    
                }
                if(count == 2)
                {
                    feels_like = item.InnerText.ToString();
                    break;
                }
                 count++;
            }


            var status = take.DocumentNode.QuerySelector("div.link__condition.day-anchor.i-bem");
            var wind_speed = take.DocumentNode.QuerySelector("span.wind-speed");
            var wind_side = take.DocumentNode.QuerySelector("span.fact__unit");

            string humidity="";
            string barmometr = "";

            count = 0;
            foreach (var item in take.DocumentNode.QuerySelectorAll("div.term__value"))
            {

                if(count == 3)
                {
                    humidity = item.InnerText.ToString();
                    
                }
                if (count == 4)
                {
                    barmometr = item.InnerText.ToString();
                    break;
                }
                count++;
            }

            string time_bottom_temp="";
            count = 0;

            foreach (var item in take.DocumentNode.QuerySelectorAll("div.fact__hour-label"))
            {
                if(count == 12)
                {
                    break;
                }
                time_bottom_temp+=item.InnerText.ToString()+",";
                count++;
            }





            string temp_bottom_temp = "";
            count = 0;

            foreach (var item in take.DocumentNode.QuerySelectorAll("div.fact__hour-temp"))
            {
                if (count == 12)
                {
                    break;
                }
                temp_bottom_temp+=item.InnerText.ToString()+",";
                count++;
            }



            lister.Add(time.InnerText.ToString());
            lister.Add(temperature);
            lister.Add(status.InnerText.ToString());
            lister.Add(feels_like);
            lister.Add(wind_speed.InnerText.ToString() + " "+ wind_side.InnerText.ToString());
            lister.Add(humidity);
            lister.Add(barmometr);
            lister.Add(time_bottom_temp);
            lister.Add(temp_bottom_temp);






            return lister;
           
        }

    }
}
