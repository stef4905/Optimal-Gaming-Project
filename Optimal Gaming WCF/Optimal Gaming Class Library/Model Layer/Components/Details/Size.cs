using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Model_Layer.Components.Details
{
    public class Size
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; }

        public Size()
        {
            
        }

        public Size(double height, double width, double depth)
        {
            this.Height = height;
            this.Width = width;
            this.Depth = depth;
        }

        public Size(double height, double width, double depth, double weight)
        {
            this.Height = height;
            this.Width = width;
            this.Depth = depth;
            this.Weight = weight;
        }

    }
}
