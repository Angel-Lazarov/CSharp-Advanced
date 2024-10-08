﻿int n = int.Parse(Console.ReadLine());


//Dictionary<int, int> numbers = new Dictionary<int, int>();

//for (int i = 0; i < n; i++)
//{
//    int number = int.Parse(Console.ReadLine());

//    if (!numbers.ContainsKey(number))
//    {
//        numbers.Add(number, 0);
//    }
//    numbers[number]++;
//}

//foreach (var number in numbers)
//{
//    if (number.Value % 2 == 0)
//    {
//        Console.WriteLine(number.Key);
//    }
//}


Dictionary<int, bool> numbers = new();

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (numbers.ContainsKey(number))
    {
        numbers[number] = !numbers[number];
    }
    else
    {
        numbers.Add(number, false);
    }
}

foreach (int number in numbers.Keys)
{
    if (numbers[number])
    {
        Console.WriteLine(number);
    }
}