using System.Globalization;

namespace LeetCodeAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, };
            int[] arr2 = { 3, 4 };
            var x= MedianOfTwoSortedArrays(arr1, arr2);
            Console.WriteLine(x);
        }
        
        private static decimal MedianOfTwoSortedArrays(int[] arr1, int[] arr2)
        {
            decimal res = 0;
            Array.Sort(arr1);
            Array.Sort(arr1);
            var bigNum1 = arr1[0];
            var bigNum2 = arr2[0];
            Array.Sort(arr2);
            int totalSum = 0;
            int[] mergeNums = arr1.Concat(arr2).ToArray();
            //if(mergeNums.Length % 2 == 0)
            //{
            //    res = mergeNums[mergeNums.Length / 2] + me;
            //}

            for (int i = 0; i < mergeNums.Length; i++)
            {
                totalSum += mergeNums[i];
            }
            res = totalSum / mergeNums.Length;

            return res;
        }

    }
}