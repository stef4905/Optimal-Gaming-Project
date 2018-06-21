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
    public class ComponentPSUController
    {
        private MongoDBPSU _MongoDBPSU = null;

        /// <summary>
        /// Constructor for the ComponentPSUController
        /// Instanciate the MongoDBPSU
        /// </summary>
        public ComponentPSUController()
        {
            _MongoDBPSU = new MongoDBPSU();
        }

        /// <summary>
        /// Adds the given PSU object to the database
        /// </summary>
        /// <param name="obj">PSU object to insert</param>
        public void AddToDatbase(PSU obj)
        {
            _MongoDBPSU.Create(obj);
        }

        /// <summary>
        /// Returns a single PSU object from the database
        /// </summary>
        /// <param name="id">ObjectId of the PSU document</param>
        /// <returns>PSU object</returns>
        public PSU GetPSU(ObjectId id)
        {
            return _MongoDBPSU.Get(id);
        }

        /// <summary>
        /// Updates the given PSU object in the database
        /// </summary>
        /// <param name="obj"></param>
        public async void Update(PSU obj)
        {
            await _MongoDBPSU.UpdateAsync(obj);
        }

        /// <summary>
        /// Deletes the given PSU object in the database
        /// </summary>
        /// <param name="obj">PSU object to delete</param>
        /// <returns>Bool - true = success, false = failed</returns>
        public bool DeleteFromDatabase(PSU obj)
        {
            return _MongoDBPSU.Delete(obj);
        }

        
    }
}
