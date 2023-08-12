namespace LeetCodeAlgorithms
{
    internal class TwoSumSolution
    {/// <summary>
    /// This algorithms found the indexes from the give nums whick at in that places generate the TARGET :) !
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
        static int[] TwoSum(int[] nums, int target)
        {
            var index = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 0; k < nums.Length; k++)
                {

                    if (index.Count() < 2)
                    {
                        if (i != k)
                        {
                            int x = nums[i];
                            int y = nums[k];
                            if (x + y == target)
                            {
                                index.Add(i);
                                index.Add(k);
                                break;
                            }
                        }
                    }
                }
            }
            return index.ToArray();
        }
    }
}
