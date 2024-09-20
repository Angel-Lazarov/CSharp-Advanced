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
                char[] symbols = new char[] { '-', ',','.', '!','?' };
                int lineNumber = 0;
                StringBuilder sb = new StringBuilder();


                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    if (lineNumber % 2 == 0) 
                    {

                        foreach (char ch in line)
                        {
                            if (symbols.Contains(ch)) 
                            {
                                line = line.Replace(ch, '@');
                            }
                        }

                        string[] reversed = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
                        sb.AppendLine(string.Join(" ", reversed));
                    }
                    lineNumber++;
                }

                return sb.ToString();
            }
        }

    }
}
