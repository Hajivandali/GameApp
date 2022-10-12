using GameApp.DAL;
using GameApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.BLL
{
    public class GameBusiness : IGameBusiness
    {
        private readonly ILogger _logger;
        private readonly IGameDataAccess _gameDataAccess;

        public GameBusiness(IGameDataAccess gameDataAccess, ILogger logger)
        {
            _gameDataAccess = gameDataAccess;
            _logger = logger;

        }
         
        public string PlayWithBot(long id)
        {
            var game = _gameDataAccess.FindBy(id);
            game = game.ToUpper();
            _logger.Log($"LOgger:{game}");
            return $"The Selcted Game Is :{game}";
        }
    }
}
 

//**کلاس پیادهسازی IGAME