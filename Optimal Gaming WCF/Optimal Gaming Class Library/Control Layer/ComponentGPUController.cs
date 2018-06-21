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
    public class ComponentGPUController
    {
        private MongoDBGPU _MongoDBGPU = null;

        public ComponentGPUController()
        {
            _MongoDBGPU = new MongoDBGPU();
        }

        /// <summary>
        /// Adds the given GPU object to the database if it not already exists
        /// </summary>
        /// <param name="obj">FGPU object to add</param>
        public void AddToDatabase(GPU obj)
        {
            _MongoDBGPU.Create(obj);
        }


        /// <summary>
        /// Returns a single GPU object if it exists in the database
        /// </summary>
        /// <param name="id">ObjectId of the document in the database</param>
        /// <returns></returns>
        public GPU GetGPU(ObjectId id)
        {
            return _MongoDBGPU.Get(id);
        }

        /// <summary>
        /// Updates the given GPU object in the database
        /// </summary>
        /// <param name="obj">GPU object to update</param>
        public async void Update(GPU obj)
        {
            await _MongoDBGPU.UpdateAsync(obj);
        }

        /// <summary>
        /// Deletes the given GPU object from the database if it exists
        /// </summary>
        /// <param name="obj">GPU object to delete</param>
        /// <returns>Bool true = success, false = failed</returns>
        public bool DeleteFromDatabase(GPU obj)
        {
            return _MongoDBGPU.Delete(obj);
        }

    }
}
