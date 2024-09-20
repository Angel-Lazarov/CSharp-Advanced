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

int sumFirstDiagonal = 0;
int sumSecondDiagonal = 0;

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumFirstDiagonal += matrix[i, i];
        sumSecondDiagonal += matrix[i, matrix.GetLength(0) - 1 - i];

    }
}

Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));