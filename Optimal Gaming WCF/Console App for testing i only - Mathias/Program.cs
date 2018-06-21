using Optimal_Gaming_Class_Library.Control_Layer.SpecsController;
using Optimal_Gaming_Class_Library.Model_Layer;
using Optimal_Gaming_Class_Library.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_for_testing_i_only___Mathias
{
    class Program
    {
        

        static void Main(string[] args)
        {
            CreateMinSpec();
            Console.ReadLine();

        }

        public static void CreateMinSpec()
        {
            MinSpecController minSpecController = new MinSpecController();
            MinSpec spec = new MinSpec("Hej", "Med", "dig", 10, 11, 12, "hej");
        
            minSpecController.CreateMinSpec(spec);
            Console.WriteLine("ID: " + spec.Id);
        }
    }
}
