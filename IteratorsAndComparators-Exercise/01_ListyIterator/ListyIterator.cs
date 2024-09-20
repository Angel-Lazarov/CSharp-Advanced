
namespace ListyIterator
{
    public class ListyIterator1<T>
    {
        private List<T> elements;
        private int index = 0;

        public ListyIterator1(List<T> list)
        {
            this.elements = list.ToList();
        }


        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            return false;

        }

        public bool HasNext()
        {
            if (index +1 < elements.Count)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (elements.Count == 0) 
            {
                throw new Exception("Invalid Operation!");
            }
                Console.WriteLine(elements[index]);
        }

    }
}
