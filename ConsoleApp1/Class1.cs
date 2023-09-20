using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Sort
    {
        public static  int[] Sortirofka (int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxIndex = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] > array[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int tmp = array[maxIndex];
                array[maxIndex] = array[i];
                array[i] = tmp;
            }
            return array;
        }
        public static void Write ( int[] array)
{
    for( int i = 0; i < array.Length ; i++)
    {
        Console.Write($"{array[i]}");
    }
}
    }
}
