int size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size, size];

if (size < 3)
{
    Console.WriteLine("0");
    return;
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] rowValue = Console.ReadLine().ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowValue[col];

    }
}

int removedKnights = 0;

while (true)
{
    int countMostAttacking = 0;
    int rowMostAttacking = 0;
    int colMostAttacking = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            char currentCell = matrix[row, col];

            if (currentCell == 'K')
            {
                int currentKnight = AttackingTargets(row, col, matrix);

                if (currentKnight > countMostAttacking)
                {
                    countMostAttacking = currentKnight;
                    rowMostAttacking = row;
                    colMostAttacking = col;
                }
            }
        }
    }

    if (countMostAttacking == 0) { break; }
    else
    {
        matrix[rowMostAttacking, colMostAttacking] = '0';
        removedKnights++;
    }
}

Console.WriteLine(removedKnights);

static int AttackingTargets(int row, int col, char[,] matrix)
{
    int targets = 0;

    // verticaly up-right
    if (IsCellValid(row - 2, col + 1, matrix.GetLength(0)))
    {
        if (matrix[row - 2, col + 1] == 'K')
        {
            targets++;
        }
    }

    // verticaly up-left
    if (IsCellValid(row - 2, col - 1, matrix.GetLength(0)))
    {
        if (matrix[row - 2, col - 1] == 'K')
        {
            targets++;
        }
    }

    // verticaly down-right
    if (IsCellValid(row + 2, col + 1, matrix.GetLength(0)))
    {
        if (matrix[row + 2, col + 1] == 'K')
        {
            targets++;
        }
    }


    // verticaly down-left
    if (IsCellValid(row + 2, col - 1, matrix.GetLength(0)))
    {
    if (matrix[row + 2, col - 1] == 'K')
        {
            targets++;
        }
    }
    // horizontaly left up
    if (IsCellValid(row - 1, col - 2, matrix.GetLength(0)))
    {
        if (matrix[row - 1, col - 2] == 'K')
        {
            targets++;
        }
    }

    // horizontaly left down
    if (IsCellValid(row + 1, col - 2, matrix.GetLength(0)))
    {
        if (matrix[row + 1, col - 2] == 'K')
        {
            targets++;
        }
    }

    // horizontaly rigth up
    if (IsCellValid(row - 1, col + 2, matrix.GetLength(0)))
    {
        if (matrix[row - 1, col + 2] == 'K')
        {
            targets++;
        }
    }
    // horizontaly rigth down
    if (IsCellValid(row + 1, col + 2, matrix.GetLength(0)))
    {
    if (matrix[row + 1, col + 2] == 'K')
        {
            targets++;
        } }
    return targets;
}

static bool IsCellValid(int row, int col, int size)
{
    return (row >= 0 && row < size && col >= 0 && col < size);
}