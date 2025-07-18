namespace LeetCode.Challenges.EverythingElse.AlgoApproachesExamples.TwoPointers
{
    /* Example of problems
     * Two Sum II
     * Valid Palindrome
     * Container With Most Water
     */

    //Сложность O(n)
    public class TwoPointersAlg
    {
        public int[] TwoPointersExample(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right];

                if (sum == target)
                    return new int[] { left, right };
                else if (sum < target)
                    left++;
                else
                    right--;
            }

            return Array.Empty<int>();
        }
    }
}
