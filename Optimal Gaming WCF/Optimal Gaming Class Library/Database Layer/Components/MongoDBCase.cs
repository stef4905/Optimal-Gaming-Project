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
    public class MongoDBCase : IMongoDBCRUD<Case>
    {

        private IMongoDatabase Database;
        private string DatabaseName = "Component-Case";
        private IMongoCollection<Case> Collection;

        /// <summary>
        /// Construct the connectio to the database.
        /// No further datbase connection needs to be made after this.
        /// </summary>
        public MongoDBCase()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<Case>(DatabaseName);
        }

        /// <summary>
        /// Creates a new Case document on the database
        /// </summary>
        /// <param name="obj"></param>
        public void Create(Case obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes a Case document in the database having the same id as the objct send in the parameter.
        /// </summary>
        /// <param name="obj">Case object</param>
        /// <returns>Bool true = Success, false = failed</returns>
        public bool Delete(Case obj)
        {
            var filter = Builders<Case>.Filter.Eq(_case => _case.MongoDBId, obj.MongoDBId);
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
        /// Returns a single Case document from the database using the ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the Case</param>
        /// <returns>Case object</returns>
        public Case Get(ObjectId id)
        {
            Case result = null;
            List<Case> list = Collection.Find(new BsonDocument()).ToList();
            foreach (var _case in list)
            {
                if (_case.MongoDBId == id)
                {
                    result = _case;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the given Case object in the datbase, using the ObjectID to replace the current one, stored in the database.
        /// </summary>
        /// <param name="obj">Case Object</param>
        /// <returns>Async method</returns>
        public async Task UpdateAsync(Case obj)
        {
            var filter = Builders<Case>.Filter.Eq(_case => _case.MongoDBId, obj.MongoDBId);
            await Collection.ReplaceOneAsync(filter, obj);
        }
    }
}
