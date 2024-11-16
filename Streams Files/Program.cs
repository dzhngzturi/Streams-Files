internal class Program
{
    private static void Main(string[] args)
    {
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


    }
}