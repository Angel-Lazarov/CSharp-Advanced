string[] songs = Console.ReadLine().Split(", ");

Queue<string> playlist = new Queue<string>(songs);

string commandInfo = Console.ReadLine();

//Add Watch Me

while(playlist.Any())
{
    if (commandInfo.Contains("Play"))
    {
        playlist.Dequeue();
    }
    else if (commandInfo.Contains("Add"))
    {
        string newSong = commandInfo.Replace("Add ","");
  
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
    commandInfo = Console.ReadLine();
}

if (playlist.Count == 0)
{
    Console.WriteLine("No more songs!");
}
