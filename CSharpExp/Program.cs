using System;//使用系统命名空间
using RectangleApplication;//使用自定义命名空间

namespace CSharpExp //自定义命名空间
{
    class Program//类名
    {
        static void Main(string[] args)//同java，主函数，程序入口
        {

            Rectangle rectangle = new Rectangle();
            rectangle.Acceptdetails();
            rectangle.Display();
            Console.WriteLine("Hello World!");
        }
    }
}

/*
*
* 标识符：类名 方法名 成员变量名
* 
* 类名：大写开头 驼峰
* 方法名：大写开头 驼峰
* 成员变量：小写
*/