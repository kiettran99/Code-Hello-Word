using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class MethodExtension
    {
        /// <summary>
        /// Phương thức mở rộng cho phép thêm phương thức từ đối tượng int.
        /// Chức năng in ra màn hình Console.
        /// </summary>
        public static void Print(this int a) => Console.WriteLine(a);
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            a.Print();  //2
        }
    }
}
