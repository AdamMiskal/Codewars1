using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine(Grow(array));
        }

        public static int Grow(int[] x)
        {
            int end = 1;
            foreach (var number in x)
            {
                
                end *= number;
            }
            return end;
        }
    }
   
}


