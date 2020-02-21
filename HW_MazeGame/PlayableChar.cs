using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW_MazeGame.CommonUtility;

namespace HW_MazeGame
{
    class PlayableChar : MazeMap
    {
        public static void PlayerMove()
        {
            for (int i = 0; i < code.GetLength(0); i++)
            {
                for (int j = 0; j < code.GetLength(1); j++)
                {
                    if (code[i, j] == 'P')
                    {
                        ConsoleKeyInfo keys;
                        keys = Console.ReadKey(true);

                        switch (keys.Key)
                        {
                            case ConsoleKey.UpArrow:
                                if (code[i - 1, j] == '1')
                                {
                                    code[i, j] = '1';
                                    code[i - 1, j] = 'P';
                                }
                                if (code[i - 1, j] == 'K')
                                {
                                    code[i, j] = '1';
                                    code[i - 1, j] = 'P';
                                    stack++;
                                }
                                if (stack == 4)
                                {
                                    if (code[i - 1, j] == 'E')
                                    {
                                        code[i, j] = '1';
                                        code[i - 1, j] = 'P';
                                        EndGame();
                                    }
                                }
                                break;
                            case ConsoleKey.DownArrow:
                                if (code[i + 1, j] == '1')
                                {
                                    code[i, j] = '1';
                                    code[i + 1, j] = 'P';
                                }
                                if (code[i + 1, j] == 'K')
                                {
                                    code[i, j] = '1';
                                    code[i + 1, j] = 'P';
                                    stack++;
                                }
                                if (stack == 4)
                                {
                                    if (code[i + 1, j] == 'E')
                                    {
                                        code[i, j] = '1';
                                        code[i + 1, j] = 'P';
                                        EndGame();
                                    }
                                }
                                break;
                            case ConsoleKey.LeftArrow:
                                if (code[i, j - 1] == '1')
                                {
                                    code[i, j] = '1';
                                    code[i, j - 1] = 'P';
                                }
                                if (code[i, j - 1] == 'K')
                                {
                                    code[i, j] = '1';
                                    code[i, j - 1] = 'P';
                                    stack++;
                                }
                                if (stack == 4)
                                {
                                    if (code[i, j - 1] == 'E')
                                    {
                                        code[i, j] = '1';
                                        code[i, j - 1] = 'P';
                                        EndGame();
                                    }
                                }
                                break;
                            case ConsoleKey.RightArrow:
                                if (code[i, j + 1] == '1')
                                {
                                    code[i, j] = '1';
                                    code[i, j + 1] = 'P';
                                }
                                if (code[i, j + 1] == 'K')
                                {
                                    code[i, j] = '1';
                                    code[i, j + 1] = 'P';
                                    stack++;
                                }
                                if (stack == 4)
                                {
                                    if (code[i, j + 1] == 'E')
                                    {
                                        code[i, j] = '1';
                                        code[i, j + 1] = 'P';
                                        EndGame();
                                    }
                                }
                                break;
                        }
                        return;
                    }
                }
            }
        }
    }
}
