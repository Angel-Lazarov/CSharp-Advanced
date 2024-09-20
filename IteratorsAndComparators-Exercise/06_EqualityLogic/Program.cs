namespace _06_EqualityLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<Person> sortedPerson = new SortedSet<Person>();
            HashSet<Person> hashPerson = new HashSet<Person>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(input[0], int.Parse(input[1]));
               
                sortedPerson.Add(person);
                hashPerson.Add(person);
            }

            Console.WriteLine(sortedPerson.Count);
            Console.WriteLine(hashPerson.Count);

        }
    }
}
