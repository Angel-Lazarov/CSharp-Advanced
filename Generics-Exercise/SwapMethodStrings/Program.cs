int n = int.Parse(Console.ReadLine());

List<string> list = new List<string>();


for (int i = 0; i < n; i++)
{
    string item = Console.ReadLine();
    list.Add(item);
}
int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();   

int firstIndex = indexes[0];
int secondIndex = indexes[1];

SwapIndexes<string>(firstIndex, secondIndex, list);

void SwapIndexes<T>(int firstIndex, int secondIndex, List<T> list)
{
    T tmp = list[firstIndex];
    list[firstIndex] = list[secondIndex];
    list[secondIndex] = tmp;
}

foreach (var item in list)
{
    Console.WriteLine($"{item.GetType()}: {item}");
}