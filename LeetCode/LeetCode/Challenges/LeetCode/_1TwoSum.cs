namespace LeetCode.Challenges.LeetCode
{
    //Algo Two Pointers/Misc 
    //ref https://leetcode.com/problems/two-sum/description/
    public class _1TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dictionary.TryGetValue(complement, out var j))
                {
                    return new int[] { j, i };
                }

                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]] = i;
                }
            }

            return Array.Empty<int>();
        }
    }
}
