using System;
namespace ConsoleDocker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 1000)
            {
                Console.WriteLine("Hello world!" + i);
                i++;

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}