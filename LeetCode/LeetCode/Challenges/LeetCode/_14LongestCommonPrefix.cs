namespace LeetCode.Challenges.LeetCode
{
    //ref https://leetcode.com/problems/longest-common-prefix
    public class _14LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (!strs.Any())
                return string.Empty;

            var shortestWord = strs.MinBy(a => a.Length);
            for (int i = shortestWord.Length; i > 0; i--)
            {
                if (strs.All(x => x.StartsWith(shortestWord[..i])))
                    return shortestWord[..i];
            }
            return string.Empty;
        }
    }
}
