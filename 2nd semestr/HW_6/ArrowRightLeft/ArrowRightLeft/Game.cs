using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLoop
{
    public class Game
    {
        /// <summary>
        /// If left arrow pressed
        /// </summary>
        public void OnLeft()
        {
            if (Console.CursorLeft != 0)
                Console.CursorLeft = Console.CursorLeft - 1;
        }

        /// <summary>
        /// If right arrow pressed
        /// </summary>
        public void OnRight()
        {
            if (Console.CursorLeft < 79)
                Console.CursorLeft = Console.CursorLeft + 1;
        }

        /// <summary>
        /// If up arrow pressed
        /// </summary>
        public void OnUp()
        {
            if (Console.CursorTop != 0)
                Console.CursorTop = Console.CursorTop - 1;
        }

        /// <summary>
        /// If down arrow pressed
        /// </summary>
        public void OnDown()
        {
            if (Console.CursorTop < 299)
                Console.CursorTop = Console.CursorTop + 1;
        }
    }
}
