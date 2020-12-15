using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace QuickJokes
{
    class JokeGenerator
    {
        public static string DadJokeCall()
        {
            var client = new RestClient("https://dad-jokes.p.rapidapi.com/random/joke");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "24642a2d30mshbe2a5f2b7fad6afp1fc158jsn1203d6b5f323");
            request.AddHeader("x-rapidapi-host", "dad-jokes.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            var dadobject = JObject.Parse(response.Content).GetValue("body");
            var setup = dadobject[0]["setup"].ToString();
            var punchLine = dadobject[0]["punchline"].ToString();


            return ($"{setup} \n {punchLine}");

        }

        public static string AnyJokeCall()
        {
            var client = new RestClient("https://joke3.p.rapidapi.com/v1/joke");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "24642a2d30mshbe2a5f2b7fad6afp1fc158jsn1203d6b5f323");
            request.AddHeader("x-rapidapi-host", "joke3.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            var anyobject = JObject.Parse(response.Content).GetValue("content").ToString();


            if (anyobject.Contains("?"))
            {
                string[] setup = anyobject.Split('?');
                return ($"{setup[0]}? \n" +
                    $" {setup[1]}");
            }
            else
            {
                return anyobject;
            }

        }

        public static string GeekJokeCall()
        {
            var client = new RestClient("https://geek-jokes.p.rapidapi.com/api?format=json");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "24642a2d30mshbe2a5f2b7fad6afp1fc158jsn1203d6b5f323");
            request.AddHeader("x-rapidapi-host", "geek-jokes.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            var geekobject = JObject.Parse(response.Content).GetValue("joke").ToString();

            return ($"{geekobject}");

        }
    }
}


