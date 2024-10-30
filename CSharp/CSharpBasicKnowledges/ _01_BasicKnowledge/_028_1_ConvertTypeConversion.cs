using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_04Convert类型转换”
//Convert类型转换
namespace _028_1_ConvertTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入一个数字，接收，并向控制台打印用户输入的这个数字的2倍            
            Console.WriteLine("请输入一个数字");
            ////虽然用户在控制台上输入的可能是一个数字，但是还是要用string类型变量来存储输入的信息。
            //string strNumber = Console.ReadLine();
            //double number = Convert.ToDouble(strNumber);
            //上面两行代码可以合并成一行代码，如下：
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number * 2);
            Console.ReadKey();
        }
    }
}
