﻿
namespace OGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game game = new Game())
            {

                game.Run(60, 60);

            }
        }
    }
}
