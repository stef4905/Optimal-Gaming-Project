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




    }
}
