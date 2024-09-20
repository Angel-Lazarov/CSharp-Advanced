
using System.Text;

namespace OpinionPoll
{
    public class Group
    {
		private List<Person> people;

        public Group()
        {
            people = new List<Person>();
        }

        public List<Person> People
		{
			get { return people; }
			set { people = value; }
		}

		public void AddMember(Person person) 
		{
			People.Add(person);
		}

		public void Sort()
		{
			People = People.Where( p => p.Age > 30).OrderBy(p=>p.Name).ToList();
		}

		public void Print()
		{
			Sort();
			StringBuilder sb = new StringBuilder();
            foreach (var person in people)
            {
                sb.AppendLine($"{person.Name} - {person.Age}");
            }
            Console.WriteLine(sb.ToString());

        }

	}
}
