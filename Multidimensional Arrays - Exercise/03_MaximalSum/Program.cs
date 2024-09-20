int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[,] matrix = new int[dimensions[0], dimensions[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowValues[col];
    }
}

int maxSum = int.MinValue;
int maxRowIndex = 0;
int maxColIndex = 0;

    for (int row = 0; row < matrix.GetLength(0) - 2; row++)
    {
        for (int col = 0; col < matrix.GetLength(1) - 2; col++)
        {

            int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                         matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                         matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxRowIndex = row;
                maxColIndex = col;
            }
        }
    }

    Console.WriteLine("Sum = " + maxSum);
    //Console.WriteLine(matrix[maxRowIndex, maxColIndex] + " " + matrix[maxRowIndex, maxColIndex + 1] + " " + matrix[maxRowIndex, maxColIndex + 2]);
    //Console.WriteLine(matrix[maxRowIndex + 1, maxColIndex] + " " + matrix[maxRowIndex + 1, maxColIndex + 1] + " " + matrix[maxRowIndex + 1, maxColIndex + 2]);
    //Console.WriteLine(matrix[maxRowIndex + 2, maxColIndex] + " " + matrix[maxRowIndex + 2, maxColIndex + 1] + " " + matrix[maxRowIndex + 2, maxColIndex + 2]);

    for (int row = maxRowIndex; row < maxRowIndex + 3; row++)
    {
        for (int col = maxColIndex; col < maxColIndex + 3; col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }

/*

4 5
1 5 5 2 4
2 1 4 14 3
3 7 11 2 8
4 8 12 16 4
 
 */