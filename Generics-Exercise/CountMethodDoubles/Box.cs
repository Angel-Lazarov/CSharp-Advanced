namespace CountMethodDoubles
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item) 
        {
            items.Add(item);
        }

        public int Count(T itemToCompare) 
        {
            int count = 0;

            foreach (var item in items)
            {
                if (item.CompareTo(itemToCompare) > 0) 
                {
                    count++;
                }
            }            
            return count;
        }
    }
}
