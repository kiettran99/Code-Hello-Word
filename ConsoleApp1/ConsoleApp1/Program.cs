using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void DaiDien(); //Delegate
    class Program
    {
        static void Main(string[] args)
        {
            DaiDien func = HelloWorld;      //Tham chiếu tới phương thức Helloworld
            func(); //Thực thi phương thức vừa tham chiếu tới
            Console.WriteLine("Test GitHub");
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello world !!");
        }
    }
}
