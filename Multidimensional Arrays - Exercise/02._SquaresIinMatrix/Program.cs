
int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray(); ;

char[,] matrix = new char[input[0], input[1]];


for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] rowValue = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] =rowValue[col];
    }
}

int found = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        char elemetn = matrix[row, col];

            if (matrix[row, col] == matrix[row, col + 1] &&
                matrix[row, col] == matrix[row + 1, col] &&
                matrix[row, col] == matrix[row + 1, col + 1])
            {
                found++;
            }
    }
}

Console.WriteLine(found);
