int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int toEnque = input[0];
int toDeque = input[1];
int toFind = input[2];

Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

for (int i = 0; i < toDeque; i++)
{
    queue.Dequeue();
}

if (queue.Count == 0) 
{
    Console.WriteLine(0);
}
if (queue.Contains(toFind) && queue.Count > 0)
{
    Console.WriteLine("true");
}
else if (!queue.Contains(toFind) && queue.Count > 0)
{
    Console.WriteLine(queue.Min());
}