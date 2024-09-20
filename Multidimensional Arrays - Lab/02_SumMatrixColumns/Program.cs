//Get matrix dimensions
int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
int[,] matrix = new int[rows, cols];

//fillup the matrix from the console
for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowValue = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowValue[col];
    }
}
//print the matrix by rows

//for (int row = 0; row < matrix.GetLength(0); row++) 
//{
//    for (int col = 0; col < matrix.GetLength(1); col++) 
//    {
//        Console.Write(matrix[row,col] + " ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("----------------------");
//Pass true columns


for (int col = 0; col < matrix.GetLength(1); col++)
{
    int sum = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        //Console.Write(matrix[row, col] + " ");
        sum += matrix[row, col];
    }
    Console.WriteLine(sum);
}
