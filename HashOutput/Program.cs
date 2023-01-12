namespace HashOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            for (var i = rows; i > 0; i--)
            {
                for (var j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (var k = 0; k < (i * 2); k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}