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
using Optimal_Gaming_Class_Library.Model_Layer.Components;

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
            ComponentController cc = new ComponentController();
            Size size = new Size(1,1,1,1);
            SSD ssd = new SSD("name", 10.0, "brand", size, 1, "2.3", new string[] { "1" }, 1, new string[] { "1" }, 1, 1, 1, 1.2);

            cc._ComponentSSDController.AddToDatabase(ssd);
        }



    }
}
