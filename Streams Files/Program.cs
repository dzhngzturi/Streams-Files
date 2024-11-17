using System.IO;

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

        /*===================7=============

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

        ================================== */

        /*===================8=============

        string filePath1 = @"C:\Users\dzhengiz\source\repos\Sirma Academy\input1.txt";
        string filePath2 = @"C:\Users\dzhengiz\source\repos\Sirma Academy\input2.txt";
        string outputFilePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\output.txt";

        using (StreamReader reader1 = new StreamReader(filePath1), reader2 = new StreamReader(filePath2))
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {

            string line1, line2 ;


            while (true)
            {
                line1 = reader1.ReadLine();
                line2 = reader2.ReadLine();

                if (line1 != null)
                {
                    writer.WriteLine(line1);
                }

                if (line2 != null)
                {
                    writer.WriteLine(line2);
                }


                if (line1 == null && line2 == null)
                {
                    break;
                }
            }
        }

        ================================== */

        /*===================9=============

        string filePath1 = @"C:\Users\dzhengiz\source\repos\Sirma Academy\Exercise9";

        long totalSize = 0;

        var directories = new Stack<string>();
        directories.Push(filePath1);

        while (directories.Count > 0)
        {
            string currentDirectory = directories.Pop();


            if (Directory.Exists(currentDirectory))
            {
                string[] files = Directory.GetFiles(currentDirectory);
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    totalSize += fileInfo.Length;
                }

                string[] subdirectories = Directory.GetDirectories(currentDirectory);
                foreach (string subdir in subdirectories)
                {
                    directories.Push(subdir);
                }
            }
        }

        Console.WriteLine(totalSize);

        ======================8==============*/



        string inputFilePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\input.txt";
        string outputFilePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\output.txt";

        if (File.Exists(inputFilePath))
        {
            string content = File.ReadAllText(inputFilePath);

            File.WriteAllText(outputFilePath, content);
        }



    }
}
    