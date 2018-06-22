using MongoDB.Bson;
using MongoDB.Driver;
using Optimal_Gaming_Class_Library.Model_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Database_Layer.Components
{
    public class MongoDBRam : IMongoDBCRUD<Ram>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "Component-Ram";
        private IMongoCollection<Ram> Collection;

        /// <summary>
        /// Cosntructor for the MongoDBRam class.
        /// Instanciate the database.
        /// </summary>
        public MongoDBRam()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<Ram>(DatabaseName);
        }

        /// <summary>
        /// Creates a new Ram document in the database
        /// </summary>
        /// <param name="obj">Object to create in the database</param>
        public void Create(Ram obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes the given Ram object from the database if it exists
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Bool - true = success, false = failed</returns>
        public bool Delete(Ram obj)
        {
            var filter = Builders<Ram>.Filter.Eq(_ram => _ram.MongoDBId, obj.MongoDBId);
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
        /// Returns a single Ram object from the database by the given ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the document in the database</param>
        /// <returns>Ram object</returns>
        public Ram Get(ObjectId id)
        {
            Ram result = null;
            List<Ram> list = Collection.Find(new BsonDocument()).ToList();
            foreach (var _ram in list)
            {
                if (_ram.MongoDBId == id)
                {
                    result = _ram;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the given Ram object in the database if it exists
        /// </summary>
        /// <param name="obj">Ram object to update</param>
        /// <returns>Async await method</returns>
        public async Task UpdateAsync(Ram obj)
        {
            var filter = Builders<Ram>.Filter.Eq(_ram => _ram.MongoDBId, obj.MongoDBId);
            await Collection.ReplaceOneAsync(filter, obj);
        }
    }
}
