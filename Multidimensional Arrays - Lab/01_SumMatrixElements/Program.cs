//Create Matrix by given dimensions
int[] matrixDimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = matrixDimensions[0];
int cols = matrixDimensions[1];
int[,] matrix =  new int[rows, cols];

int sum = 0;

//Read matrix from the console
for (int row = 0; row < rows; row++)
{
    int[] rowValue = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowValue[col];

    }

}

//Print the matrix on the console
//for (int row = 0; row < matrix.GetLength(0); row++)
//{
//    for (int col = 0; col < matrix.GetLength(1); col++)
//    {
//        Console.Write(matrix[row, col] + " ");
//    }
//    Console.WriteLine();
//}

// pass true all elements in the matrix
foreach (int row in matrix)
{
    //Console.WriteLine(row);
    sum += row;
}
//Console.WriteLine($"Length = [Returns all elements count in the matrix]: {matrix.Length}");
//Console.WriteLine($"GetLength(0) = [rows]): {matrix.GetLength(0)}");
//Console.WriteLine($"GetLength(1) = [cols]): {matrix.GetLength(1)}");
Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);