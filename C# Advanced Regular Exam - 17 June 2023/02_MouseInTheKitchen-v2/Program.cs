int[] sides = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

int n = sides[0];

int m = sides[1];
char[,] matrix = new char[n, m];
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


string input = string.Empty;
while ((input = Console.ReadLine()) != "danger")
{
    //matrix[mouseRow, mouseCol] = '*';
    if (input == "up")
    {
        mouseRow -= 1;
        if (!isInArea(mouseRow, mouseCol, matrix))
        {
            Console.WriteLine($"No more cheese for tonight!");
            break;
        }

        if (matrix[mouseRow, mouseCol] == 'C')
        {
            cheeseOnBoard--;
            matrix[mouseRow + 1, mouseCol] = '*';
            matrix[mouseRow, mouseCol] = 'M';

            if (cheeseOnBoard == 0)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                break;
            }
        }

        else if (matrix[mouseRow, mouseCol] == 'T')
        {
            matrix[mouseRow + 1, mouseCol] = '*';
            Console.WriteLine("Mouse is trapped!");
            matrix[mouseRow, mouseCol] = 'M';
            break;
        }

        else if (matrix[mouseRow, mouseCol] == '@')
        {
            mouseRow += 1;
            continue;
        }

        else if (matrix[mouseRow, mouseCol] == '*')
        {
            matrix[mouseRow + 1, mouseCol] = '*';
            matrix[mouseRow, mouseCol] = 'M';
        }


    }
    else if (input == "down")
    {
        mouseRow += 1;
        if (!isInArea(mouseRow, mouseCol, matrix))
        {
            Console.WriteLine($"No more cheese for tonight!");
            break;
        }

        if (matrix[mouseRow, mouseCol] == 'C')
        {
            cheeseOnBoard--;
            matrix[mouseRow - 1, mouseCol] = '*';
            matrix[mouseRow, mouseCol] = 'M';

            if (cheeseOnBoard == 0)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                break;
            }
        }

        else if (matrix[mouseRow, mouseCol] == 'T')
        {
            matrix[mouseRow - 1, mouseCol] = '*';
            Console.WriteLine("Mouse is trapped!");
            matrix[mouseRow, mouseCol] = 'M';
            break;
        }

        else if (matrix[mouseRow, mouseCol] == '@')
        {
            mouseRow -= 1;
            continue;
        }

        else if (matrix[mouseRow, mouseCol] == '*')
        {
            matrix[mouseRow - 1, mouseCol] = '*';
            matrix[mouseRow, mouseCol] = 'M';
        }

    }
    else if (input == "right")
    {
        mouseCol += 1;
        if (!isInArea(mouseRow, mouseCol, matrix))
        {
            Console.WriteLine($"No more cheese for tonight!");
            break;
        }

        if (matrix[mouseRow, mouseCol] == 'C')
        {
            cheeseOnBoard--;
            matrix[mouseRow, mouseCol - 1] = '*';
            matrix[mouseRow, mouseCol] = 'M';

            if (cheeseOnBoard == 0)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                break;
            }
        }

        else if (matrix[mouseRow, mouseCol] == 'T')
        {
            matrix[mouseRow, mouseCol - 1] = '*';
            Console.WriteLine("Mouse is trapped!");
            matrix[mouseRow, mouseCol] = 'M';
            break;
        }

        else if (matrix[mouseRow, mouseCol] == '@')
        {
            mouseCol += 1;
            continue;
        }

        else if (matrix[mouseRow, mouseCol] == '*')
        {
            matrix[mouseRow, mouseCol - 1] = '*';
            matrix[mouseRow, mouseCol] = 'M';
        }


    }
    else if (input == "left")
    {
        mouseCol -= 1;
        if (!isInArea(mouseRow, mouseCol, matrix))
        {
            Console.WriteLine($"No more cheese for tonight!");
            break;
        }

        if (matrix[mouseRow, mouseCol] == 'C')
        {
            cheeseOnBoard--;
            matrix[mouseRow, mouseCol + 1] = '*';
            matrix[mouseRow, mouseCol] = 'M';

            if (cheeseOnBoard == 0)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                break;
            }
        }

        else if (matrix[mouseRow, mouseCol] == 'T')
        {
            matrix[mouseRow, mouseCol + 1] = '*';
            Console.WriteLine("Mouse is trapped!");
            matrix[mouseRow, mouseCol] = 'M';
            break;
        }

        else if (matrix[mouseRow, mouseCol] == '@')
        {
            mouseCol += 1;
            continue;
        }

        else if (matrix[mouseRow, mouseCol] == '*')
        {
            matrix[mouseRow, mouseCol + 1] = '*';
            matrix[mouseRow, mouseCol] = 'M';
        }

    }

    //Print(matrix);
}


if (input == "danger" && cheeseOnBoard > 0)
{
    Console.WriteLine($"Mouse will come back later!");
}

Print(matrix);


static bool isInArea(int row, int col, char[,] matrix)
{
    return (row >= 0 && row < matrix.GetLength(0)
         && col >= 0 && col < matrix.GetLength(1));
}



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