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
    public class MongoDBGame : IMongoDBCRUD<RootObject>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "Games";
        private IMongoCollection<RootObject> Collection;

        /// <summary>
        /// Construct the connection to the database. No need to know code behind this.
        /// </summary>
        public MongoDBGame()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<RootObject>(DatabaseName);
        }

        /// <summary>
        /// Creates a new game in the database.
        /// </summary>
        /// <param name="obj">RootObject of the game</param>
        /// <returns>Async method</returns>
        public void Create(RootObject obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes a game in the database having the same id at the object in the parameter.
        /// </summary>
        /// <param name="obj">RootObject of the game</param>
        /// <returns>Bool</returns>
        public bool Delete(RootObject obj)
        {
            var filter = Builders<RootObject>.Filter.Eq(game => game.mongoDBId, obj.mongoDBId);
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
        /// Gets a single game from the collection.
        /// </summary>
        /// <param name="id">int id of the game</param>
        /// <returns>RootObject of the found game</returns>
        public RootObject Get(ObjectId id)
        {
            RootObject result = null;
            List<RootObject> list = Collection.Find(new BsonDocument()).ToList();
            foreach (var game in list)
            {
                if (game.mongoDBId == id)
                {
                    result = game;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the RootObject of the game in the database.
        /// This is done by finding the game in the collection and replacing using async for better perfomance. 
        /// </summary>
        /// <param name="obj">RootObject of the game</param>
        /// <returns>Async method</returns>
        public async Task UpdateAsync(RootObject obj)
        {
            var filter = Builders<RootObject>.Filter.Eq(game => game.id, obj.id);
            await Collection.ReplaceOneAsync(filter, obj);
        }


    }
}
