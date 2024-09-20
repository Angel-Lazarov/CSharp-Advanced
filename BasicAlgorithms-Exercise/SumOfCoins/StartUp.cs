namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> coins = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderByDescending(x => x).ToList();

            int targetSum = int.Parse(Console.ReadLine());
            var result = ChooseCoins(coins, targetSum);

            int sum = 0;

            foreach (var item in result)
            {
                sum += item.Key * item.Value;
            }

            if (sum == targetSum)
            {
                Console.WriteLine($"Number of coins to take: {result.Values.Sum()}");

                foreach (var coin in result)
                {
                    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
                }
            }
            else
            {
                Console.WriteLine($"Error");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            int index = 0;
            int currentSum = 0;

            while (currentSum < targetSum)
            {
                if (currentSum + coins[index] <= targetSum)
                {
                    if (!result.ContainsKey(coins[index]))
                    {
                        result.Add(coins[index], 0);
                    }
                    result[coins[index]]++;
                    currentSum += coins[index];
                }
                else
                {
                    index++;

                    if (index == coins.Count)
                    {
                        break;
                    }
                }
            }
            return result;
        }
    }
}