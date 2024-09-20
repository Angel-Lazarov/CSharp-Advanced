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
            double sum = 0;
            DirectoryInfo folderInfo = new DirectoryInfo(folderPath);
            FileInfo[] fileInfos = folderInfo.GetFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo fileInfo in fileInfos)
            {
                sum += fileInfo.Length;
            }
            sum = sum / 1024;

            File.WriteAllText(outputFilePath, sum.ToString());

        }
    }
}
//string[] files = Directory.GetFiles(@"C:\Users\acidl\source\repos\CSharp-Advanced\Streams, Files and Directories - Lab\08_EncryptFiles\Images");

//foreach (var file in files)
//{
//    FileInfo fileInfo = new FileInfo(file);
//    Console.WriteLine(fileInfo.Name);
//    //Console.WriteLine(fileInfo.Extension);
//    //Console.WriteLine(fileInfo.FullName);
//    Console.WriteLine(fileInfo.Length);
//}

//string[] dirs = Directory.GetDirectories(folderPath);
//foreach (string dir in dirs) 
//{
//    Console.WriteLine(dir);
//}

//string[] files = Directory.GetFiles(folderPath);
//foreach (var file in files)
//{
//    Console.WriteLine(file);
//}

//for (int i = 0; i < 2; i++)
//{ 
//    Directory.CreateDirectory($"../../../MyDir{i}");
//}

//Thread.Sleep(1000);

////for (int i = 0; i < 10; i++)
////{
////    Directory.Delete($"../../../MyDir{i}");
////}

//FileInfo info = new FileInfo(@"../../../program.cs");

//Console.WriteLine(info.Length);
