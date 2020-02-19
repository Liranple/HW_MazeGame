using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_MazeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 25);
            new MazeMap().Start();

        }
    }
}
