using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Model
{
    internal class Square : Figure
    {

        private int _side;
        public int Side { get => _side; set 
            {
                if (value > 0)
                {
                    _side = value;
                }
                else
                {
                    Console.WriteLine("Menfi ola bilmez");
                } 
                ;} }

        public Square(int Side)
        {
            this.Side = Side;
        }
        public override int CalcArea()
        {
            return + Side * Side;
        }
    }
}
