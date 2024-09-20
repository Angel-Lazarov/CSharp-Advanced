int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

char[,] matrix = new char[dimensions[0], dimensions[1]];

string snake = Console.ReadLine();

int currentIndex = 0;


for (int row = 0; row < matrix.GetLength(0); row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (currentIndex > snake.Length - 1)
            {
                currentIndex = 0;
            }

            matrix[row, col] = snake[currentIndex];
            currentIndex++;
        }
    }
    else
    {
        for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
        {
            if(currentIndex == snake.Length)
            {
                currentIndex = 0;
            }

            matrix[row, col] = snake[currentIndex];
            currentIndex++;
        }
    }
}
PrintMatrix(matrix);

static void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            //Thread.Sleep(200);
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}
