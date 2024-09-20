int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] matrix = new int[input[0], input[1]];


for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowValues = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowValues[col];
    }
}

int maxSum = int.MinValue;
int bestRow = 0;
int bestCol = 0;

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

for (int row = 0; row < matrix.GetLength(0) - 1 - n; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1 - m; col++)
    {
        for (int r = row; r < n; r++ )
        {
            int sum = 0;

            for (int c = col; c < m; c++)
            {
                if (r < matrix.GetLength(0) - 1 - n && c < matrix.GetLength(1) - 1 - m)
                {
                    sum += matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2]
                       + matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2]
                       + matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2];
                }

            }
            Console.WriteLine(sum);
        }






    }
}
/*
 
8, 5
1 1 1 1 1
1 1 1 0 0
1 1 1 1 1
0 0 0 0 0
0 0 0 0 0
0 0 0 0 0
0 0 0 0 0
0 0 0 0 0
3
4

 */