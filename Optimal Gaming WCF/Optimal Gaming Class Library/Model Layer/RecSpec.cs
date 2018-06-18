using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Model_Layer
{
    public class RecSpec : Spec
    {
        [BsonId]
        public ObjectId id { get; set; }
        public RecSpec(string intelCPU, string mMDCPU, string gPU, int vRAMinGB, int rAMinGB, int hDDSpace, string oSVersion) : base(intelCPU, mMDCPU, gPU, vRAMinGB, rAMinGB, hDDSpace, oSVersion)
        {
        }
    }
}
