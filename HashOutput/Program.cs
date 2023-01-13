using System.Data;

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