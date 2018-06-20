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
    public class PSU
    {
        [BsonId]
        public ObjectId MongoDBId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string BrandName { get; set; }

        //Details

        public Size _Size { get; set; } // Size and weight of the psu
        public string FormFactor { get; set; } // ATX or other size
        public string PowerOutlets { get; set; } // Connector pins for pc compoents
        public int Watt { get; set; } // Power in watts
        public bool Modular { get; set; } // Is the PSU modualar or fixed ? 

        /// <summary>
        /// Constructor for the PSU object
        /// </summary>
        /// <param name="name">Name of the PSU</param>
        /// <param name="price">Price of the PSU</param>
        /// <param name="brandName">Brand name of the manucator</param>
        /// <param name="Size">Size and weight of the PSU</param>
        /// <param name="formFactor">ATX, MINI ITX size</param>
        /// <param name="powerOutlets">Outlet pins for connecting the psu to the pc components</param>
        /// <param name="watt">Power of the PSU in wats</param>
        /// <param name="modular">Is the psu modular true = yes | false = no</param>
        public PSU(string name, double price, string brandName, Size Size, string formFactor, string powerOutlets, int watt, bool modular)
        {
            Name = name;
            Price = price;
            BrandName = brandName;
            _Size = Size;
            FormFactor = formFactor;
            PowerOutlets = powerOutlets;
            Watt = watt;
            Modular = modular;
        }
    }



}
