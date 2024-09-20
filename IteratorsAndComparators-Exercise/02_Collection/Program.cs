using Collection;

List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();

ListyIterator<string> listyIterator = new ListyIterator<string>(elements);

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
        else if (command == "PrintAll") 
        {
            foreach (var element in listyIterator)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }

}
catch (Exception exeption)
{

    Console.WriteLine(exeption.Message);
}