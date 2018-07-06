using MongoDB.Bson;
using MongoDB.Driver;
using Optimal_Gaming_Class_Library.Model_Layer.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Database_Layer.Components
{
    public class MongoDBGPU : IMongoDBCRUD<GPU>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "Component-GPU";
        private IMongoCollection<GPU> Collection;

        public MongoDBGPU()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<GPU>(DatabaseName);
        }

        /// <summary>
        /// Createa a new GPU document in the datbase by the given GPU object
        /// </summary>
        /// <param name="obj">GPU object</param>
        public void Create(GPU obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes a GPU document in the database by the ObjectId on the given GPPU object
        /// </summary>
        /// <param name="obj">GPU object</param>
        /// <returns>Bool true = success, false = failed</returns>
        public bool Delete(GPU obj)
        {
            var filter = Builders<GPU>.Filter.Eq(gpu => gpu.MongoDBId, obj.MongoDBId);
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
        /// Returns a single GPU document from the database by the given ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the document</param>
        /// <returns>GPU Object</returns>
        public GPU Get(ObjectId id)
        {
            GPU result = null;
            List<GPU> list = Collection.Find(new BsonDocument()).ToList();
            foreach (var gpu in list)
            {
                if (gpu.MongoDBId == id)
                {
                    result = gpu;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the current GPU document in the datbase by the given GPU object
        /// </summary>
        /// <param name="obj">GPU object</param>
        /// <returns>Async method</returns>
        public async Task UpdateAsync(GPU obj)
        {
            var filter = Builders<GPU>.Filter.Eq(gpu => gpu.MongoDBId, obj.MongoDBId);
            await Collection.ReplaceOneAsync(filter, obj);
        }

        /// <summary>
        /// Returns a list of all GPU's in the mongo database
        /// </summary>
        /// <returns></returns>
        public List<GPU> GetAllGPU()
        {
            return Collection.Find(new BsonDocument()).ToList();
        }
    }
}
