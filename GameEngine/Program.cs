using System;
using System.Threading.Tasks;
using OpenTK;

namespace GameEngine
{
    static class Program
    {

        static void Main()
        {
            using (Game game = new Game())
            {
                
                game.Run(60.0,60.0);
            }
        }
    }
}
