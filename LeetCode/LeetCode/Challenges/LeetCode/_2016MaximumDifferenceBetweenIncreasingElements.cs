namespace LeetCode.Challenges.LeetCode
{
    //ref https://leetcode.com/problems/maximum-difference-between-increasing-elements
    public class _2016MaximumDifferenceBetweenIncreasingElements
    {
        //improved
        public int MaximumDifferenceV2(int[] nums)
        {
            int maxDifference = -1;
            int minValue = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > minValue)
                {
                    maxDifference = Math.Max(maxDifference, nums[i] - minValue);
                }
                else
                {
                    minValue = nums[i]; // обновляем минимум
                }
            }

            return maxDifference;
        }

        //my first solution
        public int MaximumDifference(int[] nums)
        {
            int maxDifference = -1;
            int maxValue = 0;
            int minValue = nums[0];

            for (int i = 1; i < nums.Length; i++) { 
                
                maxValue = nums[i];

                if(minValue > maxValue)
                {
                    minValue = maxValue;
                }

                int difference = maxValue - minValue;
                if(difference != 0)
                {
                    maxDifference = Math.Max(maxDifference, difference);
                }
            }

            return maxDifference;
        }
    }
}
