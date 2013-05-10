using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var game = new Game();
            eventLoop.Run(new ArrowHandler(game.OnLeft), new ArrowHandler(game.OnRight), new ArrowHandler(game.OnUp), new ArrowHandler(game.OnDown));
        }
    }
}
