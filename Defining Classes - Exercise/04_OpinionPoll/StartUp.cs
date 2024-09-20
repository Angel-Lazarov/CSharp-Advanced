
namespace OpinionPoll
{
    public class StartUp
    {
        static void Main() 
        {
            Group group = new();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(info[0], int.Parse(info[1]));

                group.AddMember(person);
            }

            group.Print();
        }
    }
}
