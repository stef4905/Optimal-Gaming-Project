using MongoDB.Bson;
using Optimal_Gaming_Class_Library.Database_Layer.Components;
using Optimal_Gaming_Class_Library.Model_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Control_Layer
{
    public class ComponentRamController
    {
        private MongoDBRam _MongoDBRam = null;

        /// <summary>
        /// Constructor for the ComponentRamController class.
        /// Instanciate the MongoDBRam class.
        /// </summary>
        public ComponentRamController()
        {
            _MongoDBRam = new MongoDBRam();
        }

        /// <summary>
        /// Adds the given Ram object to the database
        /// </summary>
        /// <param name="obj">Ram object to insert into the database</param>
        public void AddToDatabase(Ram obj)
        {
            _MongoDBRam.Create(obj);
        }

        /// <summary>
        /// Returns a single Ram object from the database by the given ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the document in the database</param>
        /// <returns>Ram object</returns>
        public Ram GetRam(ObjectId id)
        {
            return _MongoDBRam.Get(id);
        }

        /// <summary>
        /// Updates the given Ram object in the database if it exists
        /// </summary>
        /// <param name="obj">Ram object to update</param>
        public async void Update(Ram obj)
        {
            await _MongoDBRam.UpdateAsync(obj);
        }

        /// <summary>
        /// Deletes the given Ram object from the database if it exists
        /// </summary>
        /// <param name="obj">Ram object to delete</param>
        /// <returns>Bool - true = success, false = failed</returns>
        public bool DeleteFromDatabase(Ram obj)
        {
            return _MongoDBRam.Delete(obj);
        }

    }
}
