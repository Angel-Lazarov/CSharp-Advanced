using System.ComponentModel;

int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];


for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowValues = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowValues[col];
    }
}


// 1,2 2,1 2,0

//string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

//for (int i = 0; i < input.Length; i++) 
//{
//string bombCoordinates = input[i];
//    int bombRow = int.Parse(bombCoordinates[0].ToString());
//    int bombCol = int.Parse(bombCoordinates[2].ToString());
//    int bombValue = matrix[bombRow, bombCol];
//    Explode(bombRow, bombCol, matrix);
//}

int[] indexes = Console.ReadLine().Split(new char[] {' ', ','}).Select(int.Parse).ToArray();

for (int i = 0; i < indexes.Length; i+=2)
{
    int bombRow = indexes[i];
    int bombCol = indexes[i+1];
    Explode(bombRow, bombCol, matrix);
}



int allivedCells = 0;
int cellSum = 0;

for (int row = 0; row < matrix.GetLength(0); row++) 
{
    for (int col = 0; col < matrix.GetLength(1); col++) 
    {
        if (matrix[row, col] > 0) 
        {
            allivedCells++;
            cellSum += matrix[row, col];
        }
    }
}

Console.WriteLine($"Alive cells: {allivedCells}");
Console.WriteLine($"Sum: {cellSum}");

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}



void Explode(int bombRow, int bombCol, int[,] matrix)
{
    int bombPower = matrix[bombRow, bombCol];
    if (bombPower > 0)
    {
        if (IsInRange(matrix, bombRow - 1, bombCol) && IsCellAlive(matrix,bombRow - 1, bombCol)) 
        { 
            matrix[bombRow - 1, bombCol] -= bombPower; 
        }
        if (IsInRange(matrix, bombRow - 1, bombCol - 1) && IsCellAlive(matrix, bombRow - 1, bombCol - 1))
        {
            matrix[bombRow - 1, bombCol - 1] -= bombPower;
        }
        if (IsInRange(matrix, bombRow, bombCol - 1) && IsCellAlive(matrix, bombRow, bombCol - 1))
        { 
            matrix[bombRow, bombCol - 1] -= bombPower;
        }

        if (IsInRange(matrix, bombRow + 1, bombCol - 1) && IsCellAlive(matrix, bombRow + 1, bombCol - 1))
        { 
            matrix[bombRow +1, bombCol - 1] -= bombPower;
        }

        if (IsInRange(matrix, bombRow + 1, bombCol) && IsCellAlive(matrix, bombRow + 1, bombCol))
        { 
            matrix[bombRow + 1, bombCol] -= bombPower;
        }
        if (IsInRange(matrix, bombRow + 1, bombCol + 1) && IsCellAlive(matrix, bombRow + 1, bombCol + 1))
        { 
            matrix[bombRow + 1, bombCol + 1] -= bombPower;
        }
        if (IsInRange(matrix, bombRow, bombCol + 1) && IsCellAlive(matrix, bombRow, bombCol + 1))
        {
            matrix[bombRow, bombCol + 1] -= bombPower;
        }

        if (IsInRange(matrix, bombRow - 1, bombCol + 1) && IsCellAlive(matrix, bombRow - 1, bombCol + 1))
        { 
            matrix[bombRow - 1, bombCol + 1] -= bombPower;
        }

        matrix[bombRow, bombCol] = 0;
    }
}

static bool IsInRange(int[,] matrix, int row, int col) 
{
    return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1); 
}

static bool IsCellAlive(int[,] matrix, int row, int col) 
{
    return matrix[row, col] > 0;
}
