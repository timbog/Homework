using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLoop
{
    public delegate void ArrowHandler();

    public class EventLoop
    {

        /// <summary>
        /// Method which checks what to do when buttons are pressed
        /// </summary>
        /// <param name="left">Left arrow</param>
        /// <param name="right">Right arrow</param>
        /// <param name="up">Up arrow</param>
        /// <param name="down">Down arrow</param>
        public void Run(ArrowHandler left, ArrowHandler right, ArrowHandler up, ArrowHandler down)
        {
            while (true)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        left();
                        break;
                    case ConsoleKey.RightArrow:
                        right();
                        break;
                    case ConsoleKey.UpArrow:
                        up();
                        break;
                    case ConsoleKey.DownArrow:
                        down();
                        break;
                }
            }
        }
    }
}
