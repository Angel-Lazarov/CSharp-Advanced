

char[,] matrix = new char[4, 5];

int mouseRow = 0;
int mouseCol = 0;
int cheeseOnBoard = 0;


//input
for (int row = 0; row < matrix.GetLength(0); row++)
{
    string line = Console.ReadLine();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = line[col];
        if (matrix[row, col] == 'M')
        {
            mouseRow = row;
            mouseCol = col;
        }
        if (matrix[row, col] == 'C') { cheeseOnBoard++; }
    }
}


Print(matrix);





static void Print(char[,] matrix)
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



bool isInrange =  !isInArea(mouseRow, mouseCol, matrix);

    static bool isInArea(int row, int col, char[,] matrix)
{
    return (row >= 0 && row < matrix.GetLength(0)
         && col >= 0 && col < matrix.GetLength(1));
}