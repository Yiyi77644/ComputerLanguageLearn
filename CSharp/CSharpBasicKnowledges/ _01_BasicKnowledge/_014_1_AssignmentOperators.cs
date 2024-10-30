using System;

//对应教程中的解决方案“0505.Net基础班第二天”项目“06赋值运算符”
//赋值运算符
namespace _014_1_AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            number = 50;//变量的重新赋值。一旦给一个变量重新赋值，那么老值就不存在了，取而代之的是新值。
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
