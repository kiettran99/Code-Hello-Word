using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public delegate void DaiDien(); //Delegate kiểu trả về void và không tham số
    class Program
    {
        static void Main(string[] args)
        {
            //Phương thức mở rộng lấy AnonymousMethod làm đại diện cho phương thức
            //Phương thức này có dạng phải giống với delegate
            DaiDien AnonymousMethod = delegate () { Console.WriteLine("Hello world !!!"); };
            AnonymousMethod();  //Thực thi phương thức không tên
            //Console: Hello World !!!
            //Cách viết khác
            //=> : go to thực thi câu lệnh
            DaiDien LambdaExpression = () => Console.WriteLine("Hello world !");
            LambdaExpression(); //Thực thi phương thức
        }
    }
}
