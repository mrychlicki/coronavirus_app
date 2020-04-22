using Newtonsoft.Json.Linq;
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
        public static string Deaths = "";
        public static string Recovered = "";


        public static void GetDataApi()
        {
            string adres = $"https://covid-19-coronavirus-statistics.p.rapidapi.com/v1/stats?country=" + Country;

            var client = new RestClient(adres);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "covid-19-coronavirus-statistics.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "d537f4674dmsh8eaba61cb9c9560p1d5a1ejsn85a89d3f2136");
            IRestResponse response = client.Execute(request);
            string data = response.Content;
            dynamic dataParse = JObject.Parse(data);
            var covid19Stats = dataParse.data.covid19Stats;
            Confirmed = covid19Stats[0].confirmed;
            Deaths = covid19Stats[0].deaths;
            Recovered = covid19Stats[0].recovered;
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
