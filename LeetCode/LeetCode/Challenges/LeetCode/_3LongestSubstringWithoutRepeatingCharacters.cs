using System.Collections.Generic;

namespace LeetCode.Challenges.LeetCode
{
    //ref https://leetcode.com/problems/longest-substring-without-repeating-characters
    public class _3LongestSubstringWithoutRepeatingCharacters
    {
        /*Двигаем right, добавляя символ в set, пока он не повторяется.
          Если повтор найден — двигаем left, удаляя символы до тех пор, пока не уберём повтор.
          Всегда считаем right - left + 1 как длину текущего окна без повторов.*/

        /*The idea is to declare variables right and left. 
            Each item is written to a HashSet.
            If the item does not exist in the HashSet we write it, right counter is
            incremented by itself with the help of a loop.
            If the item already exists, we start removing items from the HashSet
            from the first one until the existing item no longer exists. */
        //Algo Misc 
        public int LengthOfLongestSubstringV2(string s)
        {
            if (s == null) return 0;

            int maxLength = 0;
            int left = 0;
            HashSet<char> set = new HashSet<char>();

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[right]);
                //if right - left + 1 is more than maxLength set maxLength as result of right - left + 1
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }

        public int LengthOfLongestSubstring(string s)
        {
            if(s == null) return 0;

            int maxLength = 0;
            int length = 0;
            HashSet<char> set = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (set.Contains(s[i]))
                {
                    if(maxLength < length)
                    {
                        maxLength = length;
                    }
                    length = 1;
                }
                else
                {
                    set.Add(s[i]);
                    length++;
                }
            }

            return maxLength;
        }
    }
}
