using MongoDB.Bson;
using Optimal_Gaming_Class_Library.Database_Layer.Components.Details;
using Optimal_Gaming_Class_Library.Model_Layer.Components.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Control_Layer
{
    public class ComponentSizeController
    {
        private MongoDBSize _MongoDBSize= null;
        
        public ComponentSizeController()
        {
            _MongoDBSize = new MongoDBSize();
        }

        /// <summary>
        /// Create a new size object
        /// </summary>
        /// <param name="height">Height of the component in mm</param>
        /// <param name="width">Width of the component in mm</param>
        /// <param name="depth">Depth of the component in mm</param>
        /// <param name="weight">Weight of the component in kg</param>
        /// <returns></returns>
        public Size CreateNewSize(double height, double width, double depth, double weight)
        {
            return new Size(height, width, depth, weight);
        }

        /// <summary>
        /// Add the Size object to the database
        /// </summary>
        /// <param name="obj">Size object</param>
        public void AddToDatabase(Size obj)
        {
            _MongoDBSize.Create(obj);
        }

        /// <summary>
        /// Delete a Size document on the database by the given Size object
        /// </summary>
        /// <param name="obj">Size object - must have the ObjectId</param>
        /// <returns>Bool true = Success, false = Failed</returns>
        public bool DeleteFromDatabase(Size obj)
        {
            return _MongoDBSize.Delete(obj);
        }

        /// <summary>
        /// Returns a single Size object from the database by the given ObjectId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Size GetSize(ObjectId id)
        {
            return _MongoDBSize.Get(id);
        }

        /// <summary>
        /// Update the given Size object in the database
        /// </summary>
        /// <param name="obj"></param>
        public async void UpdateSize(Size obj)
        {
            await _MongoDBSize.UpdateAsync(obj);
        }


    }
}
