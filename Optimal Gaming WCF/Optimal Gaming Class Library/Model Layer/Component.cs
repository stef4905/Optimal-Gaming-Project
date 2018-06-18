using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Model_Layer
{
    public class Component<T>
    {
        [BsonId]
        public ObjectId MongoDBId { get; set; } // MongoDB Id generated automaticly on insert into the databse. 
        public T ComponentType { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set;}
        public string AfffiliateLink { get; set; }
    }
}
