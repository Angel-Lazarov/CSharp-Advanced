int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string input = Console.ReadLine();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

char target = char.Parse(Console.ReadLine());
bool isFound = false;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == target)
        {
            isFound = true;
            Console.WriteLine($"({row}, {col})");
            break;
        }
    }

    if (isFound)
    {
        break;
    }
}

if (!isFound)
{
    Console.WriteLine($"{target} does not occur in the matrix");
}