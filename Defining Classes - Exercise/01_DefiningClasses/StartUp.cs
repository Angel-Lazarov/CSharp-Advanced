using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int members = int.Parse(Console.ReadLine());

            Family family = new Family();


            for (int i = 0; i < members; i++)
            {
                string[] memberInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(memberInfo[0], int.Parse(memberInfo[1]));

                family.AddMember(person);
            }

            Person oldest = family.GetOldest();

            Console.WriteLine(oldest.Name + " " + oldest.Age);
            //Console.WriteLine(person2.Name +" "+ person2.Age);
        }
    }
}
