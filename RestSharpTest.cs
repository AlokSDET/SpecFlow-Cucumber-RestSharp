using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Serialization.Json;

namespace SpecFlowProject
{
    /// <summary>
    /// Summary description for RestSharpTest
    /// </summary>
    [TestClass]
    public class RestSharpTest : Exception
    {
        [TestMethod]
        public void TestMethod1()
        {
            RestClient restClient = new RestClient("http://api.zippopotam.us/us/90210");

            RestRequest restRequest = new RestRequest(Method.GET);

            restRequest.AddHeader("content-type", "application/json");

            restRequest.AddHeader("Accept", "application/json");

            IRestResponse response1 = restClient.Execute(restRequest);

          
            var deserilize = new JsonDeserializer();

            Dictionary<String, Object> output = deserilize.Deserialize<Dictionary<String, Object>>(response1);

            var country = output["country"];
            var places = output["places"];

           // Console.WriteLine(country);
          //  Console.WriteLine(places);

            object test;
            if (output.TryGetValue("places", out test)) // Returns true.
            {
                Console.WriteLine(test); // This is the value at key1.
            }

            JObject obs = JObject.Parse(response1.Content);
            var places1 = obs.Last;

            Console.WriteLine(places1);

            Console.WriteLine(obs["places"].First["place name"]);
            Console.WriteLine(obs["places"].First["longitude"]);
            Console.WriteLine(obs["places"].First["state"]);
            Console.WriteLine(obs["places"].First["state abbreviation"]);
            Console.WriteLine(obs["places"].First["latitude"]);


            Console.WriteLine( obs["places"].ToString());
            //IRestResponse<CountryDetails> response = restClient.Execute<CountryDetails>(restRequest);

            //var places = response.Data.Places;

            //Console.WriteLine(places);


            //String content = response.Content;

            //Console.Write(content);

            //int statusCode = (int)response.StatusCode;

            //Console.WriteLine(statusCode);

            //var responseStatus = response.ResponseStatus;

            //Console.WriteLine(responseStatus);

            //var contentType = response.ContentType;

            //Console.Write(contentType);

            //var responseURI = response.ResponseUri;

            //Console.WriteLine(responseURI);


            // By POCO
            //var data = response.Data;

            //Console.WriteLine(data);

            //string country = response.Data.Country;

            //Console.WriteLine(country);

            //Place[] places = data.Places;

            //foreach (Place place in places)
            //{
            // Console.WriteLine(place.Latitude);
            //}


            // json parsing by deserilization 

            //var jObject = JObject.Parse(response.Content);
            //var country1 = jObject.GetValue("country");
            //var place1 = jObject.GetValue("places");
            //Console.WriteLine(place1);

            //var queryResult =  restClient.Execute<CountryDetails>(restRequest).Data;

            // string jsonResult = JsonConvert.SerializeObject(queryResult);

            // Console.WriteLine(jsonResult);

            // dynamic jsonResponse = JsonConvert.DeserializeObject<CountryDetails>(response.Content);

            // try
            // {
            //     CountryDetails countryDetails = new JsonDeserializer().Deserialize<CountryDetails>(jsonResponse);
            //     String country2 = countryDetails.Country;
            //     Console.WriteLine(country2);
            //     Place[] places1 = countryDetails.Places;
            //     foreach (Place place in places1)
            //     {
            //         Console.WriteLine(place.Latitude);
            //     }
            // }
            //catch (Exception e)
            //{
            //     Console.WriteLine(e.Message);
            // }
        }
    }
}
