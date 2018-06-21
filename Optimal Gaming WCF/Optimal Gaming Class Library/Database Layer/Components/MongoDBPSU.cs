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
   public class MongoDBPSU : IMongoDBCRUD<PSU>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "Components - PSU";
        private IMongoCollection<PSU> Collection;

        /// <summary>
        /// Construct the connection to the database. No need to know code behind this.
        /// </summary>
        public MongoDBPSU()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<PSU>(DatabaseName);
        }

        /// <summary>
        /// Creates a new PSU in the database.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Async method</returns>
        public void Create(PSU obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes a PSU in the database having the same id at the object in the parameter.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Bool</returns>
        public bool Delete(PSU obj)
        {
            var filter = Builders<PSU>.Filter.Eq(psu => psu.MongoDBId, obj.MongoDBId);
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
        /// Get a single PSU from the collection
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Spec of the found spec</returns>
        public PSU Get(ObjectId id)
        {
            PSU result = null;
            List<PSU> list = Collection.Find(new BsonDocument()).ToList();
            foreach(var psu in list)
            {
                if(psu.MongoDBId == id)
                {
                    result = psu;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the PSU object in the database.
        /// This is done by finding the game in the collection and replacing using async for better perfomance. 
        /// </summary>
        /// <param name="obj">Spec object</param>
        /// <returns>Async method</returns>
        public async Task UpdateAsync(PSU obj)
        {
            var filter = Builders<PSU>.Filter.Eq(psu => psu.MongoDBId, obj.MongoDBId);
            await Collection.ReplaceOneAsync(filter, obj);
        }
    }
}
