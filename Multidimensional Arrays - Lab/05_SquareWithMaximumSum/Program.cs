﻿int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] matrix = new int[input[0], input[1]];


for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowValues = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++) 
    {
        matrix[row,col] = rowValues[col];
    }
}

int maxSum = int.MinValue;
int bestRow = 0;
int bestCol = 0;


for (int row = 0; row < matrix.GetLength(0) - 1; row++) 
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int sum = matrix[row, col] + matrix[row, col + 1] +   matrix[row + 1, col] + matrix[row+1, col + 1];
       
        if (sum > maxSum) 
        {
            maxSum = sum;
            bestRow = row;
            bestCol = col;
        }
    }
}


Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow,bestCol + 1]}");
Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]}");
Console.WriteLine(maxSum);