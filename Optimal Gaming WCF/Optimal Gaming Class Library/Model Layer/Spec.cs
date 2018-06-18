using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Model_Layer
{
    public class Spec
    {
        [BsonId]
        public ObjectId Id {get; set;}
        public string IntelCPU {get; set;}
        public string MMDCPU { get; set; }
        public string GPU { get; set; }
        public int VRAMinGB { get; set; }
        public int RAMinGB { get; set; }
        public int HDDSpace { get; set; }
        public string OSVersion { get; set; }

        public Spec(string intelCPU, string mMDCPU, string gPU, int vRAMinGB, int rAMinGB, int hDDSpace, string oSVersion)
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
