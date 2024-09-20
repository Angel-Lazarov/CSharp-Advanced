
//int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

//int index = BinarySearch(numbers, 1, 15, 15);
int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int element = int.Parse(Console.ReadLine());
int index = BinarySearch(numbers, 0, numbers.Length-1, element);


Console.WriteLine(index);

static int BinarySearch(int[] numbers, int min, int max, int element)
{
    int mid = min + (max - min) / 2;

   // if (max < min) //дъно
    if (min > max) //дъно
    {
        return -1;
    } 

    if (numbers[mid] > element)
    {
        return BinarySearch(numbers, min, mid - 1, element);
    }
    else if (numbers[mid] < element)
    {
        return BinarySearch(numbers, mid + 1, max, element);
    }
    else 
    {
        return mid;
    }
}