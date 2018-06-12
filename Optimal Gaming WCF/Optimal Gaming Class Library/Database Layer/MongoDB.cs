using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Database_Layer
{
    public class MongoDB
    {
        public string ConnectionString = "mongodb+srv://stef4905:xep24mkn@cluster0-bjeod.mongodb.net/test?retryWrites=true";

        public MongoClient GetConnection()
        {
            return new MongoClient(ConnectionString);
        }

    }
}
