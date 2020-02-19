using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
