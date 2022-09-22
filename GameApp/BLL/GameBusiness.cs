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
        private readonly GameDataAccess _gameDataAccess = new GameDataAccess();

        public string PlayWithBot(long id)
        {
            var game = _gameDataAccess.findBy(id);
            game = game.ToUpper();

            return $"The Selcted Game Is :{game}";
        }
    }
}
 