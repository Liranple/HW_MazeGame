using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW_MazeGame.PlayableChar;

namespace HW_MazeGame
{
    class MazeMap
    {
        public static bool clear = false;
        public static int stack;

        static int h = 30;
        static int v = 20;

        public static string block = "  "; // 0 or 1
        public static char player = '●'; // P
        public static char exit = '◆'; // E
        public static char item = '★'; // K

        public static char[,] code = new char[v, h];
        string XY = System.IO.File.ReadAllText(@"C:\Users\huichan\Desktop\source\repos\HW_MazeGame\HW_MazeGame\MazeCoordinate.txt");
        //        string XY =
        //"000000000000000000000000000000" +
        //"011101011111101111101111101110" +
        //"010101010000101000100000101010" +
        //"010101011110101010111111101010" +
        //"01010100001010101010000010K010" +
        //"0P0101011110101010101110100010" +
        //"000101010000101011101010111110" +
        //"010101011110101000000010100000" +
        //"0101010000101011110K0110111110" +
        //"011101101110000101010100000010" +
        //"010000101011110100010101111010" +
        //"010111111000010111110101001010" +
        //"010100001011010100010101011110" +
        //"01010K101010010101110101000010" +
        //"010101101011110101000101111010" +
        //"010100101000000101011100001000" +
        //"0101111011110K11010101011110E0" +
        //"010000100001000101010101000010" +
        //"011111101111111101110101111110" +
        //"000000000000000000000000000000";

        public void Start()
        {
            code = InsertCode();
            while (clear == false)
            {
                PrintTable();
                PrintMaze();
                PlayerMove();
                Console.Clear();
            }
        }
        void PrintTable()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("                    『 미로 찾기 게임 』");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine($"      시간 : 999                      획득한 별 : {stack}개");
        }
        void PrintMaze()
        {
            for (int i = 0; i < code.GetLength(0); i++)
            {
                for (int j = 0; j < code.GetLength(1); j++)
                {
                    if (code[i, j] == 'P')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(player);
                    }
                    else if (code[i, j] == 'E')
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(exit);
                    }
                    else if (code[i, j] == 'K')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(item);
                    }
                    else if (code[i, j] == '0')
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(block);
                    }
                    else if (code[i, j] == '1')
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(block);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(code[i,j]);
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        char[,] InsertCode()
        {
            int n = 0;
            for (int i = 0; i < code.GetLength(0); i++)
            {
                for (int j = 0; j < code.GetLength(1); j++)
                {
                    code[i, j] = XY[n++];
                }
            }
            return code;
        }

    }
}
