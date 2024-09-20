namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader inputStreamReader = new StreamReader(inputFilePath))
            {
                int lineIndex = 0;

                using (StreamWriter outputStreamWriter = new StreamWriter(outputFilePath))
                {
                    while (!inputStreamReader.EndOfStream)
                    {
                        string line = inputStreamReader.ReadLine();
                        if (lineIndex % 2 == 1)
                        {
                            outputStreamWriter.WriteLine(line);
                        }
                        lineIndex++;
                    }
                }
            }
        }
    }
}
