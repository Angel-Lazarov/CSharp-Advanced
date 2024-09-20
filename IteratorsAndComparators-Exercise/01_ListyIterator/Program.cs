using ListyIterator;

List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();

ListyIterator1<string> listyIterator = new ListyIterator1<string>(elements);

string command = string.Empty;

try
{
    while ((command = Console.ReadLine()) != "END")
    {

        if (command == "Move")
        {
            Console.WriteLine(listyIterator.Move());
        }
        else if (command == "HasNext")
        {
            Console.WriteLine(listyIterator.HasNext());
        }
        else if (command == "Print")
        {
            listyIterator.Print();
        }
    }

}
catch (Exception exeption)
{

    Console.WriteLine(exeption.Message);
}