int[] sizes = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];

int mRow = 0;
int mCol = 0;
int chees = 0;

char[,] matrix = new char[rows, cols];

//input
for (int row = 0; row < rows; row++) 
{
    string input = Console.ReadLine();
    for (int col = 0; col < cols; col++) 
    {
        matrix[row, col] = input[col];

        if (matrix[row, col] == 'M') 
        {
            mRow = row;
            mCol = col;
            matrix[row, col] = '*';
        }

        if (matrix[row, col] == 'C') 
        {
            chees++;
        }
    }
}

string command = string.Empty;
while ((command=Console.ReadLine())!="danger") 
{

    if (command == "up")
    {
        if (mRow == 0) 
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }

        if (matrix[mRow - 1, mCol] == '@') 
        {
            continue;
        }

        mRow--;
    }
    else if (command == "down") 
    {
        if (mRow == matrix.GetLength(0) - 1)
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }

        if (matrix[mRow + 1, mCol] == '@')
        {
            continue;
        }

        mRow++;
    }
    else if (command == "right")
    {
        if (mCol == matrix.GetLength(1) - 1)
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }

        if (matrix[mRow, mCol + 1] == '@')
        {
            continue;
        }

        mCol++;
    }
    else if (command == "left")
    {
        if (mCol == 0)
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }

        if (matrix[mRow, mCol - 1] == '@')
        {
            continue;
        }

        mCol--;
    }

    if (matrix[mRow, mCol] == 'C')
    {
        matrix[mRow, mCol] = '*';
        chees--;

        if (chees == 0)
        {
            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
            break;
        }
    }

    else if (matrix[mRow, mCol] == 'T') 
    {
        Console.WriteLine("Mouse is trapped!");
        break;
    }
    else if (matrix[mRow, mCol] == '*')
    {
        continue;
    }
}

if (command == "danger")
{
    Console.WriteLine("Mouse will come back later!");
}

matrix[mRow, mCol] = 'M';

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++) 
    {
        Console.Write(matrix[row , col]);
    }
    Console.WriteLine();
}
