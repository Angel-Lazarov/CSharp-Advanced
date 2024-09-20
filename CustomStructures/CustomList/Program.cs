using CustomStructures;

CustomList list = new();

list.Add(10);
list.Add(20);
list.Add(30);
list.Add(12);
list.Add(14);
list.Add(74);
list.Add(45);

list[0] = 1;
list.RemoveAt(3);
Console.WriteLine(list.RemoveAt(1));
Console.WriteLine(list.RemoveAt(1));
Console.WriteLine(list.RemoveAt(1));

list.AddRange(new int[] { 1, 2, 4, 6, 79, 53 });


list.InsertAt(0, 1);
list.InsertAt(2, 6);
list.InsertAt(3, 56);

Console.WriteLine(list.Contains(58));
Console.WriteLine(list.Contains(12));

list.Swap(2, 6);