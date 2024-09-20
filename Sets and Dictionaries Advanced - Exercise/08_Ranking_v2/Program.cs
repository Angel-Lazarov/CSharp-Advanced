string inputContest = string.Empty;
Dictionary<string, string> examList = new Dictionary<string, string>();
while ((inputContest = Console.ReadLine()) != "end of contests")
{
    string[] inputInfo = inputContest.Split(":");
    string contestName = inputInfo[0];
    string contestPassword = inputInfo[1];

    if (!examList.ContainsKey(contestName))
    {
        examList.Add(contestName, contestPassword);
    }
}


Dictionary<string, User> users = new();


string input = string.Empty;
while ((input = Console.ReadLine()) != "end of submissions")
{
    //string[] inputInfo = input.Split(new[] { "=>" },StringSplitOptions.RemoveEmptyEntries);
    string[] inputInfo = input.Split("=>"); //?
    string contestName = inputInfo[0];
    string contestPassword = inputInfo[1];
    string userName = inputInfo[2];
    double points = double.Parse(inputInfo[3]);

    User user = new User(userName);

    if (!users.ContainsKey(userName) && IsValid(examList, contestName, contestPassword))
    {
        // Dictionary<string, User> users = new();
        users.Add(userName, user);
        users[userName].exams.Add(contestName, points);

    }
    else if (users.ContainsKey(userName) && IsValid(examList, contestName, contestPassword))
    {
        if (!users[userName].exams.ContainsKey(contestName))
        {
            users[userName].exams.Add(contestName, points);
        }
        else
        {
            if (users[userName].exams[contestName] < points)
            {
                users[userName].exams[contestName] = points;
            }
        }
    }
}

string bestName = string.Empty;
double bestPoints = 0;

foreach (var user in users)
{     //<string, User>
    if (user.Value.TotalPoints() > bestPoints)
    {
        bestPoints = user.Value.TotalPoints();
        bestName = user.Key;
    }
}

Console.WriteLine($"Best candidate is {bestName} with total {bestPoints} points.");
Console.WriteLine("Ranking:");

foreach (var user in users.OrderBy(x => x.Key))
{
    Console.WriteLine(user.Key);
    //Dictionary<string - име на изпита, double - оценка> exams
    foreach (var exam in user.Value.exams.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {exam.Key} -> {exam.Value}");
    }
}



static bool IsValid(Dictionary<string, string> examList, string contestName, string password)
{
    return examList.ContainsKey(contestName) && examList[contestName] == password;
}

class User
{
    public User(string name)
    {
        Name = name;
        exams = new Dictionary<string, double>();
    }
    public string Name { get; set; }

    public Dictionary<string, double> exams { get; set; }

    public double TotalPoints()
    {
        double totalPoints = 0;
        foreach (var user in exams)
        {
            totalPoints += user.Value;
        }
        return totalPoints;
    }
}