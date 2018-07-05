using MongoDB.Bson;
using Optimal_Gaming_Class_Library.API_Layer;
using Optimal_Gaming_Class_Library.Database_Layer;
using Optimal_Gaming_Class_Library.Model_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimal_Gaming_Class_Library.Control_Layer
{
    public class GameController
    {
        private MongoDBGame _MongoDBGame = null;
        private IGDB _IGDB = null;

        /// <summary>
        /// Constructor of the Game Controller class.
        /// Instanciate the MongoDBGame class.
        /// </summary>
        public GameController()
        {
            _MongoDBGame = new MongoDBGame();
            _IGDB = new IGDB();
        }

        /// <summary>
        /// Creates a new Game in the MongoDB, using the given RootObject.
        /// </summary>
        /// <param name="Game">RootObject that contains all information about a game</param>
        public void CreateGame(RootObject obj)
        {
            _MongoDBGame.Create(obj);
        }

        /// <summary>
        /// Returns a single Game RootObject from the Mongo database, using the given ObjectId
        /// </summary>
        /// <param name="id">ObjectId of the game in the database</param>
        /// <returns>RootObject of a game</returns>
        public RootObject GetGame(ObjectId id)
        {
            return _MongoDBGame.Get(id);
        }

        /// <summary>
        /// Returns a list of all games in the Mongo database
        /// </summary>
        /// <returns>List of all RootObject in the database</returns>
        public List<RootObject> GetAllGames()
        {
            return _MongoDBGame.GetAllGames();
        }

        /// <summary>
        /// Returns all games from the IGDB contianing the serach criteria
        /// </summary>
        /// <param name="search">Name of the game</param>
        /// <returns>Returns a list with RootObjects found</returns>
        public List<RootObject> FindAllContaining(string search)
        {
            return _IGDB.FindGame(search);
        }

        /// <summary>
        /// Updates the given Game RootObject in the database
        /// </summary>
        /// <param name="obj">RootObject of the game</param>
        public async void UpdateGame(RootObject obj)
        {
            await _MongoDBGame.UpdateAsync(obj);
        }

        /// <summary>
        /// Deletes the given RootObject in the Mongo database
        /// </summary>
        /// <param name="obj">RootObject of the game</param>
        /// <returns>Bool - true = Success, false = failed</returns>
        public bool DeleteGame(RootObject obj)
        {
            return _MongoDBGame.Delete(obj);
        }

    }
}
