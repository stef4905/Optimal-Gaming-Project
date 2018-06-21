using MongoDB.Bson;
using MongoDB.Driver;
using Optimal_Gaming_Class_Library.Model_Layer.Components.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Database_Layer.Components.Details
{
    public class MongoDBSize : IMongoDBCRUD<Size>
    {
        private IMongoDatabase Databse;
        private string DatabaseName = "Component-Size";
        private IMongoCollection<Size> Collection; 

        public void Create(Size obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Size obj)
        {
            throw new NotImplementedException();
        }

        public Size Get(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Size obj)
        {
            throw new NotImplementedException();
        }
    }
}
