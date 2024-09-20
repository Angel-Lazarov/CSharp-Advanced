int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
char[,] matrix = new char[dimensions[0], dimensions[1]];

int playerRow = 0;
int playerCol = 0;

for (int row = 0; row < dimensions[0]; row++)
{
    char[] rowValues = Console.ReadLine().ToCharArray();

    for (int col = 0; col < dimensions[1]; col++)
    {
        matrix[row, col] = rowValues[col];

        if (rowValues[col] == 'P')
        {
            playerRow = row;
            playerCol = col;
        }
    }
}

char[] moves = Console.ReadLine().ToCharArray();

foreach (char command in moves)
{
    int nextRow = 0;
    int nextCol = 0;

    if (command == 'U')
    {
        nextRow = -1;
    }
    else if (command == 'D')
    {
        nextRow = 1;
    }
    else if (command == 'L')
    {
        nextCol = -1;
    }
    else if (command == 'R')
    {
        nextCol = 1;
    }

    bool dead = false;
    bool won = false;

    //player moves
    matrix[playerRow, playerCol] = '.';

    if (!IsInMatrix(matrix, playerRow + nextRow, playerCol + nextCol))
    {
        won = true;
    }
    else if (!IsBunny(matrix, playerRow + nextRow, playerCol + nextCol))
    {
        playerRow += nextRow;
        playerCol += nextCol;
        matrix[playerRow, playerCol] = 'P';
    }
    else if (IsBunny(matrix, playerRow + nextRow, playerCol + nextCol))
    {
        playerRow += nextRow;
        playerCol += nextCol;
        dead = true;
    }

    //buny moves
    List<int[]> bunnyCoordinates = new List<int[]>();

    for (int row = 0; row < dimensions[0]; row++)
    {
        for (int col = 0; col < dimensions[1]; col++)
        {
            if (matrix[row, col] == 'B')
            {
                bunnyCoordinates.Add(new int[] { row, col });
            }
        }
    }

    foreach (var bunny in bunnyCoordinates)
    {
        int bunnyRow = bunny[0];
        int bunnyCol = bunny[1];

        if (IsInMatrix(matrix, bunnyRow - 1, bunnyCol))
        {
            if (matrix[bunnyRow - 1, bunnyCol] == 'P')
            {
                dead = true;
            }
            matrix[bunnyRow - 1, bunnyCol] = 'B';
        }

        if (IsInMatrix(matrix, bunnyRow, bunnyCol - 1))
        {
            if (matrix[bunnyRow, bunnyCol - 1] == 'P')
            {
                dead = true;
            }
            matrix[bunnyRow, bunnyCol - 1] = 'B';
        }

        if (IsInMatrix(matrix, bunnyRow + 1, bunnyCol))
        {
            if (matrix[bunnyRow + 1, bunnyCol] == 'P')
            {
                dead = true;
            }
            matrix[bunnyRow + 1, bunnyCol] = 'B';
        }

        if (IsInMatrix(matrix, bunnyRow, bunnyCol + 1))
        {
            if (matrix[bunnyRow, bunnyCol + 1] == 'P')
            {
                dead = true;
            }
            matrix[bunnyRow, bunnyCol + 1] = 'B';
        }
    }

    if (won)
    {
        PrintMatrix(matrix);
        Console.WriteLine($"won: {playerRow} {playerCol}");
        Environment.Exit(0);
    }
    if (dead)
    {
        PrintMatrix(matrix);
        Console.WriteLine($"dead: {playerRow} {playerCol}");
        Environment.Exit(0);
    }
}


static void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}

static bool IsBunny(char[,] matrix, int row, int col)
{
    return matrix[row, col] == 'B';
}

static bool IsInMatrix(char[,] matrix, int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
}