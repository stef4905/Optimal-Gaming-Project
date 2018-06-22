using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Optimal_Gaming_Class_Library.Model_Layer.Components.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Model_Layer
{
    public class Ram
    {
        [BsonId]
        public ObjectId MongoDBId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string BrandName { get; set; }

        //Details
        public Size _Size { get; set; }
        public int Capacity { get; set; } // Size of the ram capacity in gb
        public int RamSticks { get; set; } // Amount of ram sticks in the package
        public string Technology { get; set; } // DDR4 / DDR3
        public string Model { get; set; } // DIMM 288-pin
        public string FrequencySpeed { get; set; } // 2666MHz (PC4-21300)

        /// <summary>
        /// Constructor for creating a new ram object
        /// </summary>
        /// <param name="name">Name of the ram</param>
        /// <param name="price">Price of the ram</param>
        /// <param name="brandName">Brand name of the manufactor</param>
        /// <param name="Size">Size and weight</param>
        /// <param name="capacity">Total capacity in GB</param>
        /// <param name="ramSticks">Amount of sticks in the package</param>
        /// <param name="technology">Technolgy of the ram</param>
        /// <param name="model">Model type</param>
        /// <param name="frequencySpeed">Frequency of the speed in MHz and PC4-info</param>
        public Ram(string name, double price, string brandName, Size Size, int capacity, int ramSticks, string technology, string model, string frequencySpeed)
        {
            Name = name;
            Price = price;
            BrandName = brandName;
            _Size = Size;
            Capacity = capacity;
            RamSticks = ramSticks;
            Technology = technology;
            Model = model;
            FrequencySpeed = frequencySpeed;
        }
    }
}
