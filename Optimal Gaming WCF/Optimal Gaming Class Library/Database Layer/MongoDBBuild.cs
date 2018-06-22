using MongoDB.Bson;
using MongoDB.Driver;
using Optimal_Gaming_Class_Library.Model_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Database_Layer
{
    public class MongoDBBuild : IMongoDBCRUD<Build>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "Build";
        private IMongoCollection<Build> Collection;

        public MongoDBBuild()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<Build>(DatabaseName);
        }

        /// <summary>
        /// Adds the given Build object to the database
        /// </summary>
        /// <param name="obj"></param>
        public void Create(Build obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes the given Build object from the database if it exists
        /// </summary>
        /// <param name="obj">Build object to delete</param>
        /// <returns>Bool - true = success, false = failed</returns>
        public bool Delete(Build obj)
        {
            var filter = Builders<Build>.Filter.Eq(_build => _build.MongoDBId, obj.MongoDBId);
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
        /// Returns a single Build object from the database using the ObjecId
        /// </summary>
        /// <param name="id">ObjectId of the document in the database</param>
        /// <returns>Build object</returns>
        public Build Get(ObjectId id)
        {
            Build result = null;
            List<Build> list = Collection.Find(new BsonDocument()).ToList();
            foreach (var _build in list)
            {
                if (_build.MongoDBId == id)
                {
                    result = _build;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the given Build object in the database if it exists
        /// </summary>
        /// <param name="obj">Build object to update</param>
        /// <returns></returns>
        public async Task UpdateAsync(Build obj)
        {
            var filter = Builders<Build>.Filter.Eq(_case => _case.MongoDBId, obj.MongoDBId);
            await Collection.ReplaceOneAsync(filter, obj);
        }
    }
}
