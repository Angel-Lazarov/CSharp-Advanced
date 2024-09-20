namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            FileStream fsOpen = new FileStream(sourceFilePath, FileMode.Open);
            FileStream fsWriteFirst = new FileStream(partOneFilePath, FileMode.Create);
            FileStream fsWriteSecond = new FileStream(partTwoFilePath, FileMode.Create);
            using (fsOpen)
            {
                using (fsWriteFirst)
                {
                    using (fsWriteSecond)
                    {
                        if (fsOpen.Length % 2 == 0)
                        {
                            byte[] firstHalf = new byte[fsOpen.Length / 2];
                            byte[] secondHalf = new byte[fsOpen.Length / 2];

                            fsOpen.Read(firstHalf, 0, firstHalf.Length);
                            fsOpen.Read(secondHalf, firstHalf.Length, secondHalf.Length);

                            fsWriteFirst.Write(firstHalf, 0, firstHalf.Length);
                            fsWriteSecond.Write(secondHalf, 0, secondHalf.Length);
                        }
                        else if (fsOpen.Length % 2 != 0)
                        {
                            byte[] firstHalf = new byte[fsOpen.Length / 2 + 1];
                            byte[] secondHalf = new byte[fsOpen.Length - firstHalf.Length];


                            Console.WriteLine(fsOpen.Length);
                            Console.WriteLine( firstHalf.Length);
                            Console.WriteLine( secondHalf.Length);

                            fsOpen.Read(firstHalf, 0, firstHalf.Length);
                            fsOpen.Read(secondHalf, 0, secondHalf.Length);

                            fsWriteFirst.Write(firstHalf, 0, firstHalf.Length);
                            fsWriteSecond.Write(secondHalf, 0, secondHalf.Length);
                        }
                    }
                }
            }
        }
        // shutdown /s /t 52200

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            FileStream firstStream = new FileStream(partOneFilePath, FileMode.Open);
            FileStream secondStream = new FileStream(partTwoFilePath, FileMode.Open);
            FileStream joinedStream = new FileStream(joinedFilePath, FileMode.Create);

            using (firstStream) 
            {
                using (secondStream)
                {
                    using (joinedStream)
                    {
                        byte[] firstBuffer = new byte[firstStream.Length];
                        byte[] secondBuffer = new byte[secondStream.Length];
                        byte[] joinedBuffer = new byte[firstStream.Length + secondBuffer.Length];

                        joinedStream.Write(firstBuffer, 0, firstBuffer.Length);
                        joinedStream.Write(secondBuffer, 0, secondBuffer.Length);
                    }
                }
            }
        }
    }
}