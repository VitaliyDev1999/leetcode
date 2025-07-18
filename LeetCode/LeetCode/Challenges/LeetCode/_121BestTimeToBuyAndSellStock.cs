namespace LeetCode.Challenges.LeetCode
{
    //ref 
    public class _121BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minValue = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minValue)
                {
                    minValue = prices[i];
                }
                else if ((prices[i] - minValue) > maxProfit)
                {
                    maxProfit = prices[i] - minValue;
                }
            }
            return maxProfit;
        }
    }
}
