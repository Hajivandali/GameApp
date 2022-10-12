using GameApp.BLL;
using GameApp.DAL;
using GameApp.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IGameDataAccess, GameDataAccess>();
            serviceCollection.AddTransient<ILogger, Logger>();
            serviceCollection.AddTransient<IGameBusiness, GameBusiness>();


            var serviceProvider = serviceCollection.BuildServiceProvider();
            var gameBusiness = serviceProvider.GetRequiredService<IGameBusiness>();


            //var GameBusiness = new GameBusiness(new GameDataAccess(new Logger()),new Logger());
            var gamename = gameBusiness.PlayWithBot(2);
            Console.WriteLine(gamename);
        }

      
    }
}  