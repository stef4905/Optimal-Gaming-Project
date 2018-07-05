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
            CreateNewGame();
            Console.ReadLine();
        }

        public static void CreateNewGame()
        {
            //Creating a new IGDB api connection
            IGDB igdb = new IGDB();

            List<RootObject> list = igdb.FindGame("Halo");
            foreach (var game in list)
            {
                Console.WriteLine(game.name);
            }
        }



    }
}
