using MongoDB.Bson;
using Optimal_Gaming_Class_Library.Database_Layer;
using Optimal_Gaming_Class_Library.Model_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Control_Layer.SpecsController
{
    public class MinSpecController
    {
        private MongoDBMinSpec MinSpecs;

        public MinSpecController()
        {
            MinSpecs = new MongoDBMinSpec();
        }

        public void CreateMinSpec(Spec obj)
        {
            MinSpecs.Create(obj);
        }

        public bool DeleteMinSpec(Spec obj)
        {
            return MinSpecs.Delete(obj);
        }

        public Spec GetMinSpec(ObjectId id)
        {
            return MinSpecs.Get(id);
        }

        public Task UpdateMinSpec(Spec obj)
        {
           return MinSpecs.UpdateAsync(obj);
        }
    }
}
