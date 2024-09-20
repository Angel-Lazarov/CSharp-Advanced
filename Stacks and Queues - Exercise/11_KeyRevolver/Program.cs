using System.Collections;

int bulletPrice = int.Parse(Console.ReadLine());
int barrelSize = int.Parse(Console.ReadLine());

int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> bullets = new Stack<int>(bulletsInput);
Queue<int> locks = new Queue<int>(locksInput);

int bulletUsed = 0;
int tempBarrell = barrelSize;

int price = int.Parse(Console.ReadLine());

while (bullets.Count > 0 && locks.Count > 0)
{
    int bullet = bullets.Pop();
    int currentLock = locks.Peek();
    bulletUsed++;

    if (bullet <= currentLock)
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }
    else
    {
        Console.WriteLine("Ping!");
    }
    tempBarrell--;

    if (tempBarrell == 0 && bullets.Count > 0)
    {
        Console.WriteLine("Reloading!");
        tempBarrell = barrelSize;
    }
}

if (bullets.Count == 0 && locks.Count > 0)
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}
if (locks.Count == 0)
{
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${price - bulletUsed * bulletPrice}");
}