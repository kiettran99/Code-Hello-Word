using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Console.WriteLine(a + " " + b); //2 3
            Swap(ref a, ref b);
            Console.WriteLine(a + " " + b); //3 2
        }
        
        //Phương Thức Hoán Vị Giữa 2 Phần tử Generic Types
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}