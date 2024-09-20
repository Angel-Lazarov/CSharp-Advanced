string command = string.Empty;
Dictionary<string, Vloger> sistem = new();

while ((command = Console.ReadLine()) != "Statistics")
{
    string[] commandTokens = command.Split();
    string name = commandTokens[0];
    //•	"{vloggername}" joined The V-Logger

    if (commandTokens.Contains("joined"))
    {
        Vloger vloger = new Vloger(name, new SortedSet<string>(), new SortedSet<string>());
        if (!sistem.ContainsKey(name))
        {
            sistem.Add(name, vloger);
        }
    }
    //•	"{name} followed {secondName}" 
    else if (commandTokens.Contains("followed"))
    {
        string secondName = commandTokens[2];

        if (sistem.ContainsKey(name) && sistem.ContainsKey(secondName) && name != secondName)
        {
            sistem[name].Followings.Add(secondName);
            sistem[secondName].Followers.Add(name);
        }
    }
}

var mostFamous = sistem.OrderByDescending(v => v.Value.Followers.Count).ThenBy(v => v.Value.Followings.Count).FirstOrDefault();

Console.WriteLine($"The V-Logger has a total of {sistem.Count} vloggers in its logs.");

int index = 1;

Console.WriteLine($"{index}. {mostFamous.Key} : {mostFamous.Value.Followers.Count} followers, {mostFamous.Value.Followings.Count} following");
foreach (var follower in mostFamous.Value.Followers)
{
    Console.WriteLine($"*  {follower}");
}

sistem.Remove(mostFamous.Key);

foreach (var user in sistem.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Followings.Count))
{
    Console.WriteLine($"{++index}. {user.Key} : {user.Value.Followers.Count} followers, {user.Value.Followings.Count} following");
}



class Vloger
{
    public Vloger(string name, SortedSet<string> followers, SortedSet<string> followings)
    {
        Name = name;
        Followers = followers;
        Followings = followings;
    }

    public string Name { get; set; }
    public SortedSet<string> Followers { get; set; }
    public SortedSet<string> Followings { get; set; }
}



//print
/*
 * 
The V-Logger has a total of {registered vloggers} vloggers in its logs.
1. {mostFamousVlogger} : {followers} followers, {followings} following
*  {follower1}
*  {follower2} … 
{No}. {vlogger} : {followers} followers, {followings} following
{No}. {vlogger} : {followers} followers, {followings} following…

 */