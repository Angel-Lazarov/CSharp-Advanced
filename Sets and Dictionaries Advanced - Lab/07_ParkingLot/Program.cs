using System.Text.RegularExpressions;

HashSet<string> parking = new HashSet<string>();
string input = string.Empty;

while ((input=Console.ReadLine()) != "END") 
{
    //string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

    string[] tokens = Regex.Split(input, ", ");

    switch (tokens[0]) 
    {
        case "IN":
            parking.Add(tokens[1]);
            break;
        case "OUT":
            parking.Remove(tokens[1]);
            break;
    }
}

if (parking.Count > 0) 
{
    Console.WriteLine(string.Join("\n", parking));
}
else 
{
    Console.WriteLine("Parking Lot is Empty");
}