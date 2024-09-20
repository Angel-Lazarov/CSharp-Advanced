int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

for (int row = 0; row < matrix.Length; row++)
{
    int[] rowValue = Console.ReadLine().Split().Select(int.Parse).ToArray();

    matrix[row] = rowValue;
}


//Print Jagged Array
//for (int row = 0; row < jagged.Length; row++)
//{
//    for (int col = 0; col < jagged[row].Length; col++) 
//    {
//        Console.Write(jagged[row][col] + " ");
//    }
//    Console.WriteLine();
//}

string[] input = Console.ReadLine().Split();

while (input[0] != "END")
{
        int row = int.Parse(input[1]);  
        int col = int.Parse(input[2]);
        int value = int.Parse(input[3]);

    if (row < 0 || col < 0 || row >= matrix.Length || col >= matrix[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
    }
    else 
    {
        if (input[0] == "Add")
        {
            matrix[row][col] += value;
        }
        else if (input[0] == "Subtract")
        {
            matrix[row][col] -= value;
        }
    }

    input = Console.ReadLine().Split();
}
//Print Jagged Array
for (int row = 0; row < matrix.Length; row++) 
{
    for (int col = 0; col < matrix[row].Length; col++) 
    {
        Console.Write(matrix[row][col] + " ");
    }
    Console.WriteLine();
}