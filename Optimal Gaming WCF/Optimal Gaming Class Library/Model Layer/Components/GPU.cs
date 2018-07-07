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
    public class GPU
    {
        [BsonId]
        public ObjectId MongoDBId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string BrandName { get; set; }

        //Details
        public Size _Size { get; set; }
        public string BusType { get; set; } // PCI-Express 3.0 x16 etc.
        public double KernelClock { get; set; } // Inner kernel clock frequence
        public double BoostClock { get; set; } // Boost kernel clock frequence
        public bool VRReady { get; set; } // Bool for is the GPU ready for virtual reality
        public string[] Interface { get; set; } // Outputs for display and monitor
        public string[] APICompability { get; set; } // DirectX 12, OpenGL etc
        public string[] Features { get; set; } // SLI, Afterburner etc
        public double VRamSize { get; set; } // Size of the onboard VRam - in GB
        public string VRamTechnology { get; set; } // GDDR5 SDRAM
        public double VRamClockSpeed { get; set; } // Speed of the onboard VRam - in MHz
        public string VRamBus { get; set; } // 256-bit
        public string[] SystemRequirements { get; set; } // PSU size, pin connector
        public int PowerConsumption { get; set; } // Power Consumption - in Watt

        /// <summary>
        /// Constructor of the graphics card
        /// </summary>
        /// <param name="name">Name of the GPU</param>
        /// <param name="price">Price of the GPU</param>
        /// <param name="brandName">Brand name of the manufactor</param>
        /// <param name="Size">Size and weight of the GPU</param>
        /// <param name="busType">Bus tpye</param>
        /// <param name="kernelClock">Base kernel clock</param>
        /// <param name="boostClock">Boost kernel clock</param>
        /// <param name="vRReady">Ready for vr (true) = yes | (false) = no</param>
        /// <param name="_interface">Outputs for monitor</param>
        /// <param name="_APICompability">API Compatability</param>
        /// <param name="features">Features such as sli etc</param>
        /// <param name="vRamSize">VRam size in GB</param>
        /// <param name="vRamTechnology">VRam technology</param>
        /// <param name="vRamClockSpeed">VRam clock speed - in MHz</param>
        /// <param name="vRamBus">VRam bus</param>
        /// <param name="systemRequirements">System requirements</param>
        /// <param name="powerConsumption">Total power consumption</param>
        public GPU(string name, double price, string brandName, Size Size, string busType, double kernelClock, double boostClock, bool vRReady, string[] _interface, string[] _APICompability, string[] features, double vRamSize, string vRamTechnology, double vRamClockSpeed, string vRamBus, string[] systemRequirements, int powerConsumption)
        {
            Name = name;
            Price = price;
            BrandName = brandName;
            _Size = Size;
            BusType = busType;
            KernelClock = kernelClock;
            BoostClock = boostClock;
            VRReady = vRReady;
            Interface = _interface;
            APICompability = _APICompability;
            Features = features;
            VRamSize = vRamSize;
            VRamTechnology = vRamTechnology;
            VRamClockSpeed = vRamClockSpeed;
            VRamBus = vRamBus;
            SystemRequirements = systemRequirements;
            PowerConsumption = powerConsumption;
        }
    }
}
