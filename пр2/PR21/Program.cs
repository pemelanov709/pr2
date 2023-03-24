using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    class pip
    {
        private int n = 0;
        public bool SetNumber(int n1)
        {
            if (n + 1 == n1)
            {
                this.n = n1;
                return true;
            }
            else
            {
                this.n = 0;
                Console.Clear();
                return false;
            }
        }
        public int GetNumber()
        {
            return n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n+1");
            pip Op = new pip();
            int n = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                Console.WriteLine(Op.SetNumber(int.Parse(Console.ReadLine())));

            }
        }

    }
}
