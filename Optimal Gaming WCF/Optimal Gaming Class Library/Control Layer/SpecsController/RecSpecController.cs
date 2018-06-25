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
   public class RecSpecController
    {
        private MongoDBRecSpec recSpec;

        public RecSpecController()
        {
            recSpec = new MongoDBRecSpec();
        }

        public void CreateRecSpec(Spec obj)
        {
            recSpec.Create(obj);
        }

        public bool DeleteRecSpec(Spec obj)
        {
            return recSpec.Delete(obj);
        }

        public Spec GetRecSpec(ObjectId id)
        {
            return recSpec.Get(id);
        }

        public Task UpdateRecSpec(Spec obj)
        {
            return recSpec.UpdateAsync(obj);
        }
    }
}
