using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCartGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(4);
            game.StartGame(4);
        }
    }
}
