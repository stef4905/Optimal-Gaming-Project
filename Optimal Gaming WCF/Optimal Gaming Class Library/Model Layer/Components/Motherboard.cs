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
    public class Motherboard
    {
        [BsonId]
        public ObjectId MongoDBId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string BrandName { get; set; }

        //Details
        public Size _Size { get; set; } // Size and weight of the mootherboard
        public string FormFactor { get; set; } // Size of the motherboard | micro ATX, ATX etc
        public string Chipset { get; set; } // Chipset type of the motherboard
        public string ProcessorSocket { get; set; } // Socket | AM4, LGAxxxx
        public string RamTechnology { get; set; } // Supported ram technology DDR3 and DDR4
        public int MaxSupportedRam { get; set; } // Max supported amount of ram in the motherboard in GB
        public string[] RamBusClock { get; set; } // Supported ram bus clocks | 2400, 2133, 2667 MHz etc
        public int RamSlots { get; set; } // Supported amount of ram slots | 1, 2, 4, 6, 8
        public string AudioType { get; set; } // Audio type | HD Audio (8-channels)
        public string AudioCodec { get; set; } // Audio codec | Realtek ALC887
        public string NetworkInterface { get; set; } // Supported network interface | Gigabyte Ethernet
        public string[] ExpansionsOpenings { get; set; } // Possible expansions of the motherboard such as 1 X CPU, 4 X DIMM 288-pins, 1 X PCIe 3.0 x16 etc
        public string[] StorageInterface { get; set; } // Storage interface such as SATA-600, 6 x 7-pin Serial ATA - Raid 0 / Raid 1 / Raid 10, 1 x M.2
        public string[] Interface { get; set; } // Interface for connection on the motherboards back inputs | 1 x LAN, 2 x USB 3.1 Gen 2, 1 x hdmi 2 x usb 2.0 etc
        public string[] InternInterface { get; set; } // Interface for connection on the motherboard directly | 4 x USB 2.0 (intern), 1 x SPDIF out, 1 x Serial, 1 x Parallel
        public string[] PowerAdapter { get; set; } // Connections that is needed from the PSU to the motherboard | 24-pin connection, 8-pin ATX12V connection
        public string BiosType { get; set; } // Basic input output system name | AMI etc

        /// <summary>
        /// Constructor for creating a new Motherboard object
        /// </summary>
        /// <param name="name">Name of the motherboard</param>
        /// <param name="price"><Price of the motherboard</param>
        /// <param name="brandName">Brand name of the manucator</param>
        /// <param name="Size">Size and weight of the motherboard</param>
        /// <param name="formFactor">Form factor | ATX, mini ITX etc</param>
        /// <param name="chipset">ChipsetType</param>
        /// <param name="processorSocker">Processor socket</param>
        /// <param name="ramTechnology">Ram technology</param>
        /// <param name="maxSupportedRam">Max supported ram in GB</param>
        /// <param name="ramBusClock">Ram bus clock supported in MHz</param>
        /// <param name="ramSlots">Total amount for ram slots</param>
        /// <param name="audioType">Audio type</param>
        /// <param name="audioCodec">Audio codec</param>
        /// <param name="networkInterface">Network interface</param>
        /// <param name="expansionsOpnenigs">Possible expansion on the motherborad | 1 x cpu etc</param>
        /// <param name="storageInterface">Possible storage expansion for the motherboard </param>
        /// <param name="interface">Interace (Back inputs/outputs)</param>
        /// <param name="internInterface">Intern interface</param>
        /// <param name="powerAdapter">Power adapters that the motherboard use to get power from the PSU</param>
        /// <param name="biosType">BiosType/Name of the bios</param>
        public Motherboard(string name, double price, string brandName, Size Size, string formFactor, string chipset, string processorSocket, string ramTechnology, int maxSupportedRam, string[] ramBusClock, int ramSlots, string audioType, string audioCodec, string networkInterface, string[] expansionsOpenings, string[] storageInterface, string[] @interface, string[] internInterface, string[] powerAdapter, string biosType)
        {
            Name = name;
            Price = price;
            BrandName = brandName;
            _Size = Size;
            FormFactor = formFactor;
            Chipset = chipset;
            ProcessorSocket = processorSocket;
            RamTechnology = ramTechnology;
            MaxSupportedRam = maxSupportedRam;
            RamBusClock = ramBusClock;
            RamSlots = ramSlots;
            AudioType = audioType;
            AudioCodec = audioCodec;
            NetworkInterface = networkInterface;
            ExpansionsOpenings = expansionsOpenings;
            StorageInterface = storageInterface;
            Interface = @interface;
            InternInterface = internInterface;
            PowerAdapter = powerAdapter;
            BiosType = biosType;
        }
    }
}
