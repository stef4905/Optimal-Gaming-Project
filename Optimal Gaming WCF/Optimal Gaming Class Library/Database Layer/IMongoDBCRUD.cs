using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Database_Layer
{
    public interface IMongoDBCRUD
    {
        void Create();
        BsonDocument Get();
        void Update();
        void Delete();
    }
}
