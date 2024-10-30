using System;

//对应教程中的解决方案“0505.Net基础班第二天”项目“15类型转换”
//类型转换
namespace _023_1_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 3;
            //d为整数，d的值为3
            int d = n1 / n2;
            //d0为小数，d0的值为3。因为在等号右边，
            //两个操作数都是整数，因此得到的结果是个整数，
            //只是将这个整数隐式地转换为了小数。因此d0的值还是3。
            double d0 = n1 / n2;
            //d1为小数，d1的值为3.3333333333333333333。
            //这是因为在等号右边的算术表达式的两个操作数中，
            //有一个操作数是小数。
            double d1 = n1 * 1.0 / n2;
            Console.WriteLine(d);
            Console.WriteLine(d0);
            Console.WriteLine(d1);
            //如果想让打印到控制台上的结果保留两位小数，需要用占位符：
            Console.WriteLine("{0:0.00}",d1);
            //如果保留四位小数，需要用占位符：
            Console.WriteLine("{0:0.0000}", d1);
            //如果保留七位小数，需要用占位符：
            Console.WriteLine("{0:0.0000000}", d1);
            Console.ReadKey();


            //将整数算数表达式转换成小数的两种方法：
            //1. 将其中一个整数的类型变为小数，如n3：int n3 = 5; --> double n3 = 5;
            //2. 将算数表达式其中一个操作数乘上一个1.0，如d1：double d1 = n1 * 1.0 / n2;
            double n3 = 5;
            int n4 = 2;
            double d2 = n3 * 1.0 / n4;
            Console.WriteLine(d1);
            Console.ReadKey();
        }
    }
}
