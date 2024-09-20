/*
 5
up right right up right

* * * c *
* * * e *
* * c * *
s * * c *
* * c * *
 
 */

int size = int.Parse(Console.ReadLine());
string[] commandInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
char[,] matrix = new char[size, size];

int rowIndex = 0;
int colIndex = 0;

int remainingCoals = 0;

//fill up matrix
for (int row = 0; row < size; row++)
{
    char[] rowValue = Console.ReadLine().
        Split(" ", StringSplitOptions.RemoveEmptyEntries).
        Select(char.Parse).ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = rowValue[col];

        if (rowValue[col] == 's')
        {
            rowIndex = row;
            colIndex = col;
        }
        else if (rowValue[col] == 'c')
        {
            remainingCoals++;
        }
    }
}

for (int i = 0; i < commandInfo.Length; i++)
{
    string command = commandInfo[i];

    int nextRow = 0;
    int nextCol = 0;

    if (command == "up")
    {
        nextRow = -1;
    }
    else if (command == "down")
    {
        nextRow = 1;
    }
    else if (command == "left")
    {
        nextCol = -1;
    }
    else if (command == "right")
    {
        nextCol = 1;
    }

    if (IsInRange(matrix, rowIndex + nextRow, colIndex + nextCol))
    {
        rowIndex += nextRow;
        colIndex += nextCol;

        if (matrix[rowIndex, colIndex] == 'e')
        {
            Console.WriteLine($"Game over! ({rowIndex}, {colIndex})");
            Environment.Exit(0);
        }
        else if (matrix[rowIndex, colIndex] == 'c')
        {
            remainingCoals--;
            matrix[rowIndex, colIndex] = '*';

            if (remainingCoals == 0)
            {
                Console.WriteLine($"You collected all coals! ({rowIndex}, {colIndex})");
                Environment.Exit(0);
            }
        }
    }
}

Console.WriteLine($"{remainingCoals} coals left. ({rowIndex}, {colIndex})");

static bool IsInRange(char[,] matrix, int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0)
        && col >= 0 && col < matrix.GetLength(1);
}