using System.Linq;
using System;

string input = string.Empty;
Dictionary<string, Dictionary<string, int>> submissions = new();
Queue<string> banned = new();

Dictionary<string, int> submissionsCounts = new();

while ((input = Console.ReadLine()) != "exam finished")
{
    string[] inputInfo = input.Split("-");
    string username = inputInfo[0];
    string language = inputInfo[1];

    if (language != "banned")
    {
        int points = int.Parse(inputInfo[2]);
        if (!submissionsCounts.ContainsKey(language))
        {
            submissionsCounts.Add(language, 0);
        }
        submissionsCounts[language]++;

        if (!submissions.ContainsKey(language))
        {
            submissions.Add(language, new Dictionary<string, int>());
            submissions[language].Add(username, points);
        }
        else
        {
            if (!submissions[language].ContainsKey(username))
            {
                submissions[language].Add(username, points);
                //  submissions[language][username] = points; 
            }
            else
            {
                if (submissions[language][username] < points)
                {
                    submissions[language][username] = points;
                }
            }
        }
    }
    else if (language == "banned")
    {
        banned.Enqueue(username);
    }
}

Console.WriteLine("Results:");

Dictionary<string, int> results = new();


foreach (var currentSubmission in submissions)
{

    foreach (var user in currentSubmission.Value)
    {

        if (!results.ContainsKey(user.Key))
        {
            results.Add(user.Key, user.Value);
        }
    }
}
foreach (var result in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    if (!banned.Contains(result.Key))
    {
        Console.WriteLine($"{result.Key} | {result.Value}");
    }
}

Console.WriteLine("Submissions:");
foreach (var item in submissionsCounts.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

