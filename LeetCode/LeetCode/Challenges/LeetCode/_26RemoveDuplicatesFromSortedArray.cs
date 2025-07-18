namespace LeetCode.Challenges.LeetCode
{
    //Algo Two Pointers
    //ref https://leetcode.com/problems/remove-duplicates-from-sorted-array
    public class _26RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;


            //declare K as a counter of filtered duplicates and same time "sort" index of array
            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                //start iteration from 1 and check current value over prev value.
                //if the values are different then assign current value to nums[k] and increament k
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
