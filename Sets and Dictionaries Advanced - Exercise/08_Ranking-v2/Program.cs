string inputContest = string.Empty;
Dictionary<string, string> examsList = new Dictionary<string, string>();

while ((inputContest = Console.ReadLine()) != "end of contests")
{
    string[] inputInfo = inputContest.Split(":");
    string examName = inputInfo[0];
    string contestPassword = inputInfo[1];

    if (!examsList.ContainsKey(examName))
    {
        examsList.Add(examName, contestPassword);
    }
}

SortedDictionary<string, List<Exam>> results = new SortedDictionary<string, List<Exam>>();

while ((inputContest = Console.ReadLine()) != "end of submissions")
{
    string[] inputInfo = inputContest.Split("=>");
    // {contest}=>{password}=>{username}=>{points}
    string examName = inputInfo[0];
    string contestPassword = inputInfo[1];
    string studentName = inputInfo[2];
    int points = int.Parse(inputInfo[3]);

    if (!examsList.ContainsKey(examName) || examsList[examName] != contestPassword)
    { continue; }


    Exam currentContest = new Exam(points, examName);  //////////////

    if (!results.ContainsKey(studentName))
    {
        results.Add(studentName, new List<Exam>());
        results[studentName].Add(currentContest);
    }
    //SortedDictionary<string - име на студента, List<Contest>> results

    else if (results.ContainsKey(studentName)) // има такъв студент
    {
        List<Exam> examsOfStudent = results[studentName];
        bool isStudentHaveExam = false;

        //        (points, contestName)  
        foreach (Exam exam in examsOfStudent.Where(exam => exam.ExamName == examName))
        {
            isStudentHaveExam = true;
            break;
        }

        if (isStudentHaveExam)
        {
            foreach (Exam exam in examsOfStudent)
            {
                if (exam.ExamName == examName)
                {
                    if (exam.Points < currentContest.Points)
                    {
                        exam.Points = currentContest.Points;
                    }
                }
            }
        }
        else
        {
            results[studentName].Add(currentContest);

        }
    }
}

//SortedDictionary<string, List<Exam>> students = new SortedDictionary<string, List<Exam>>();
string bestUser = string.Empty;
int bestPoints = 0;

foreach (var user in results)
{
    int totalPoints = 0;
    foreach (var exam in user.Value)
    {
        totalPoints += exam.Points;
    }

    if (totalPoints > bestPoints)
    {
        bestPoints = totalPoints;
        bestUser = user.Key;
    }
}
Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
Console.WriteLine("Ranking:");

foreach (var user in results)
{
    Console.WriteLine($"{user.Key}");
    foreach (var exam in user.Value.OrderByDescending(x => x.Points))
    {
        Console.WriteLine("#  " + $"{exam.ExamName} -> {exam.Points}");
    }
}


class Exam
{
    public Exam(int points, string contestName)
    {
        Points = points;
        ExamName = contestName;
    }

    public int Points { get; set; }
    public string ExamName { get; set; }
}