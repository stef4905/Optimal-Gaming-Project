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
        private IMongoDatabase Database;
        private string DatabaseName = "Component-Size";
        private IMongoCollection<Size> Collection;

        /// <summary>
        /// Construct the connection to the database. No need to know the code behind this.
        /// </summary>
        public MongoDBSize()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<Size>(DatabaseName);
        }

        /// <summary>
        /// Creates a new Size document in the database.
        /// Also sets the id of the Size objectId on insert.
        /// </summary>
        /// <param name="obj">Size object</param>
        public void Create(Size obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes a size document in the database having the same id as the parameter object
        /// </summary>
        /// <param name="obj">Size object</param>
        /// <returns>Bool true = Success, false = failed</returns>
        public bool Delete(Size obj)
        {
            var filter = Builders<Size>.Filter.Eq(size => size.MongoDBId, obj.MongoDBId); ;
            bool successStatus = true;
            try
            {
                Collection.DeleteMany(filter);
            }
            catch
            {
                successStatus = false;
            }
            return successStatus;
        }

        /// <summary>
        /// Returns a single size object from the database, be finding the one with the correct ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the size document</param>
        /// <returns>Size object</returns>
        public Size Get(ObjectId id)
        {
            Size result = null;
            List<Size> list = Collection.Find(new BsonDocument()).ToList();
            foreach (var size in list)
            {
                if (size.MongoDBId == id)
                {
                    result = size;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the size document in the databsae by the given size object.
        /// This is done by finding the size document in the database having the same id, and replacing it.
        /// </summary>
        /// <param name="obj">Size object</param>
        /// <returns>Async method</returns>
        public async Task UpdateAsync(Size obj)
        {
            var filter = Builders<Size>.Filter.Eq(size => size.MongoDBId, obj.MongoDBId);
            await Collection.ReplaceOneAsync(filter, obj);
        }
    }
}
