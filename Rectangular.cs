using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Model
{
    internal class Rectangular: Figure
    {
        int _widht;
        int _length;

        public int Widht { get => _widht; set 
            {
                if (value >= 0)
                {
                    _widht = value;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            } }
        public int Length { get => _length; set
            {
                if (value >= 0)
                {
                    _widht = value;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                };
            } }

        public Rectangular(int widht, int length)
        {
            Widht = widht;
            Length = length;
        }


        public override int CalcArea()
        {
            return Length * Widht;
        }
    }
}
