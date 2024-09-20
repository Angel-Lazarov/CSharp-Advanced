namespace CopyBinaryFile
{
    using System;
    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create))
                {
                    byte[] data = new byte[inputStream.Length];
                    inputStream.Read(data, 0, data.Length);
                    outputStream.Write(data, 0, data.Length);
                }
            }
        }
    }
}
