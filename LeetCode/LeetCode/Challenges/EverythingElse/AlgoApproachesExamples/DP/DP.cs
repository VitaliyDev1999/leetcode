namespace LeetCode.Challenges.EverythingElse.AlgoApproachesExamples.DP
{
    /*Основные компоненты DP
     * Определить состояние (state) — параметры, которые описывают подзадачу.
     * Рекуррентное соотношение (transition) — как вычислить результат подзадачи, используя результаты меньших подзадач.
     * Базовые случаи (base cases) — начальные значения.
     * Хранение результатов — обычно в массиве или словаре.
     */

    //Climbing Stairs
    //Longest Increasing Subsequence
    //Knapsack Problem
    //Edit Distance
    //Palindrome Partitioning
    //Coin Change
    public class DP
    {
        int Fib(int n)
        {
            if (n <= 1) return n;
            return Fib(n - 1) + Fib(n - 2);
        }

        // Время — O(n). Пространство — O(n).
        int Fib(int n, Dictionary<int, int> memo)
        {
            if (n <= 1) return n;
            if (memo.ContainsKey(n)) return memo[n];

            memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
            return memo[n];
        }
    }
}
