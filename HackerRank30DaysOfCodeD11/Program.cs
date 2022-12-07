using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank30DaysOfCodeD11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            MaxHourGlass(arr);
        }
        private static void MaxHourGlass(List<List<int>> arr)
        {
            var curr = 0;
            var max = int.MinValue;

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    curr = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                                       arr[i + 1][j + 1] +
                           arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    max = Math.Max(max, curr);
                }
            }

            Console.WriteLine(max);
        }
    }
}
