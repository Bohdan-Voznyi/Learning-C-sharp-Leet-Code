namespace _1_TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var seenNumbers = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length;i++)
            {
                int a = target - nums[i];


                if(seenNumbers.TryGetValue(a, out int complementIndex))
                {
                    return new int[] { complementIndex, i };
                }

                seenNumbers.Add(nums[i], i);

            }

            return Array.Empty<int>();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            var result = sol.TwoSum([2,4,5,6,8,9,6,5],10);
        }
    }
}
