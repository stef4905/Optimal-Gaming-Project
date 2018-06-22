using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Optimal_Gaming_Class_Library.Model_Layer.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Model_Layer
{
    public class Build
    {
        [BsonId]
        public ObjectId MongoDBId { get; set; }
        public RootObject _Game;
        public Case _Case;
        public CPU _CPU;
        public GPU _GPU;
        public HDD _HDD;
        public SSD _SDD;
        public Motherboard _Motherboard;
        public PSU _PSU;
        public Ram _Ram;

        /// <summary>
        /// Cosntructor of a new Build object.
        /// All objects in the parameters must already exist in the database before this can be created.
        /// </summary>
        /// <param name="game">Game RootObject</param>
        /// <param name="Case">Case object</param>
        /// <param name="CPU">CPU object</param>
        /// <param name="GPU">GPU object</param>
        /// <param name="HDD">HDD object</param>
        /// <param name="SDD">SSD object</param>
        /// <param name="Motherboard">Motherboard object</param>
        /// <param name="PSU">PSU object</param>
        /// <param name="Ram">Ram object</param>
        public Build(RootObject game, Case Case, CPU CPU, GPU GPU, HDD HDD, SSD SDD, Motherboard Motherboard, PSU PSU, Ram Ram)
        {
            _Game = game;
            _Case = Case;
            _CPU = CPU;
            _GPU = GPU;
            _HDD = HDD;
            _SDD = SDD;
            _Motherboard = Motherboard;
            _PSU = PSU;
            _Ram = Ram;
        }
    }
}
