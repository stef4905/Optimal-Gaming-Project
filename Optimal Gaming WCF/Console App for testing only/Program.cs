using Optimal_Gaming_Class_Library;
using Optimal_Gaming_Class_Library.API_Layer;
using Optimal_Gaming_Class_Library.Model_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_for_testing_only
{
    class Program
    {
        static void Main(string[] args)
        {
            IGDB igdb = new IGDB();
            // RootObject game = igdb.GetGameById(1942);

            // Console.WriteLine("Name: " + game.name + " | Game id: " + game.id);

            List<RootObject> AllId = igdb.GetAllGamesId();
            int count = igdb.TotalIGDBGamesCount();
            Console.Write("Total games on IGDB: " + count);
            int[] arr = { 1 };
            List<RootObject> AllGames = igdb.GetAllGames(arr);


            Console.WriteLine("Games count: " + AllId.Count);

            foreach (var game in AllGames)
            {
                Console.WriteLine("Name of game: " + game.name + " | Id: " + game.id);
            }
            
            
            Console.ReadLine();

        }
    }
}
