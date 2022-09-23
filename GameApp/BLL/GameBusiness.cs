using GameApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.BLL
{
    public class GameBusiness
    {
        private readonly IGameDataAccess _gameDataAccess;

        public GameBusiness(IGameDataAccess gameDataAccess)
        {
            _gameDataAccess = gameDataAccess;
        }

        public string PlayWithBot(long id)
        {
            var game = _gameDataAccess.FindBy(id);
            game = game.ToUpper();

            return $"The Selcted Game Is :{game}";
        }
    }
}
 