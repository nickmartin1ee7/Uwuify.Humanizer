using System;
using System.Text;

namespace Uwuify.Humanizer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            while (true)
            {
                Console.Write("Uwuify: ");
                var input = Console.ReadLine();

                Console.WriteLine(input?.Uwuify());
            }
        }
    }
}