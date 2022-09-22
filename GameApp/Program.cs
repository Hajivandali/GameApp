using GameApp.BLL;
namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var GameBusiness = new GameBusiness();
            var gamename = GameBusiness.PlayWithBot(1);
            Console.WriteLine(gamename);
        }
    }
}