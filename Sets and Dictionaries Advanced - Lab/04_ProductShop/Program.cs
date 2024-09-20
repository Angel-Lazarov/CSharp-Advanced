Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
string input = string.Empty;

while ((input = Console.ReadLine()) != "Revision")
{
    string[] tokens = input.Split(", ").ToArray();
    string shopName = tokens[0];
    string product = tokens[1];
    string price = tokens[2];

    if (!shops.ContainsKey(shopName))
    {
        shops.Add(shopName, new Dictionary<string, double>());
    }

    if (!shops[shopName].ContainsKey(product))
    {
        shops[shopName].Add(product, 0);
    }

    shops[shopName][product] = double.Parse(price);
}

Dictionary<string, Dictionary<string, double>> SortedShops = shops.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

//foreach (var (name, products) in shops.OrderBy(pair=>pair.Key)) 
//{
//    Console.WriteLine($"{name}->");

//    foreach (var product in products)
//    {
//        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
//    }
//}

foreach (var (name, products) in SortedShops)
{
    Console.WriteLine($"{name}->");

    foreach (var product in products)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}