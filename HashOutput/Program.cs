using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace HashOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise2_1();
            //Exercise2_2();
            //Exercise2_3();
            Exercise2_9();
        }

        static void Exercise2_9()
        {
            Console.WriteLine("Please write a sentence");
            string text = Console.ReadLine();
            string[] words = text.Split(" ");

            Console.WriteLine($"You sentence contains of {words.Length} words.");
            Console.WriteLine($"The longest word in the sentence is '{FindLongestWord(words)}'. It is {FindLongestWord(words).Length} characters long.");
            Console.WriteLine($"The word with the most vowels is '{FindWordWithMostVowels(words)}'.");
        }

        private static string FindWordWithMostVowels(string[] words)
        {
            string mostVowels = "";
            int count = 0;
            foreach (var word in words)
            {
                int localCount = 0;
                foreach (var c in word)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                        c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                    {
                        localCount++;
                    }
                }
                if (localCount <= count) continue;
                count = localCount;
                mostVowels = word;
            }
            return mostVowels;
        }

        private static string FindLongestWord(string[] words)
        {
            string longestWord = "";
            foreach (var word in words)
            {
               longestWord = word.Length > longestWord.Length ?  word : longestWord;
            }

            return longestWord;
        }

        static void Exercise2_3()
        {
            for (var row = 0; row < 4; row++)
            {
                Space(row);
                Hash(row + 1);
                Space(6 - 2 * row);
                Space(6 - 2 * row);
                Hash(row + 1);
                NewLine();
            }

            for (var row = 3; row >= 0; row--)
            {
                Space(row);
                Hash(row + 1);
                Space(6 - 2 * row);
                Space(6 - 2 * row);
                Hash(row + 1);
                NewLine();
            }
        }

        static void Exercise2_1()
        {
            for (int i = 0; i < 4; i++)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }
        }

        static void Exercise2_2()
        {
            for (int i = 0; i < 4; i++)
            {
                Space(3 - i);
                Hash(2 + 2 * i);
                NewLine();
            }
            Exercise2_1();
        }
        static void Space()
        {
            Console.Write(" ");
        }

        static void Space(int count)
        {
            for (var i = 0; i < count; i++) Console.Write(" ");
        }
        static void Hash()
        {
            Console.Write('#');
        }
        static void Hash(int count)
        {
            for (var i = 0; i < count; i++) Hash();
        }

        static void NewLine()
        {
            Console.WriteLine();
        }


    }
}