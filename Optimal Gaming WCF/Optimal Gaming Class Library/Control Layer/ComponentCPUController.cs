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
    public class ComponentCPUController
    {
        private MongoDBCPU _MongoDBCPU = null;

        public ComponentCPUController()
        {
            _MongoDBCPU = new MongoDBCPU();
        }

        /// <summary>
        /// Add the given CPU object to the database
        /// </summary>
        /// <param name="obj">CPU object to insert</param>
        public void AddToDatabase(CPU obj)
        {
            _MongoDBCPU.Create(obj);
        }

        /// <summary>
        /// Returns a single CPU object from the database if is exists
        /// </summary>
        /// <param name="id">ObjectId of the CPU</param>
        /// <returns>CPU object</returns>
        public CPU GetCPU(ObjectId id)
        {
            return _MongoDBCPU.Get(id);
        }

        /// <summary>
        /// Updates the given CPU object in the database
        /// </summary>
        /// <param name="obj">CPU object to update</param>
        public async void update(CPU obj)
        {
            await _MongoDBCPU.UpdateAsync(obj);
        }

        /// <summary>
        /// Deletes the given CPU object from the database if it exists
        /// </summary>
        /// <param name="obj">CPU object to delete</param>
        /// <returns>Bool true = success, false = failed</returns>
        public bool DeleteFromDatabase(CPU obj)
        {
            return _MongoDBCPU.Delete(obj);
        }

        /// <summary>
        /// Returns a list of all CPU's in the mongo database
        /// </summary>
        /// <returns>List of CPU's</returns>
        public List<CPU> GetAllCPU()
        {
            return _MongoDBCPU.GetAllCPU();
        }
    }
}
