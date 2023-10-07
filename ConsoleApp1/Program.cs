namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] table = { 1, 2, 3, 4, 5 };
            string[] tableString = { "Ala", "ma", "kota" };

            for(int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }

            for(int i = 0; i < tableString.Length; i++)
            {
                Console.WriteLine(tableString[i]);
            }

            foreach(int i in table)
            {
                Console.WriteLine(i);
            }

            for (int i = table.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(table[i]);
            }
        }
    }
}   