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
            char[] marks = new char[] { '-', ',', '.', '!', '?', '\'' };
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputLines.Length; i++)
            {
                int lettersCount = 0;
                int marksCount = 0;
                string line = inputLines[i];
                foreach (char ch in line)
                {
                    if (marks.Contains(ch))
                    {
                        marksCount++;
                    }
                    if (char.IsLetter(ch))
                    {
                        lettersCount++;
                    }

                }
                line = line.Insert(0, $"Line {i + 1}: ");

                sb.AppendLine($"{line} ({lettersCount})({marksCount})");

                //Console.WriteLine($"{line} ({lettersCount})({marksCount})");
            }
            File.AppendAllText(outputFilePath, sb.ToString());

        }
    }
}
