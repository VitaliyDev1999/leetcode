namespace LeetCode.Challenges.LeetCode
{
    //ref https://leetcode.com/problems/valid-anagram/
    public class _242Valid_Anagram
    {
        //Simple version
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var string1 = String.Concat(s.ToLower().OrderByDescending(x => x));
            var string2 = String.Concat(t.ToLower().OrderByDescending(x => x));

            return string1 == string2;
        }

        /*
         *Отнимаем 'a', чтобы получить индекс буквы в алфавите
         *Используем массив counts[26] как простой и быстрый способ хранения частот
         *Если хотя бы один элемент массива не равен 0 — строки не анаграммы
        */
        public bool IsAnagramImproved(string s, string t)
        {
            // If the lengths are not equal, they can't be anagrams
            if (s.Length != t.Length) return false;

            // Array to store character counts for 'a' to 'z'
            int[] counts = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                // Convert both characters to lowercase to get an index and update counts
                counts[Char.ToLower(s[i]) - 'a']++; // increment count for character in s
                counts[Char.ToLower(t[i]) - 'a']--; // decrement count for character in t
            }

            // If all counts are zero, the strings are anagrams
            foreach (var count in counts)
            {
                if (count != 0) return false;
            }

            return true;
        }
    }
}
