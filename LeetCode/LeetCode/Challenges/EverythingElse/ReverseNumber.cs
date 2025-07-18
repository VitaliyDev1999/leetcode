namespace LeetCode.Challenges.EverythingElse
{
    public static class ReverseNumber
    {
        public static int FlipNumber(int number)
        {
            int num = 123;
            int reversed = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num = num / 10;
            }

            return reversed;
        }
    }
}
