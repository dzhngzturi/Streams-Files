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

    }
}