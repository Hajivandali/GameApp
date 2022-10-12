using GameApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.DAL
{
    public class GameDataAccess : IGameDataAccess
    {
        private readonly ILogger _logger;

        private readonly Dictionary<long, string> _games = new Dictionary<long, string>
        {
            {1,"Call of duty" },
            {2,"Sims" },
            {3,"Pubg" },
        };
        public GameDataAccess(ILogger logger)
        {
            _logger = logger;
        }
        public string FindBy(long id)
        {
            _logger.Log(id.ToString());
            return _games[id];         
        }

       
    }
}
