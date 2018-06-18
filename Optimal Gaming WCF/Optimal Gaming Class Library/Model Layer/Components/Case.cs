using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Optimal_Gaming_Class_Library.Model_Layer.Components.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Model_Layer.Components
{
    public class Case
    {
        [BsonId]
        public ObjectId MongoDBId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string BrandName { get; set; }

        //Details
        public Size _Size { get; set; }
        public string Model { get; set; } // Miditower etv
        public string[] CompatibleMotherboard { get; set; } // ATX etc
        public string[] Material { get; set; } // Build of steel etc
        public string[] Cooling { get; set; } // Fan sizes
        public int MaxCPUCoolerHeight { get; set; } // in mm
        public int MaxGPULength { get; set; } // In mm
        public string[] StorageExpansion { get; set; }
        public string[] Interface { get; set; }

        /// <summary>
        /// Constructor for creating a Case
        /// </summary>
        /// <param name="name">Name of the case</param>
        /// <param name="price">price of the case</param>
        /// <param name="brandName">Brand of the manufactor</param>
        /// <param name="Size">Size object with size and weight</param>
        /// <param name="model">Case model, miditower, full, mini</param>
        /// <param name="compatibleMotherboard">Types of motherboards, that fits the case</param>
        /// <param name="material">What materials are the case based of</param>
        /// <param name="cooling">What fans and colling abilities can the case be using</param>
        /// <param name="maxCPUCoolerHeight">Max CPU cooler height - In mm</param>
        /// <param name="maxGPULength">Max GPU length - in mm</param>
        /// <param name="storageExpansion">Storage expansion abilities</param>
        /// <param name="_interface">outputs and inputs</param>
        public Case(string name, double price, string brandName, Size Size, string model, string[] compatibleMotherboard, string[] material, string[] cooling, int maxCPUCoolerHeight, int maxGPULength, string[] storageExpansion, string[] _interface)
        {
            Name = name;
            Price = price;
            BrandName = brandName;
            _Size = Size;
            Model = model;
            CompatibleMotherboard = compatibleMotherboard;
            Material = material;
            Cooling = cooling;
            MaxCPUCoolerHeight = maxCPUCoolerHeight;
            MaxGPULength = maxGPULength;
            StorageExpansion = storageExpansion;
            Interface = _interface;
        }
    }
}
