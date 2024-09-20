string[] songs = Console.ReadLine().Split(", ");

Queue<string> playlist = new Queue<string>(songs);


while (true)
{
    string[] commandInfo = Console.ReadLine().Split();

    if (commandInfo.Contains("Play"))
    {
        if (songs.Any())
        {
            playlist.Dequeue();
        }

        if (playlist.Count == 0)
        {
            Console.WriteLine("No more songs!");
            break;
        }
    }
    else if (commandInfo.Contains("Add"))
    {
        string newSong = string.Join(" ", commandInfo.Skip(1));

        if (!playlist.Contains(newSong))
        {
            playlist.Enqueue(newSong);
        }
        else
        {
            Console.WriteLine($"{newSong} is already contained!");
        }
    }
    else if (commandInfo.Contains("Show"))
    {
        Console.WriteLine(string.Join(", ", playlist));
    }
}