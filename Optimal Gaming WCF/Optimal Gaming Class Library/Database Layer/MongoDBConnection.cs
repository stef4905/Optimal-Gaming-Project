using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Database_Layer
{
    public class MongoDBConnection
    {
        public string ConnectionString = "mongodb+srv://stef4905:xep24mkn@cluster0-bjeod.mongodb.net/test?retryWrites=true";
        private MongoClient Client;
        /// <summary>
        /// Constructor generates a new MongoClient with the connection established
        /// </summary>
        public MongoDBConnection()
        {
            Client = new MongoClient(ConnectionString);
        }

        public IMongoDatabase GetDatabase(string databaseName)
        {
            return Client.GetDatabase(databaseName);
        }

        /// <summary>
        /// Creates a new database using the given string database name.
        /// If database already exist, nothing will happen.
        /// </summary>
        /// <param name="databaseName">Name of the database</param>
        public void CreateDatabase(string databaseName)
        {
            Client.GetDatabase(databaseName);
        }
    }
}
