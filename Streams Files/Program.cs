internal class Program
{
    private static void Main(string[] args)
    {
        /*===================1=============
        string filePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\input.txt";

        using(StreamReader reader = new StreamReader(filePath))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(' ');

                foreach(string word in words)
                {
                    Console.WriteLine(word.Length);
                }
            }
        }
        ==================================*/

        /*===================2=============

        string filePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\input.txt";

        Dictionary<char, int> charFrequency = new Dictionary<char, int>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            int currentChar;

            while ((currentChar = reader.Read()) != -1)
            {
                char ch = (char)currentChar;

                if (charFrequency.ContainsKey(ch))
                {
                    charFrequency[ch]++;
                }
                else
                {
                    charFrequency[ch] = 1;
                }
            }
        }

        foreach (var item in charFrequency)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        ================================== */

        /*===================3=============

        string inputFilePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\input.txt";
        string outputFilePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\output.txt";

        string wordToReplace = Console.ReadLine();
        string replacementWord = Console.ReadLine();

        string fileContent = File.ReadAllText(inputFilePath);
        string updatedContent = fileContent.Replace(wordToReplace, replacementWord);

        File.WriteAllText(outputFilePath, updatedContent);

        ================================== */

        /*===================4=============

        string filePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\input.txt";

        int lineCount = 0;
        int wordCount = 0;
        int charCount = 0;

        foreach (var line in File.ReadLines(filePath))
        {
            lineCount++;

            string[] words = line.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            wordCount += words.Length;

            charCount += line.Length;  
        }

        Console.WriteLine($"{lineCount}");
        Console.WriteLine($"{wordCount}");
        Console.WriteLine($"{charCount}");

        ================================== */


        /*===================5=============

        string filePath = Console.ReadLine();

        string fileName = Path.GetFileNameWithoutExtension(filePath);
        string fileExtension = Path.GetExtension(filePath);
        FileInfo fileInfo = new FileInfo(filePath);

        Console.WriteLine(fileName);
        Console.WriteLine(fileExtension);
        Console.WriteLine(fileInfo.Length);

        ================================== */

        /*===================6=============

        string inputFilePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\input.txt";
        string outputFilePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\output.txt";

        using (StreamReader reader = new StreamReader(inputFilePath)) 
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                char[] lineArray = line.ToCharArray();

                Array.Reverse(lineArray);

                writer.WriteLine(new string(lineArray));
            }
        }
        ================================== */

        string filePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\input.txt";

        HashSet<string> uniqueWords = new HashSet<string>();

        foreach (string line in File.ReadLines(filePath))
        {
            string[] words = line.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?', '"', '\'' }, StringSplitOptions.RemoveEmptyEntries);


            foreach (var word in words)
            {
                string normalizedWord = word.ToLower();
                uniqueWords.Add(normalizedWord);
            }
        }

        Console.WriteLine(uniqueWords.Count);
    }
}