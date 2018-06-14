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

        /// <summary>
        /// Get a game from the IGDB API using the games specific id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>RootObject of game</returns>
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

        /// <summary>
        /// NOT FINISHED YET!
        /// </summary>
        /// <param name="id"></param>
        /// <returns>RootObject of game</returns>
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

        /// <summary>
        /// NOT FINISHED YET! SHOULD ONLY BE USED FOR A SPCIFIC AMOUNT OF GAMES, BECAUSE THE DATABASE HAS MORE THAN 1 MIL GAMES IN IT!
        /// </summary>
        /// <param name="id"></param>
        /// <returns>RootObject of game</returns>
        public List<RootObject> GetAllGamesById(int[] GameIds)
        {
            //int count = TotalIGDBGamesCount();
            //int[] arr = new int[count];
            //for (var i = 1; i <= count; i++)
            //{
            //    arr[i-1] = i;
            //}

            string numbers = "";

            numbers = String.Join(",", GameIds);

            RestClient client = new RestClient("https://api-2445582011268.apicast.io/games/" + numbers); // the string is to long, and also there are more than 1 mil games. We should only use this method for getting a specific amount of games (only the most known)
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("user-key", UserKey);
            request.AddHeader("Accept", "application/json");
            IRestResponse<RootObject> response = client.Execute<RootObject>(request);
            List<RootObject> listOfGames = JsonConvert.DeserializeObject<List<RootObject>>(response.Content);
            return listOfGames;
        }
        
        /// <summary>
        /// Get the total count of games from the IGDB database
        /// </summary>
        /// <returns>int of amount</returns>
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
