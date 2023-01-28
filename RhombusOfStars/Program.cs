using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
    class StarRhombus
    {
        public int Size { get; set; }
        private void PrintARowStars(int s)
        {
            for (int i = 0; i < Size - s; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < s - 1; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");

        }
        public StarRhombus(int size)
        {
            Size = size;
        }

        public void PrintRhombusStars()
        {
            for (int i = 1; i <= Size; i++)
            {
                PrintARowStars(i);

            }
            for (int i = Size - 1; i > 0; i--)
            {
                PrintARowStars(i);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the size of Rhombus: ");
            int n = int.Parse(Console.ReadLine());
            StarRhombus st = new StarRhombus(n);
            st.PrintRhombusStars();
            Console.ReadLine();
        }
    }
}
