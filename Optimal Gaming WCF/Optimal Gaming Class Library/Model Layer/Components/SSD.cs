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
    public class SSD
    {
        [BsonId]
        public ObjectId MongoDBId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string BrandName { get; set; }

        //Detials
        public Size _Size { get; set; } // Size and weight
        public int StorageSize { get; set; } // Size of storage capacity - in GB
        public string ModelSize { get; set; } // 3.5"
        public string Interace { get; set; } // SATA 6GB/S
        public int BufferSize { get; set; } // Size of the buffer ex. 256 - in MB
        public string Features { get; set; } // Features of the hdd
        public int ReadSpeed { get; set; } // Read speed - in MBps
        public int WriteSpeed { get; set; } // Write speed - in MBps
        public int ExpectedLifeTime { get; set; } // Expected life time - in hours
        public double PowerConsumptionUnderLoad { get; set; } // PowerComsumption under load - in watt

        public SSD(string name, double price, string brandName, Size Size, int storageSize, string modelSize, string interace, int bufferSize, string features, int readSpeed, int writeSpeed, int expectedLifeTime, double powerConsumptionUnderLoad)
        {
            Name = name;
            Price = price;
            BrandName = brandName;
            _Size = Size;
            StorageSize = storageSize;
            ModelSize = modelSize;
            Interace = interace;
            BufferSize = bufferSize;
            Features = features;
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            ExpectedLifeTime = expectedLifeTime;
            PowerConsumptionUnderLoad = powerConsumptionUnderLoad;
        }
    }
}
