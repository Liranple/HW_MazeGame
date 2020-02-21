using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW_MazeGame.MazeMap;

namespace HW_MazeGame
{
    class CommonUtility
    {
        public static T[,] ArrayDefaultValue<T>(T[,] array, T defaultValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = defaultValue;
                }
            }
            return array;
        } // 배열 기본값 설정
        public static void EndGame()
        {
            clear = true;
            for (int i = 7; i <= 22; i++)
            {
                code[5, i] = '★';
            }

            for (int i = 6; i <= 13; i++)
            {
                code[i, 7] = '★';
                for (int j = 8; j <= 21; j++)
                {
                    code[i, j] = '0';
                    if (i == 9)
                    {
                        switch (j)
                        {
                            case 13:
                                code[i, j] = '미';
                                break;
                            case 14:
                                code[i, j] = '로';
                                break;
                            case 15:
                                code[i, j] = '탈';
                                break;
                            case 16:
                                code[i, j] = '출';
                                break;
                        }
                    }
                    if (i == 10)
                    {
                        switch (j)
                        {
                            case 14:
                                code[i, j] = '성';
                                break;
                            case 15:
                                code[i, j] = '공';
                                break;
                        }
                    }
                }
                code[i, 22] = '★';
            }

            for (int i = 7; i <= 22; i++)
            {
                code[14, i] = '★';
            }
        }
    }
}
