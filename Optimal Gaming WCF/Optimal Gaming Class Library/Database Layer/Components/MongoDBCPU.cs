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
    class MongoDBCPU : IMongoDBCRUD<CPU>
    {
        private IMongoDatabase Database;
        private string DatabaseName = "Component-CPU";
        private IMongoCollection<CPU> Collection;

        public MongoDBCPU()
        {
            MongoDBConnection mongoDB = new MongoDBConnection();
            Database = mongoDB.GetDatabase(DatabaseName);
            Collection = Database.GetCollection<CPU>(DatabaseName);
        }

        /// <summary>
        /// Creates a new CPU document in the database
        /// </summary>
        /// <param name="obj">CPU Object</param>
        public void Create(CPU obj)
        {
            Collection.InsertOne(obj);
        }

        /// <summary>
        /// Deletes a CPU document in the database by the given ObjectId
        /// </summary>
        /// <param name="obj">CPU object</param>
        /// <returns>Bool true = success, false = failed</returns>
        public bool Delete(CPU obj)
        {
            var filter = Builders<CPU>.Filter.Eq(cpu => cpu.MongoDBId, obj.MongoDBId);
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
        /// Returns a single CPU document from the database by the given ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the document</param>
        /// <returns>CPU Object</returns>
        public CPU Get(ObjectId id)
        {
            CPU result = null;
            List<CPU> list = Collection.Find(new BsonDocument()).ToList();
            foreach (var cpu in list)
            {
                if (cpu.MongoDBId == id)
                {
                    result = cpu;
                }
            }
            return result;
        }

        /// <summary>
        /// Updates the current CPU document in the datbase by the given CPU object
        /// </summary>
        /// <param name="obj">CPU object</param>
        /// <returns>Async method</returns>
        public async Task UpdateAsync(CPU obj)
        {
            var filter = Builders<CPU>.Filter.Eq(cpu => cpu.MongoDBId, obj.MongoDBId);
            await Collection.ReplaceOneAsync(filter, obj);
        }
    }
}
