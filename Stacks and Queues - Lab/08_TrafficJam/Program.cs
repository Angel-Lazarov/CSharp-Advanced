int n = int.Parse(Console.ReadLine());

Queue<string> jam = new Queue<string>();

string input = string.Empty;
int carPassed = 0;

while ((input = Console.ReadLine()) != "end")
{
    if (input != "green")
    {
        jam.Enqueue(input);
    }
    else
    {
        for (int i = 0; i < n; i++)
        {
            if (jam.Count > 0)
            {
                carPassed++;
                Console.WriteLine($"{jam.Dequeue()} passed!");
            }
        }
    }
}
Console.WriteLine($"{carPassed} cars passed the crossroads.");