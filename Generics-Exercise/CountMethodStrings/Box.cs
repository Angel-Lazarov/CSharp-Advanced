﻿
using System.Text;

namespace CountMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }

        public int Count(T element)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
