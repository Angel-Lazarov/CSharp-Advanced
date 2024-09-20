namespace EvenLines
{
    using System;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {

            using (StreamReader sr = new StreamReader(inputFilePath))
            {
                int lineNumber = 0;
                StringBuilder sb = new StringBuilder();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    if (lineNumber % 2 == 0)
                    {
                        char[] lineChars = line.ToCharArray();

                        for (int i = 0; i < lineChars.Length; i++)
                        {
                            if (lineChars[i] == '-' || lineChars[i] == ',' || lineChars[i] == '.' || lineChars[i] == '!'
                                || lineChars[i] == '?')
                            {
                                lineChars[i] = '@';
                            }
                        }

                        string newLine = new string(lineChars);
                        string[] newString = newLine.Split(' ');
                        string[] reversedLine = newString.Reverse().ToArray();
                        for (int j = 0; j < reversedLine.Length; j++)
                        {
                            sb.Append(reversedLine[j] + " ");
                        }
                        sb.Append('\n');
                    }
                    lineNumber++;
                }

                string output = sb.ToString();
                return output;
            }
        }

    }
}
