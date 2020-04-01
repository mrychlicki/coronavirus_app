using RestSharp;
using RestSharp.Serialization.Xml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coronavirus_App
{
    class GetData
    {
        public static string Country = "";

        public static string Confirmed = "";
        public static string deaths = "";
        public static string recovered = "";


        public static void GetDataApi()
        {
            string adres = $"https://covid-19-coronavirus-statistics.p.rapidapi.com/v1/stats?country=" + Country;

            var client = new RestClient(adres);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "covid-19-coronavirus-statistics.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "d537f4674dmsh8eaba61cb9c9560p1d5a1ejsn85a89d3f2136");
            IRestResponse response = client.Execute(request);
            client.UseDotNetXmlSerializer();

            string[] test = response.Content.Split(',');

            foreach (string item in test)
            {
                if (item.Contains("confirmed"))
                {
                    Confirmed = item.Split(":")[1];
                }
                if (item.Contains("deaths"))
                {
                    deaths= item.Split(":")[1];
                }
                if (item.Contains("recovered"))
                {
                    recovered= item.Split(":")[1].Substring(0,item.Split(":")[1].Length-4);
                }


            }
        }

        public static void ChangeToEnglish(string country_)
        {
            if (country_.Contains( "Polska"))
            {
                Country = "Poland";
            }
            if (country_.Contains("Włochy"))
            {
                Country = "Italy";
            }
            if (country_.Contains("Niemcy"))
            {
                Country = "Germany";
            }
            if (country_.Contains("Anglia"))
            {
                Country = "United Kingdom";
            }
            if (country_.Contains("Francja"))
            {
                Country = "France";
            }
            if (country_.Contains("Hiszpania"))
            {
                Country = "Spain";
            }
            if (country_.Contains("Portugalia"))
            {
                Country = "Portugal";
            }
            if (country_.Contains("Chiny"))
            {
                Country = "China";
            }
            if (country_.Contains("Chiny"))
            {
                Country = "China";
            }
        }
    }
}
