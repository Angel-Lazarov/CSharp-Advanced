namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            FileStream fsWrite = new FileStream(outputPath, FileMode.Create);
            using (StreamReader sr = new StreamReader(bytesFilePath)) 
            {
                List<byte> magic = new List<byte>();

                while (!sr.EndOfStream) 
                {
                    string line = sr.ReadLine();
                    magic.Add(byte.Parse(line));
                }
               // Console.WriteLine(string.Join(" ", magic));

                using (FileStream fsOpen = new FileStream(binaryFilePath, FileMode.Open))
                {
                    byte[] binFile = new byte[fsOpen.Length];
                    fsOpen.Read(binFile, 0, binFile.Length);

                         Console.WriteLine(string.Join(" ", binFile));
                    using (fsWrite) 
                    {
                        List<byte> checkedBytes = new List<byte>();
                        // След това за всеки елемент от byte масива проверяваш дали съществува като елемент в първия масив.

                        for (int i = 0; i < binFile.Length; i++)
                        {
                             // Ако съществува запазваш стойността.
                            if (magic.Contains(binFile[i]))
                            {
                                checkedBytes.Add(binFile[i]);
                            }
                        }
                         // Console.WriteLine(string.Join(" ", checkedBytes));
                        byte[] newArray = checkedBytes.ToArray();
                       // Console.WriteLine(string.Join(" ", newArray));

                        fsWrite.Write(newArray, 0, newArray.Length);
                    }
                }
            }
        }
    }
}
