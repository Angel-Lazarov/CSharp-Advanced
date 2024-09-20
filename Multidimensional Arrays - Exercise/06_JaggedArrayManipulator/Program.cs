
int rowCount = int.Parse(Console.ReadLine());
int[][] jagged = new int[rowCount][];


for (int i = 0; i < jagged.Length; i++)
{
    int[] rowValue = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    jagged[i] = rowValue;
}

for (int row = 0; row < jagged.Length - 1; row++)
{
    if (jagged[row].Length == jagged[row + 1].Length)
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] *= 2;
            jagged[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] /= 2;
        }

        for (int col = 0; col < jagged[row + 1].Length; col++)
        {
            jagged[row + 1][col] /= 2;
        }
    }
}

string input = string.Empty;

while ((input = Console.ReadLine().ToLower()) != "end")
{
    string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);



    if (command[0] == "add" && command.Length == 4)
    {
        int row = int.Parse(command[1]);
        int col = int.Parse(command[2]);

        if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length) 
        {
            jagged[row][col] += int.Parse(command[3]);
        }
    }
    else if (command[0] == "subtract" && command.Length == 4) 
    {
        int row = int.Parse(command[1]);
        int col = int.Parse(command[2]);

        if (row >= 0 && row < rowCount && col >= 0 && col <= jagged[row].Length - 1)
        {
            jagged[row][col] -= int.Parse(command[3]);
        }
    }
}

foreach (var item in jagged)
{
    Console.WriteLine(string.Join(" ", item));
}