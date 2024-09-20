
int n = int.Parse(Console.ReadLine());
List<int> list = new();

for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    list.Add(input);
}

int[] indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Swap<int>(indexes[0], indexes[1], list);


foreach (var item in list)
{
    Console.WriteLine($"{item.GetType()}: {item}");
}


void Swap<T>(int index1, int index2, List<T> list)
{
    //T tmp = ints[index1];
    //ints[index1] = ints[index2];
    //ints[index2] = tmp;


    (list[index2], list[index1]) = (list[index1], list[index2]);
}