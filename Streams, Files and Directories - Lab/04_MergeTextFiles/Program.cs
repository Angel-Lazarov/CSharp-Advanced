namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader sr1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader sr2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter sw = new StreamWriter(outputFilePath))
                    {
                        while (!sr1.EndOfStream || !sr2.EndOfStream)
                        {
                            if (!sr1.EndOfStream)
                            {
                                sw.WriteLine(sr1.ReadLine());
                            }
                            if (!sr2.EndOfStream)
                            {
                                sw.WriteLine(sr2.ReadLine());
                            }
                        }
                    }
                }
            }
        }
    }
}
