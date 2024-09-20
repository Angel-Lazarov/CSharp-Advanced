int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowValues[col];
    }
}


int sum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    sum += matrix[row, row];
}
Console.WriteLine(sum);




//print second diagonal
//for (int row = 0; row < matrix.GetLength(0); row++) 
//{

//    Console.WriteLine(matrix[row, matrix.GetLength(0) - 1 - row]);
//}
