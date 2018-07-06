using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optimal_Gaming_Class_Library.Model_Layer.Components;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Optimal_Gaming_Class_Library.Database_Layer.Components
{
    public class MongoDBMotherboard : IMongoDBCRUD<Motherboard>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "Components - Motherboard";
        private IMongoCollection<Motherboard> Collection;

        /// <summary>
        /// Construct the connection to the database. No need to know code behind this.
        /// </summary>
        public MongoDBMotherboard()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<Motherboard>(DatabaseName);
        }

        /// <summary>
        /// Creates a new Motherboard in the database.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Async method</returns>
        public void Create(Motherboard obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes a Motherboard in the database having the same id at the object in the parameter.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Bool</returns>
        public bool Delete(Motherboard obj)
        {
            var filter = Builders<Motherboard>.Filter.Eq(motherboard => motherboard.MongoDBId, obj.MongoDBId);
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
        /// Get a single Motherboard from the collection
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Spec of the found spec</returns>
        public Motherboard Get(ObjectId id)
        {
            Motherboard result = null;
            List<Motherboard> list = Collection.Find(new BsonDocument()).ToList();
            foreach(var motherboard in list)
            {
                if (motherboard.MongoDBId == id)
                {
                    result = motherboard;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the Motherboard object in the database.
        /// This is done by finding the game in the collection and replacing using async for better perfomance. 
        /// </summary>
        /// <param name="obj">Spec object</param>
        /// <returns>Async method</returns>
        public async Task UpdateAsync(Motherboard obj)
        {
            var filter = Builders<Motherboard>.Filter.Eq(motherboard => motherboard.MongoDBId, obj.MongoDBId);
            await Collection.ReplaceOneAsync(filter, obj);
        }

        /// <summary>
        /// Returns a list of all Motherboard's in the mongo database
        /// </summary>
        /// <returns>List of Motherboard's</returns>
        public List<Motherboard> GetAllMotherboard()
        {
            return Collection.Find(new BsonDocument()).ToList();
        }
    }
}
