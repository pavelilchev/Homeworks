﻿namespace Problem4RepresentingSumWithUnlimitedAmountOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnlimitedCoins
    {
        private static HashSet<string> results = new HashSet<string>(); 
        public static void Main()
        {
            int sum = Console.ReadLine()
                    .Split(new[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1)
                    .Select(int.Parse)
                    .ToArray()[0];

            int[] coins = Console.ReadLine()
                    .Split(new[] { '=', '{', '}', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1)
                    .Select(int.Parse)
                    .ToArray();


            int combinations = FindCombinationForGivenSum(coins, sum);
            Console.WriteLine(combinations);
        }

        private static int FindCombinationForGivenSum(int[] coins, int sum)
        {
            int[,] maxCombCount = new int[coins.Length+1, sum + 1];
            for (int i = 0; i <= coins.Length ; i++)
            {
                maxCombCount[i, 0] = 1;
            }

            for (int i = 1; i <= coins.Length; i++)
            {
                for (int j = 1; j <= sum ; j++)
                {
                    if (coins[i -1] <= j)
                    {
                        maxCombCount[i, j] = maxCombCount[i - 1, j] + maxCombCount[i, j - coins[i - 1]];
                    }
                    else
                    {
                        maxCombCount[i, j] = maxCombCount[i - 1, j];
                    }
                }
            }

            return maxCombCount[coins.Length, sum];
        }
    }
}
