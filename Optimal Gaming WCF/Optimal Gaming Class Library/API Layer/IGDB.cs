using Optimal_Gaming_Class_Library.Model_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace Optimal_Gaming_Class_Library.API_Layer
{
    public class IGDB
    {

        string UserKey = "c79eb080f8b2262163af03f2184f19e2"; // Private authentication key to gain access to the IGDB API's

        public RootObject GetGameById(int id)
        {
            RestClient client = new RestClient("https://api-2445582011268.apicast.io/games/" + id);
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("user-key", UserKey);
            request.AddHeader("Accept", "application/json");
            IRestResponse<RootObject> response = client.Execute<RootObject>(request);
            List<RootObject> listOfGames = JsonConvert.DeserializeObject<List<RootObject>>(response.Content);
            RootObject game = listOfGames[0];
            return game;
        }

        public List<RootObject> GetAllGamesId()
        {
            RestClient client = new RestClient("https://api-2445582011268.apicast.io/games/");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("user-key", UserKey);
            request.AddHeader("Accept", "application/json");
            IRestResponse<RootObject> response = client.Execute<RootObject>(request);
            List<RootObject> listOfGames = JsonConvert.DeserializeObject<List<RootObject>>(response.Content);
            return listOfGames;
        }

        public List<RootObject> GetAllGames()
        {
            string numbers = "";


            int count = TotalIGDBGamesCount();
            int[] arr = new int[count];
            for (var i = 1; i < count; i++)
            {
                arr[i] = i;
            }
            numbers = String.Join(",", arr);
            Console.WriteLine("array size: " + arr.Length + " string: " + numbers);


            //int x = 1;
            //while (x >= count)
            //{
            //    if (x == count)
            //    {
            //        numbers = numbers + x.ToString();
            //    }
            //    numbers = numbers + x.ToString() + ",";
            //}

            RestClient client = new RestClient("https://api-2445582011268.apicast.io/games/" + arr.ToString());
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("user-key", UserKey);
            request.AddHeader("Accept", "application/json");
            IRestResponse<RootObject> response = client.Execute<RootObject>(request);
            List<RootObject> listOfGames = JsonConvert.DeserializeObject<List<RootObject>>(response.Content);
            return listOfGames;
        }
        
        public int TotalIGDBGamesCount()
        {
            RestClient client = new RestClient("https://api-2445582011268.apicast.io/games/count");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("user-key", UserKey);
            request.AddHeader("Accept", "application/json");
            IRestResponse<RootObject> response = client.Execute<RootObject>(request);
            Count amount = JsonConvert.DeserializeObject<Count>(response.Content);
            return amount.count;
        }



    }
}
