using System.Text;

namespace LeetCode.Challenges.LeetCode
{
    public static class _125ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            string filteredString = string.Empty;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var c in s)
            {
                if(char.IsLetterOrDigit(c))
                {
                    stringBuilder.Append(Char.ToLower(c));
                }
            }

            filteredString  = stringBuilder.ToString();

            var reversedChars = filteredString.ToCharArray();
            Array.Reverse(reversedChars);
            var reversedString = new string(reversedChars);

            return reversedString == filteredString;
        }
    }
}
