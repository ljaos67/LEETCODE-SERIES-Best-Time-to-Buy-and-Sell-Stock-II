public class Solution {
    public int MaxProfit(int[] prices) {
        int total = 0;
        int buyingPrice = prices[0];
        for(int i = 0; i < prices.Count(); i++)
        {
            if(prices[i] < buyingPrice)
            {
                buyingPrice = prices[i];
            }
            else
            {
                total += prices[i] - buyingPrice;
                buyingPrice = prices[i];
            }
        }
        return (total > 0 ? total : 0);
    }
}
