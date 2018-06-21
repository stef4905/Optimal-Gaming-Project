using Optimal_Gaming_Class_Library.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Control_Layer
{
    public class DBConnection
    {
        public MongoDBConnection GetMongoDBConnection()
        {
            return new MongoDBConnection();
        }

    }
}
