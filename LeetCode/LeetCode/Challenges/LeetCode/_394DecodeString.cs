namespace LeetCode.Challenges.LeetCode
{
    //ref https://leetcode.com/problems/decode-string/description
    //solution description https://leetcode.com/problems/decode-string/solutions/3964802/c-straightforward-by-changdaze-dc87/
    public static class _394DecodeString
    {
        public static string DecodeStringV2(string s)
        {
            Stack<string> strings = new Stack<string>();
            Stack<int> numbers = new Stack<int>();

            string currentString = "";
            int currentNumber = 0;

            foreach (char c in s)
            {
                if (c == '[')
                {
                    strings.Push(currentString);
                    numbers.Push(currentNumber);
                    currentString = "";
                    currentNumber = 0;
                }
                else if (c == ']')
                    currentString = strings.Pop() + string.Join("", Enumerable.Repeat(currentString, numbers.Pop()));
                else if (int.TryParse(c.ToString(), out int number)) //if (c - '0' <= 9 && c - '0' >= 0)
                    currentNumber = number; //currentNumber * 10 + (c - '0');
                else
                    currentString += c;
            }

            return currentString;
        }

        //my first solution
        public static string DecodeString(string s)
        {
            string[] words = s.Split(']');
            string result = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                string countChar = words[i];
                if (string.IsNullOrEmpty(countChar))
                    continue;

                if (int.TryParse(countChar[0].ToString(), out int count))
                {
                    while(count != 0)
                    {
                        result += words[i].Substring(2);
                        count--;
                    }
                }
                else
                {
                    result += words[i];
                }
            }

            return result;
        }
    }
}
