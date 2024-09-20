namespace LineNumbers
{
    using System;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] inputLines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < inputLines.Length; i++)
            {
                int lettersCount = inputLines[i].Where(char.IsLetter).Count();
                int marksCount = inputLines[i].Where(char.IsPunctuation).Count();
                inputLines[i] = $"Line {i + 1}: {inputLines[i]} ({lettersCount})({marksCount})";

            }
            File.WriteAllLines(outputFilePath, inputLines);
        }
    }
}