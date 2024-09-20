
using System.Collections;
using System.Runtime.CompilerServices;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            this.books.Sort();
            for (int i = 0; i < this.books.Count; i++) 
            {
               yield return this.books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

         

        //public IEnumerator<Book> GetEnumerator()
        //{
        //    return new LibraryIterator(this.books);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        //class LibraryIterator : IEnumerator<Book>
        //{
        //    private int index = -1;
        //    private List<Book> books;

        //    public LibraryIterator(List<Book> books)
        //    {
        //        this.books = books;
        //        Reset();
        //    }

        //    public Book Current => books[index];

        //    object IEnumerator.Current => Current;

        //    public void Dispose()
        //    {
        //    }

        //    public bool MoveNext()
        //    {
        //        index++;
        //        return index < books.Count;

        //    }

        //    public void Reset()
        //    {
        //        index = -1;
        //    }
        //}



    }
}
