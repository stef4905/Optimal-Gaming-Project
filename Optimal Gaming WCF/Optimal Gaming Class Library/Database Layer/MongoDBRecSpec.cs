using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Optimal_Gaming_Class_Library.Model_Layer;

namespace Optimal_Gaming_Class_Library.Database_Layer
{
    public class MongoDBRecSpec : IMongoDBCRUD<Spec>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "RecSpecs";
        private IMongoCollection<Spec> Collection;

        public MongoDBRecSpec()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<Spec>(DatabaseName);
        }

        public void Create(Spec obj)
        {
            Collection.InsertOne(obj);
        }

        public bool Delete(Spec obj)
        {
            var filter = Builders<Spec>.Filter.Eq(spec => spec.Id, obj.Id);
            bool successStatus = true;
            try
            {
                var result = Collection.DeleteMany(filter);
            }
            catch
            {
                successStatus = false;
            }
            return successStatus;
        }

        public Spec Get(ObjectId id)
        {
            Spec result = null;
            List<Spec> list = Collection.Find(new BsonDocument()).ToList();
            foreach(var spec in list)
            {
                if(spec.Id == id)
                {
                    result = spec;
                }
            }
            return result;
        }

        public async Task UpdateAsync(Spec obj)
        {
            var filter = Builders<Spec>.Filter.Eq(spec => spec.Id, obj.Id);
            await Collection.ReplaceOneAsync(filter, obj);
        }
    }
}
