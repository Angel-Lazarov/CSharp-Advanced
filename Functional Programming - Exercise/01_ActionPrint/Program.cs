
List<string> words = Console.ReadLine().Split().ToList();

Action<List<string>> printer = words =>
{
    Console.WriteLine(string.Join(Environment.NewLine, words));
    //foreach (var word in words)
    //{
    //    Console.WriteLine(word);
    //}
};
printer(words);


//int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


//Action<int[]> sum = numbers => Console.WriteLine(numbers.Sum());

//sum(numbers);