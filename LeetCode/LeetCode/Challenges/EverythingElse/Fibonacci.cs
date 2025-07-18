namespace LeetCode.Challenges.EverythingElse
{
    public static class Fibonacci
    {
        public static int FibonacciSequence(int number)
        {
            if (number == 0)
                return 0;
            else if (number == 1)
                return 1;
            else
            {
                return FibonacciSequence(number - 2) + FibonacciSequence(number - 1);
            }
        }
    }
}
