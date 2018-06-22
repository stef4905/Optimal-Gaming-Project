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
    public class ComponentHDDController
    {
        private MongoDBHDD _MongoDBHDD = null;

        /// <summary>
        /// Constructor for the ComponentHDDController
        /// </summary>
        public ComponentHDDController()
        {
            _MongoDBHDD = new MongoDBHDD();
        }

        /// <summary>
        /// Adds the given HDD object to the database
        /// </summary>
        /// <param name="obj">HDD object to insert into the database</param>
        public void AddToDatabase(HDD obj)
        {
            _MongoDBHDD.Create(obj);
        }

        /// <summary>
        /// Returns a single HDD object from the database by the given ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the document in the database</param>
        /// <returns>HDD object</returns>
        public HDD GetHDD(ObjectId id)
        {
            return _MongoDBHDD.Get(id);
        }

        /// <summary>
        /// Updates the given HDD object in the database if it exists
        /// </summary>
        /// <param name="obj">HDD object to update</param>
        public async void Update(HDD obj)
        {
            await _MongoDBHDD.UpdateAsync(obj);
        }
        
        /// <summary>
        /// Deletes the given HDD object from the database if it exists
        /// </summary>
        /// <param name="obj">HDD object to delete</param>
        /// <returns>Bool - true = success, false = failed</returns>
        public bool DeleteFromDatabase(HDD obj)
        {
            return _MongoDBHDD.Delete(obj);
        }


    }
}
