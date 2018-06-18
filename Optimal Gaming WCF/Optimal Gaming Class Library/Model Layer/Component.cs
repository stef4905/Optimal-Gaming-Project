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
        public int BuildId { get; set; }


        /// <summary>
        /// Constructor for the Component.
        /// </summary>
        /// <param name="componentType">Any type of component (case, cpu, gpu, hdd, sdd, mb nad pus)</param>
        /// <param name="name">Name of the component</param>
        /// <param name="imageLink"></param>
        /// <param name="affiliateLink"></param>
        public Component(T componentType)
        {
            this.ComponentType = componentType;
        }
    }
}
