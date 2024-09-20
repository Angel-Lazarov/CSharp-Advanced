//List<int> numbers = new List<int> { 1, 2, 3 };
List<int> numbers = Enumerable.Range(1, 10).ToList();

//for (int i = 0; i < numbers.Count; i++)
//{
//    if (numbers[i] % 2 == 0) 
//    {
//        //numbers.Remove(numbers[i]);
//        numbers[i] *= 100;
//    }
//}

foreach (var number in numbers) 
{
    if (number % 2 == 0) 
    {
        number *= 100;
    
    }
}

Console.WriteLine(string.Join(" ", numbers));