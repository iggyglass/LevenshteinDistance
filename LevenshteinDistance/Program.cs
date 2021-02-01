using System;

namespace LevenshteinDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Give word: ");
                string wordA = Console.ReadLine();

                Console.WriteLine("Give another word: ");
                string wordB = Console.ReadLine();

                Console.WriteLine(Levenshtein.GetDistance(wordA, wordB));
            }
        }
    }
}
