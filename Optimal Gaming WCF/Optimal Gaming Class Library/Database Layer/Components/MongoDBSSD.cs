using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Optimal_Gaming_Class_Library.Model_Layer.Components;

namespace Optimal_Gaming_Class_Library.Database_Layer.Components
{
    public class MongoDBSSD : IMongoDBCRUD<SSD>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "Components - SSD";
        private IMongoCollection<SSD> Collection;

        /// <summary>
        /// Construct the connection to the database. No need to know code behind this.
        /// </summary>
        public MongoDBSSD()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<SSD>(DatabaseName);
        }

        /// <summary>
        /// Creates a new SSD in the database.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Async method</returns>
        public void Create(SSD obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes a SSD in the database having the same id at the object in the parameter.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Bool</returns>
        public bool Delete(SSD obj)
        {
            var filter = Builders<SSD>.Filter.Eq(SSD => SSD.MongoDBId, obj.MongoDBId);
            bool succesStatus = true;
            try
            {
                var result = Collection.DeleteMany(filter);
            }
            catch
            {
                succesStatus = false;
            }
            return succesStatus;
        }

        /// <summary>
        /// Get a single SSD from the collection
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Spec of the found spec</returns>
        public SSD Get(ObjectId id)
        {
            SSD result = null;
            List<SSD> list = Collection.Find(new BsonDocument()).ToList();
            foreach(var ssd in list)
            {
                if(ssd.MongoDBId == id)
                {
                    result = ssd;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the SSD object in the database.
        /// This is done by finding the game in the collection and replacing using async for better perfomance. 
        /// </summary>
        /// <param name="obj">Spec object</param>
        /// <returns>Async method</returns>
        public async Task UpdateAsync(SSD obj)
        {
            var filter = Builders<SSD>.Filter.Eq(ssd => ssd.MongoDBId, obj.MongoDBId);
            await Collection.ReplaceOneAsync(filter, obj);
        }
    }
}
