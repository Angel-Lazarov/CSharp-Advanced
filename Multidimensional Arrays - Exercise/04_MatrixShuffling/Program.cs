string[,] matrix = BuildMatrix();
string input = string.Empty;

while ((input=Console.ReadLine().ToLower()) != "end")
{
    string[] commandInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if(IsValidCommand(matrix, commandInfo))
    {
        int firsCellRow = int.Parse(commandInfo[1]);
        int firsCellcol = int.Parse(commandInfo[2]);
        int secondCellrow = int.Parse(commandInfo[3]);
        int secondCellcol = int.Parse(commandInfo[4]);


            string temp = matrix[firsCellRow, firsCellcol];

            matrix[firsCellRow, firsCellcol] = matrix[secondCellrow, secondCellcol];
            matrix[secondCellrow, secondCellcol] = temp;

            PrintMatrix(matrix);
    }
    else 
    {
        Console.WriteLine("Invalid input!");
    }
}

static string[,] BuildMatrix()
{
    int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    string[,] matrix = new string[dimensions[0], dimensions[1]];

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        string[] rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = rowValues[col];
        }
    }
    return matrix; ;
}

static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}

static bool IsValidCommand(string[,] matrix, string[] tokens) 
{
    bool isValid =
        tokens[0] == "swap" && tokens.Length == 5
        && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < matrix.GetLength(0)
        && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < matrix.GetLength(1)
        && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < matrix.GetLength(0)
        && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < matrix.GetLength(1);
       
     return isValid; 
}

//static bool IsValidCoordinate(int[,] matrix, int row, int col) 
//{
//    bool isValid = false;
//    if (row > 0 && col > 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1))
//    {
//        isValid = true;
//    }
//    return isValid;
//}