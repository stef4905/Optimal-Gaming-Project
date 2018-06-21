using MongoDB.Bson;
using Optimal_Gaming_Class_Library.Database_Layer.Components;
using Optimal_Gaming_Class_Library.Model_Layer.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Control_Layer
{
    public class ComponentSSDController
    {
        private MongoDBSSD _MongoDBSSD = null;

        /// <summary>
        /// Constructor of the ComponentSSDController.
        /// Instanciate the MongoDBSSD class.
        /// </summary>
        public ComponentSSDController()
        {
            _MongoDBSSD = new MongoDBSSD();
        }

        /// <summary>
        /// Returns a single SSD object by the given ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the SSD document</param>
        /// <returns>SSD object</returns>
        public SSD GetSSD(ObjectId id)
        {
            return _MongoDBSSD.Get(id);
        }

        /// <summary>
        /// Updates the given SSD object in the database
        /// </summary>
        /// <param name="obj">SSD object to update</param>
        public async void Update(SSD obj)
        {
            await _MongoDBSSD.UpdateAsync(obj);
        }

        /// <summary>
        /// Deletes the given SSD object from the database if it exists
        /// </summary>
        /// <param name="obj">SSD object to delete</param>
        /// <returns>Bool - true = success, false = failed</returns>
        public bool DeleteFromDatabase(SSD obj)
        {
            return _MongoDBSSD.Delete(obj);
        }
        
    }
}
