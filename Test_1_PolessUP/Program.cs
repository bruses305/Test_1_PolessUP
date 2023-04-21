using System;

namespace Test_1_PolessUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {2,5,3,1};
            int min = nums[0];
            for(int i = 0; i<nums.Length;i++)
                if(min>nums[i])
                {
                    min = nums[i];
                }
            int max_1 = min;
            int max_2 = min;
            int max_3 = min;
            for(int i = 0; i<nums.Length;i++)
            {
                if(max_1<= nums[i])
                {
                    max_1 = nums[i];
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (max_2 <= nums[i] && nums[i]<max_1)
                {
                    max_2 = nums[i];
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (max_3 <= nums[i] && nums[i]<max_2)
                {
                    max_3 = nums[i];
                }
            }
            if(max_3!=max_2) Console.WriteLine(max_3);
            else if(max_2!=max_1) Console.WriteLine(max_2);
            else Console.WriteLine(max_1);
        }
    }
}
