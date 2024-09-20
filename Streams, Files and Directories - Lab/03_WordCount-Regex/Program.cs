using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader wordReader = new StreamReader(wordsFilePath))
            {
                using (StreamReader textReader = new StreamReader(textFilePath))
                {
                    using (StreamWriter writerOut = new StreamWriter(outputFilePath))
                    {
                        Dictionary<string, int> counts = new Dictionary<string, int>();

                        string[] words = wordReader.ReadLine().ToLower().Split();
                        string text = textReader.ReadToEnd().ToLower();


                        foreach (string word in words)
                        {
                            string pattern = string.Format(@"\b{0}\b", word);
                            MatchCollection matches = Regex.Matches(text, pattern);


                            if (!counts.ContainsKey(word))
                            {
                                counts[word] = matches.Count;
                            }
                        }

                        foreach (var (key, value) in counts.OrderByDescending(x => x.Value))
                        {
                            writerOut.WriteLine($"{key} - {value}");
                        }

                    }
                }
            }
        }
    }
}
