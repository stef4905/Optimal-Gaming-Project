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
    public class ComponentCaseController
    {
        private MongoDBCase _MongoDBCase = null;

        /// <summary>
        /// Constructor for the ComponentCaseController
        /// </summary>
        public ComponentCaseController()
        {
            _MongoDBCase = new MongoDBCase();
        }

        /// <summary>
        /// Add the given Case object to the database
        /// </summary>
        /// <param name="obj">Case object to insert into database</param>
        public void AddToDatabase(Case obj)
        {
            _MongoDBCase.Create(obj);
        }

        /// <summary>
        /// Returns a single Case object from the database by the given ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the document</param>
        /// <returns>Case object</returns>
        public Case GetCase(ObjectId id)
        {
            return _MongoDBCase.Get(id);
        }

        /// <summary>
        /// Updates the given Case object in the database
        /// </summary>
        /// <param name="obj"></param>
        public async void Update(Case obj)
        {
            await _MongoDBCase.UpdateAsync(obj);
        }

        /// <summary>
        /// Deletes the give Case object from the database
        /// </summary>
        /// <param name="obj">Case object to delete</param>
        /// <returns>Bool - true = success, false = failed</returns>
        public bool DeleteFromDatabase(Case obj)
        {
            return _MongoDBCase.Delete(obj);
        }




    }
}
