﻿
namespace _06_EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (other == null)
            {
                return false;
            }

            return Name == other.Name && Age == other.Age;
        }

        public override int GetHashCode() 
        {
            int hashCode = Name.GetHashCode() + Age.GetHashCode();

            return hashCode;
        }
    }
}
