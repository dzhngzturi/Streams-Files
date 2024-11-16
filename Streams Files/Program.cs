﻿internal class Program
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

        string inputFilePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\input.txt";
        string outputFilePath = @"C:\Users\dzhengiz\source\repos\Sirma Academy\output.txt";

        string wordToReplace = Console.ReadLine();
        string replacementWord = Console.ReadLine();

        string fileContent = File.ReadAllText(inputFilePath);
        string updatedContent = fileContent.Replace(wordToReplace, replacementWord);

        File.WriteAllText(outputFilePath, updatedContent);



    }
}