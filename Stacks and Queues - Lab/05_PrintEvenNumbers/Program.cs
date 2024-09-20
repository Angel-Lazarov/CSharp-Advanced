//int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

//Queue <int> ints = new Queue<int>();

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        ints.Enqueue(numbers[i]);
//    }
//}

//Console.WriteLine(string.Join(", ", ints));


using System.Security;

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue <int> queue = new Queue<int>(numbers);
List<int> ints = new List<int>();

while (queue.Count > 0)
{
    int currentNumber = queue.Dequeue();
    if(currentNumber % 2 == 0) 
    {
        ints.Add(currentNumber);  
    }
}
Console.WriteLine(string.Join(", ", ints));