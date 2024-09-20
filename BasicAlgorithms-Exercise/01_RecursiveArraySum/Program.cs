

//int[] numbers = new int[] { 1, 2, 3, 4, 5 };
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sum = SumArray(numbers, numbers.Length - 1);
Console.WriteLine(sum);

int SumArray(int[] numbers, int index)
{

    if (index < 0)
    {
        return 0;
    }

    int result = numbers[index] + SumArray(numbers, index - 1);

    return result;
}

