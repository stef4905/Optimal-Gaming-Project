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
    public class HDD
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
        public int TransactionSpeed { get; set; } // speed of the transaction in MBps
        public double AvrWaitingTime { get; set; } // Averege waiting time in ms
        public int RotationSpeed { get; set; } // Rotation speed - in rpm
        public int ExpectedLifeTime { get; set; } // Expected life time - in hours
        public double PowerConsumptionUnderLoad { get; set; } // PowerComsumption under load - in watt

        /// <summary>
        /// Constructor of the HDD
        /// </summary>
        /// <param name="name">Name of the HDD</param>
        /// <param name="price">Price of the HDD</param>
        /// <param name="brandName">Brand name of the manufactor</param>
        /// <param name="Size">Size and weight object</param>
        /// <param name="storageSize">Total storage size - in GB</param>
        /// <param name="modelSize">*Model size</param>
        /// <param name="interace">Interface</param>
        /// <param name="bufferSize">Buffer size</param>
        /// <param name="features">Features</param>
        /// <param name="transactionSpeed">Transaction speed - in MBps</param>
        /// <param name="avrWaitingTime">Avr waiting time - in ms</param>
        /// <param name="rotationSpeed">Rotation speed</param>
        /// <param name="expectedLifeTime">Expected life time - in hours</param>
        /// <param name="powerConsumptionUnderLoad">Power consumption under load - in Watt</param>
        public HDD(string name, double price, string brandName, Size Size, int storageSize, string modelSize, string interace, int bufferSize, string features, int transactionSpeed, double avrWaitingTime, int rotationSpeed, int expectedLifeTime, double powerConsumptionUnderLoad)
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
            TransactionSpeed = transactionSpeed;
            AvrWaitingTime = avrWaitingTime;
            RotationSpeed = rotationSpeed;
            ExpectedLifeTime = expectedLifeTime;
            PowerConsumptionUnderLoad = powerConsumptionUnderLoad;
        }
    }
}
