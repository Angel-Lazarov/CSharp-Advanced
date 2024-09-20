namespace _05_ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Person> persons = new List<Person>(); 
            while ((input = Console.ReadLine()) != "END") 
            {
                string[] personInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];

                Person person = new Person(name, age, town);
                persons.Add(person);
            
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            Person personToCompare = persons[index];

            int equalCount = 0;
            int diffCount= 0;

            foreach (var person in persons)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalCount++;
                }
                else 
                {
                    diffCount++;
                }
            }
            // shutdown /s /t 52200

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else 
            {
                Console.WriteLine($"{equalCount} {diffCount} {persons.Count}");
            }
        }
    }
}
