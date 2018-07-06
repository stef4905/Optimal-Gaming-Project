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
    public class ComponentMotherboardController
    {
        private MongoDBMotherboard _MongoDBMotherboard = null;

        /// <summary>
        /// Constructor for the ComponentMotherboardConntroller class.
        /// Instanciate the MongoDBMotherboard
        /// </summary>
        public ComponentMotherboardController()
        {
            _MongoDBMotherboard = new MongoDBMotherboard();
        }

        /// <summary>
        /// Returns a single Motherboard object if it exists in the database
        /// </summary>
        /// <param name="id">ObjectId for the motherboard document in the database</param>
        /// <returns>Motherboard object</returns>
        public Motherboard GetMotherboard(ObjectId id)
        {
            return _MongoDBMotherboard.Get(id);
        }

        /// <summary>
        /// Updates the given Motherboard object in the database if it exists
        /// </summary>
        /// <param name="obj">Motherborad object to update in the database</param>
        public async void Update(Motherboard obj)
        {
            await _MongoDBMotherboard.UpdateAsync(obj);
        }

        /// <summary>
        /// Deletes the given Motherboard object from the database if it exists
        /// </summary>
        /// <param name="obj">Motherboard object to delete</param>
        /// <returns>Bool - true = success, false = failed</returns>
        public bool DeleteFromDatabase(Motherboard obj)
        {
            return _MongoDBMotherboard.Delete(obj);
        }

        /// <summary>
        /// Returns a list of all motherboards in the mongo database
        /// </summary>
        /// <returns>List of Motherboards</returns>
        public List<Motherboard> GetAllMotherboard()
        {
            return _MongoDBMotherboard.GetAllMotherboard();
        }

    }
}
