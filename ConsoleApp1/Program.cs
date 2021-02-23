using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of rows: ");
            var rows = Console.ReadLine();
            Console.Write("Number of columns: ");
            var columns = Console.ReadLine();
            Amazing.main(new string[] { columns, rows });
        }
    }
}
