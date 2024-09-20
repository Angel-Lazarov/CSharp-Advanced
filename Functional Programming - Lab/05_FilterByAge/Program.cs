
using System.Diagnostics;
using System.Threading.Channels;

List<Student> students = new List<Student>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] info = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string name = info[0];
    int age = int.Parse(info[1]);

    Student student = new Student(name, age);
    students.Add(student);
}

string filterType = Console.ReadLine();
int filterAge = int.Parse(Console.ReadLine());

Func<Student, int, bool> filterFunc = FilterGenerator(filterType);
students = students.Where(student => filterFunc(student, filterAge)).ToList();


string formatOutput = Console.ReadLine();

Action<Student> printer = PrinterGenerator(formatOutput);

students.ForEach(x => printer(x));

Action<Student> PrinterGenerator(string formatOutput)
{
    if (formatOutput == "name age") 
    {
        return s => Console.WriteLine($"{s.Name} - {s.Age}");
    }
    if (formatOutput == "name")
    {
        return s => Console.WriteLine($"{s.Name}");
    }
    if (formatOutput == "age")
    {
        return s => Console.WriteLine($"{s.Age}");
    }
    return null;

}

Func<Student, int, bool> FilterGenerator(string filterType)
{
    Func<Student, int, bool> filterFunc = null;

    if (filterType == "older")
    {
        filterFunc = (student, number) => student.Age >= filterAge;
    }
    if (filterType == "younger")
    {
        filterFunc = (student, number) => student.Age < filterAge;
    }
    return filterFunc;
}


class Student
{
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
}