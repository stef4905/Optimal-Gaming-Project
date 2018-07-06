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
    public class MongoDBHDD : IMongoDBCRUD<HDD>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "Component-Motherboard";
        private IMongoCollection<HDD> Collection;

        public MongoDBHDD()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<HDD>(DatabaseName);
        }

        /// <summary>
        /// Creates a new HDD document in the database
        /// </summary>
        /// <param name="obj">HDD object</param>
        public void Create(HDD obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes a HDD object in the datbase using the ObjectId on t he given HDD object
        /// </summary>
        /// <param name="obj">HDD object</param>
        /// <returns>Bool true = success, false = failed</returns>
        public bool Delete(HDD obj)
        {
            var filter = Builders<HDD>.Filter.Eq(hdd => hdd.MongoDBId, obj.MongoDBId);
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
        /// Returns a single HDD document from the database by the given ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the HDD document</param>
        /// <returns>HDD object</returns>
        public HDD Get(ObjectId id)
        {
            HDD result = null;
            List<HDD> list = Collection.Find(new BsonDocument()).ToList();
            foreach (var hdd in list)
            {
                if (hdd.MongoDBId == id)
                {
                    result = hdd;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the current HDD document in the datbase by the given HDD object
        /// </summary>
        /// <param name="obj">HDD object</param>
        /// <returns>Async method</returns>
        public async Task UpdateAsync(HDD obj)
        {
            var filter = Builders<HDD>.Filter.Eq(hdd => hdd.MongoDBId, obj.MongoDBId);
            await Collection.ReplaceOneAsync(filter, obj);
        }

        /// <summary>
        /// Returns a list of all HDD's in the mongo database
        /// </summary>
        /// <returns>List of HDD's</returns>
        public List<HDD> GetAllHDD()
        {
            return Collection.Find(new BsonDocument()).ToList();
        }

    }
}
