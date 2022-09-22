using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.DAL
{
    public class GameDataAccess
    {
        private readonly Dictionary<long, string> _games = new Dictionary<long, string>
        {
            {1,"Call of duty" },
            {2,"Sims" },
            {3,"Pubg" },
        };

        public string findBy(long id)
        {
            return _games[id];         
        }
    }
}
