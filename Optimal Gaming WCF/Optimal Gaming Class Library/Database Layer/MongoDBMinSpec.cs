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
    class MongoDBMinSpec : IMongoDBCRUD<Spec>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "MinSpecs";
        private IMongoCollection<Spec> Collection;

        /// <summary>
        /// Construct the connection to the database. No need to know code behind this.
        /// </summary>
        public MongoDBMinSpec()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<Spec>(DatabaseName);
        }

        /// <summary>
        /// Creates a new Spec in the database.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Async method</returns>
        public void Create(Spec obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes a spec in the database having the same id at the object in the parameter.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Bool</returns>
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

        /// <summary>
        /// Get a single spec from the collection
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Spec of the found spec</returns>
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

        /// <summary>
        /// Updates the Spec object in the database.
        /// This is done by finding the game in the collection and replacing using async for better perfomance. 
        /// </summary>
        /// <param name="obj">Spec object</param>
        /// <returns>Async method</returns>
        public async Task UpdateAsync(Spec obj)
        {
            var filter = Builders<Spec>.Filter.Eq(spec => spec.Id, obj.Id);
            await Collection.ReplaceOneAsync(filter, obj);
        }
    }
}
