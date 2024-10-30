using System;

//对应教程中的解决方案“0505.Net基础班第二天”项目“07+号的使用”
//+号的使用
namespace _015_1_TheUseOfPlusOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "ZhangSan";
            string name2 = "LiSi";
            Console.WriteLine("Hello, "+ name1);
            Console.WriteLine("Hello, {0}", name2);
            Console.WriteLine("输出字符串"+ 5);
            Console.WriteLine(5+5);
            Console.ReadKey();
        }
    }
}
