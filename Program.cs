using ConsoleApp6.Model;
using System.Drawing;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure a = new Square(5);
            Figure b = new Rectangular(1,2);

            char option;
            Console.WriteLine("1.Square\n2.Rectangular\n0.Quit");

            do
            {
                option = Convert.ToChar(Console.Read());
                switch (option)
                {
                    case '1':
                        Console.WriteLine("Sidee: ");
                        
                        a.CalcArea();
                        
                        break;
                    case '2':
                        Console.WriteLine("Rectangular: ");
                        b.CalcArea();
                        break;
                }


            } while (option != '0');
        }
    }
}