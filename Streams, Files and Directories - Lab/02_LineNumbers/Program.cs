namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {

            using (StreamReader streamReader = new StreamReader(inputFilePath))
            {
                int number = 0;

                using (StreamWriter streamWriter = new StreamWriter(outputFilePath))
                {

                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        streamWriter.WriteLine($"{++number}. {line}");
                    }
                }
            }
        }
    }
}
