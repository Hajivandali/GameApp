using System;

namespace GameApp.Helpers
{
    public class Logger : ILogger
    {
        public void Log(string massage)
        {
             Console.WriteLine(massage); 
        }
    }
}
