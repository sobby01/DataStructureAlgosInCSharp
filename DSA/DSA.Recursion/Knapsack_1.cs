using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    //    Given the weights and profits of ‘N’ items, we are asked to put these items in a knapsack which
    //    has a capacity ‘C’. The goal is to get the maximum profit from the items in the knapsack.Each item can
    //    only be selected once, as we don’t have multiple quantities of any item.

    //    Let’s take the example of Merry, who wants to carry
    //    some fruits in the knapsack to get maximum profit. Here are the weights and profits of the fruits:
    //    Items: { Apple, Orange, Banana, Melon }
    //Weights: { 2, 3, 1, 4 }
    //Profits: { 4, 5, 3, 7 }
    //Knapsack capacity: 5
    public class Knapsack_1
    {
        public int MaxProfit(int[] profits, int[] weights, int capacity, int currentIndex)
        {
            if (capacity <= 0 && currentIndex >= profits.Length)
            {
                return 0;
            }

            int profit1 = 0;


            if (weights[currentIndex] <= capacity)
            {
                profit1 = profits[currentIndex] +
                          MaxProfit(profits, weights, capacity - weights[currentIndex], currentIndex + 1);
            }

            int profit2 = MaxProfit(profits, weights, capacity, currentIndex + 1);

            return Math.Max(profit1, profit2);


        }
    }
}
