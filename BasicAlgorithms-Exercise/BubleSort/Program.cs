int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


BubleSort(numbers);
Console.WriteLine(string.Join(" ", numbers));

static int[] BubleSort(int[] numbers)
{

    for (int i = 0; i < numbers.Length; i++) 
    {
        for (int j = i; j < numbers.Length; j++) 
        {
            if (numbers[j] < numbers[i]) 
            {
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
    }
    return numbers;

}