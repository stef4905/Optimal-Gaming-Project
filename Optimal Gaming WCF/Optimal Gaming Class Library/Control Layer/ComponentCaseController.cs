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

        public ComponentCaseController()
        {
            _MongoDBCase = new MongoDBCase();
        }

        /// <summary>
        /// Add the igven Case object to the database
        /// </summary>
        /// <param name="obj">Case object</param>
        public void AddToDatabase(Case obj)
        {
            _MongoDBCase.Create(obj);
        }

        /// <summary>
        /// Return a single Case object from the database by the given ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the document</param>
        /// <returns>Case object</returns>
        public Case GetCaseFromDatabase(ObjectId id)
        {
            return _MongoDBCase.Get(id);
        }

        /// <summary>
        /// Updates the given Case object in the database
        /// </summary>
        /// <param name="obj">Case object to update</param>
        public async void UpdateCase(Case obj)
        {
            await _MongoDBCase.UpdateAsync(obj);
        }

        /// <summary>
        /// Deletes the given Case from the database if it exists
        /// </summary>
        /// <param name="obj">Case object to delete</param>
        /// <returns>Bool true = success, false = failed</returns>
        public bool DeleteFromDatabase(Case obj)
        {
            return _MongoDBCase.Delete(obj);
        }
    }
}
