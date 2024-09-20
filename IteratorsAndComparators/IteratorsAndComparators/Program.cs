using IteratorsAndComparators;

    Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
    Book bookTwo = new Book("The Documents in the Case", 2002,
        "Dorothy Sayers", "Robert Eustace");
    Book bookThree = new Book("The Documents in the Case (old)", 1930);

    Library libraryOne = new Library();
    Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

var books = libraryTwo.ToArray();
IComparer<Book> comparer = new BookComparator();
Array.Sort(books, comparer);

foreach (var book in libraryTwo)
    {
        Console.WriteLine(book);
    }
