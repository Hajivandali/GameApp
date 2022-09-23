using GameApp.BLL;
using GameApp.DAL;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var GameBusiness = new GameBusiness(new GameDataAccess());
            var gamename = GameBusiness.PlayWithBot(1);
            Console.WriteLine(gamename);
        }

      
    }
}