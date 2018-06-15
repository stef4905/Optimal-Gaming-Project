using Optimal_Gaming_Class_Library;
using Optimal_Gaming_Class_Library.API_Layer;
using Optimal_Gaming_Class_Library.Model_Layer;
using Optimal_Gaming_Class_Library.Database_Layer;
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

            //List<RootObject> AllId = igdb.GetAllGamesId();
            //int count = igdb.TotalIGDBGamesCount();
            //Console.Write("Total games on IGDB: " + count);
            //int[] arr = { 1, 2, 3, 30, 2584, 54 };
            //List<RootObject> AllGames = igdb.GetAllGamesById(arr);


            //Console.WriteLine("Games count: " + AllId.Count);

            //foreach (var game in AllGames)
            //{
            //    Console.WriteLine("Name of game: " + game.name + " | Id: " + game.id);
            //}
            
            
            Console.ReadLine();

            //Getting connection to MongoDB
            MongoDBGame dbGame = new MongoDBGame();
            // Creating a new database called "Games"
            MongoDBConnection client = new MongoDBConnection();
            client.CreateDatabase("Games");
            //Getting game from the IGDB API
            RootObject game = igdb.GetGameById(1943);
            //Print out the name of the game
            Console.WriteLine("Game name for inserting: " + game.name);
            //Inserting the game into our newly created database
            dbGame.Create(game);
            Console.WriteLine("Game inserted with id: " + game.mongoDBId);
            //Get the game from the database
            RootObject result = dbGame.Get(game.mongoDBId);
            //print the collection from the database, to check that is has been inserted
            Console.WriteLine("Game returned from database: " + game.name + " with ObjectId " + game.mongoDBId);
            Console.ReadLine();




        }
    }
}
