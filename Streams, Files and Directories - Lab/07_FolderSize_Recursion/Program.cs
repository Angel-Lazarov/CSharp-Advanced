namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long size = ReadFolderRecursivly(folderPath);
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"{size / 1024.0}kb");
            }
        }

        public static long ReadFolderRecursivly(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            long size = 0;

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;
            }

            string[] dirs = Directory.GetDirectories(folderPath);

            foreach (var dir in dirs)
            {
                size += ReadFolderRecursivly(dir);
            }

            return size;
        }
    }
}





