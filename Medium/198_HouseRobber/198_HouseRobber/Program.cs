using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace _198_HouseRobber
{

    public class Solution
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            // robPrev2 - макс. сума на 2 кроки назад
            // robPrev1 - макс. сума на 1 крок назад
            int robPrev2 = 0;
            int robPrev1 = 0;

            foreach (int currentHouse in nums)
            {
                // Вибираємо максимум між:
                // 1. Пограбувати поточний будинок + те, що було 2 будинки тому
                // 2. Пропустити поточний і взяти максимум з попереднього будинку
                int currentMax = Math.Max(robPrev2 + currentHouse, robPrev1);

                // Пересуваємо наші змінні далі по масиву
                robPrev2 = robPrev1;
                robPrev1 = currentMax;
            }

            return robPrev1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var obj = new Solution();

            var reuslt = obj.Rob([1,2,4,6,7,60,4,6,3,8,3,68,3,100]);
            var reuslt1 = obj.Rob([2,1,1,3]);
            var reuslt2 = obj.Rob([9,8,7,1,1,10,10]);
        }
    }
}
