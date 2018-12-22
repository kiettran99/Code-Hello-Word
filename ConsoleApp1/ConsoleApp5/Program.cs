using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = TaoDanhSach();
            //Tham số a và trả về a có phải là số chẵn
            //var even = list.Where(a => a % 2 == 0); //Kiểm tra số chẵn
            var even = from a in list
                       where a % 2 == 0
                       select a;

            foreach (var a in even)
            {
                Console.WriteLine(a);   //In những số là số chẵn
            }
            Console.WriteLine("Hello world ");
        }
        /// <summary>
        /// Phương thức in ra danh sách từ 0 --> 10
        /// </summary>
        static IEnumerable<int> TaoDanhSach()
        {
            for (int i = 0; i <= 10; i++)
                yield return i;
        }
    }
}
