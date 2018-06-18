using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Model_Layer.Components
{
    public class CPU
    {

        [BsonId]
        public ObjectId MongoDBId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string BrandName { get; set; }

        //Details
        public int Cores { get; set; } // Cores that the cpu comes with
        public int Threads { get; set; } // Number of available threads
        public int Cache { get; set; } // Chache in MB
        public double ClockFrequence {get; set;} // stock clock frequence
        public double MaxTurboFrequence { get; set; } // Max turbo frequence
        public string[] CompatibleSocket { get; set; } // Socket compatability
        public string[] CompatibleChipset { get; set; } // Chipset of the motherboard that the cpu can be used with
        public int ProductionProces { get; set; } // mesured in nm
        public string DesignDetails { get; set; } // Technologies, extentions, Intel Optane Memory supported etc
        public string Functionalities { get; set; } // Intel clear video technology etc
        public string IntegratedGraphics { get; set; } // Integrated graphics processor

        /// <summary>
        /// Constructor of a CPU (processor)
        /// </summary>
        /// <param name="name">Name of the processor</param>
        /// <param name="price">Price of the processor</param>
        /// <param name="brandName">Brand of the manufactor</param>
        /// <param name="cores">Total cores</param>
        /// <param name="threads">Total threads</param>
        /// <param name="cache">Chache size - in MB</param>
        /// <param name="clockFrequence">Clock frequence - in GHz</param>
        /// <param name="maxTurboFrequence">Turbo frequence - in GHz</param>
        /// <param name="compatibleSocket">Compatible sockets</param>
        /// <param name="compatibleChipset">Compatible chipsets</param>
        /// <param name="productionProces">Size in nm</param>
        /// <param name="designDetails">Design detials</param>
        /// <param name="functionalities">Extra functionalities</param>
        /// <param name="integratedGraphics">Integrated graphics processor</param>
        public CPU(string name, double price, string brandName, int cores, int threads, int cache, double clockFrequence, double maxTurboFrequence, string[] compatibleSocket, string[] compatibleChipset, int productionProces, string designDetails, string functionalities, string integratedGraphics)
        {
            Name = name;
            Price = price;
            BrandName = brandName;
            Cores = cores;
            Threads = threads;
            Cache = cache;
            ClockFrequence = clockFrequence;
            MaxTurboFrequence = maxTurboFrequence;
            CompatibleSocket = compatibleSocket;
            CompatibleChipset = compatibleChipset;
            ProductionProces = productionProces;
            DesignDetails = designDetails;
            Functionalities = functionalities;
            IntegratedGraphics = integratedGraphics;
        }
    }
}
