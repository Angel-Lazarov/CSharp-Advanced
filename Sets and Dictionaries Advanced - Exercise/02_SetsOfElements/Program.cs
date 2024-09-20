int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = nums[0];
int m = nums[1];

HashSet<int> first = new HashSet<int>();
HashSet<int> second = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    first.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < m; i++)
{
    second.Add(int.Parse(Console.ReadLine()));
}

first.IntersectWith(second);

foreach (var item in first)
{
    Console.Write(item + " ");
}


//foreach (int i in first) 
//{
//    if (second.Contains(i)) 
//    { 
//        Console.Write(i +" ");
//    }
//}