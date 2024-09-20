int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

int jRow = 0;
int jCol = 0;
int enemy = 0;
int armor = 300;


//input
for (int row = 0; row < matrix.GetLength(0); row++)
{
    string line = Console.ReadLine();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = line[col];
        if (matrix[row, col] == 'J')
        {
            jRow = row;
            jCol = col;
        }
        if (matrix[row, col] == 'E') { enemy++; }
    }
}

while (true)
{

    string command = Console.ReadLine();

    matrix[jRow, jCol] = '-';

    if (command == "up")
    {
        jRow--;

        if (matrix[jRow, jCol] == '-')
        {
            continue;
        }
        else if (matrix[jRow, jCol] == 'E')
        {
            enemy--;
            matrix[jRow, jCol] = '-';

            if (enemy == 0)
            {
                matrix[jRow, jCol] = 'J';
                break;

            }
            else if (enemy > 0)
            {
                armor -= 100;
                if (armor == 0)
                {
                    matrix[jRow, jCol] = 'J';
                    break;
                }
            }
        }
        else if (matrix[jRow, jCol] == 'R') 
        {
            armor = 300;
            matrix[jRow, jCol] = '-';
        }
    }


    else if (command == "down") 
    {
        jRow++;
        if (matrix[jRow, jCol] == '-')
        {
            continue;
        }
        else if (matrix[jRow, jCol] == 'E')
        {
            enemy--;
            matrix[jRow, jCol] = '-';

            if (enemy == 0)
            {
                matrix[jRow, jCol] = 'J';
                break;

            }
            else if (enemy > 0)
            {
                armor -= 100;
                if (armor == 0)
                {
                    matrix[jRow, jCol] = 'J';
                    break;
                }
            }
        }
        else if (matrix[jRow, jCol] == 'R')
        {
            armor = 300;
            matrix[jRow, jCol] = '-';
        }
    }
    else if (command == "left")
    {
        jCol--;
        if (matrix[jRow, jCol] == '-')
        {
            continue;
        }
        else if (matrix[jRow, jCol] == 'E')
        {
            enemy--;
            matrix[jRow, jCol] = '-';

            if (enemy == 0)
            {
                matrix[jRow, jCol] = 'J';
                break;

            }
            else if (enemy > 0)
            {
                armor -= 100;
                if (armor == 0)
                {
                    matrix[jRow, jCol] = 'J';
                    break;
                }
            }
        }
        else if (matrix[jRow, jCol] == 'R')
        {
            armor = 300;
            matrix[jRow, jCol] = '-';
        }


    }
    else if (command == "right")
    {
        jCol++;
        if (matrix[jRow, jCol] == '-')
        {
            continue;
        }
        else if (matrix[jRow, jCol] == 'E')
        {
            enemy--;
            matrix[jRow, jCol] = '-';

            if (enemy == 0)
            {
                matrix[jRow, jCol] = 'J';
                break;

            }
            else if (enemy > 0)
            {
                armor -= 100;
                if (armor == 0)
                {
                    matrix[jRow, jCol] = 'J';
                    break;
                }
            }
        }
        else if (matrix[jRow, jCol] == 'R')
        {
            armor = 300;
            matrix[jRow, jCol] = '-';
        }

    }
}


if (enemy == 0) 
{
    Console.WriteLine($"Mission accomplished, you neutralized the aerial threat!");
}
if (armor == 0) 
{
    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jRow}, {jCol}]!");
}




Print(matrix);


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