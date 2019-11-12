using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace PortfolioManagement
{
    class api
    {
        public static string url1 = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol="; 
        public static string url2 = "&interval=1min&apikey=" + config.key;
        public static string getValue(string symbol)
        {
            using (var httpClient = new HttpClient())
            {
                var final_url = url1 + symbol + url2;
                var response = httpClient.GetStringAsync(new Uri(final_url)).Result;
                var index = response.IndexOf("1. open");
                Debug.WriteLine(final_url);
                if(index == -1)
                {
                    return "Not Found";
                }
                int x = index + 11;
                string str = "";
                while(response.ElementAt(x) != '"')
                {
                    str += response.ElementAt(x);
                    x++;
                }
                Debug.WriteLine(str);
                return str;
            }
        }
    }
}
