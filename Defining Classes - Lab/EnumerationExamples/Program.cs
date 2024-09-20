using EnumerationExamples;

Player player = new Player();

while (true) 
{
    if (player.Direction == Direction.Right) 
    {
        Console.WriteLine("Direction goes right");
    }
    if (player.Direction == Direction.Left)
    {
        Console.WriteLine("Direction goes left");
    }
    if (player.Direction == Direction.Up)
    {
        Console.WriteLine("Direction goes up");
    }
    if (player.Direction == Direction.Down)
    {
        Console.WriteLine("Direction goes down");
    }

}