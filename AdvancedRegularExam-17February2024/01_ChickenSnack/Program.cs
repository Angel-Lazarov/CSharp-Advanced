Stack<int> coins = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> prices = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int eaten = 0;

while (coins.Any() && prices.Any())
{
    int coin = coins.Pop();
    int price = prices.Dequeue();

    if (coin == price)
    {
        eaten++;
        continue;
    }

    else if (coin > price)
    {
        eaten++;
        coin -= price;

        if (coins.Any())
        {
            int nexCoin = coins.Pop() + coin;
            coins.Push(nexCoin);
        }
        else if (coin > 0 && !coins.Any())
        {
            coins.Push(coin);
        }
    }
    else
    {
        continue;
    }
}

if (eaten == 0)
{
    Console.WriteLine($"Henry remained hungry. He will try next weekend again.");
}
else if (eaten < 4)
{
    if (eaten == 1)
    {
        Console.WriteLine($"Henry ate: {eaten} food.");
    }
    else 
    {
        Console.WriteLine($"Henry ate: {eaten} foods.");

    }
}
else if (eaten >= 4)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {eaten} foods.");
}


// 9:33 - finish