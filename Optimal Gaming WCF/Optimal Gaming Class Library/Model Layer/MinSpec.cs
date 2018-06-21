using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Model_Layer
{
    public class MinSpec : Spec
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public MinSpec(string intelCPU, string mMDCPU, string gPU, int vRAMinGB, int rAMinGB, int hDDSpace, string oSVersion) : base(intelCPU, mMDCPU, gPU, vRAMinGB, rAMinGB, hDDSpace, oSVersion)
        {
            IntelCPU = intelCPU;
            MMDCPU = mMDCPU;
            GPU = gPU;
            VRAMinGB = vRAMinGB;
            RAMinGB = rAMinGB;
            HDDSpace = hDDSpace;
            OSVersion = oSVersion;
        }
    }
}
