using Optimal_Gaming_Class_Library;
using Optimal_Gaming_Class_Library.API_Layer;
using Optimal_Gaming_Class_Library.Model_Layer;
using Optimal_Gaming_Class_Library.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optimal_Gaming_Class_Library.Control_Layer;
using Optimal_Gaming_Class_Library.Model_Layer.Components.Details;
using Optimal_Gaming_Class_Library.Control_Layer.SpecsController;

namespace Console_App_for_testing_only
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }

        public static void CreateNewGame()
        {
            //Creating a new IGDB api connection
            IGDB igdb = new IGDB();

            //Getting connection to MongoDB
            MongoDBGame dbGame = new MongoDBGame();
            // Creating a new database called "Games"
            //MongoDBConnection client = new MongoDBConnection();
            //client.CreateDatabase("Games");
            //Getting game from the IGDB API
            RootObject game = igdb.GetGameById(56842);
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
