
namespace DateModifier
{
    public class StartUp
    {
        static void Main() 
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            int differenceInDays =  DateModifier.GetDifference(start, end);
            Console.WriteLine(differenceInDays);
        }
    }
}
