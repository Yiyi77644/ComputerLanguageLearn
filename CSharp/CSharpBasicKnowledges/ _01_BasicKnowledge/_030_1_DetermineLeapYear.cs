using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_08判断闰年练习”
//判断闰年
namespace _030_1_DetermineLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：
            //写下判断闰年的表达式,设待判断的年份变量为year。
            //闰年的判定(符合下面两个条件之一)：
            //年份能够被400整除。(2000)
            //年份能够被4整除但不能被100整除。(2008)
            //让用户输入一个年份,如果是润年,则输出true,如果不是,则输出false。

            Console.WriteLine("请输入年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            //为了便于读和美观，每一个大的表达式都要用小括号括起来：
            //(year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)
            //当然这种写法也不错：year % 400 == 0 || year % 4 == 0 && year % 100 != 0
            Console.WriteLine(year % 400 == 0 || year % 4 == 0 && year % 100 != 0);

            //2100 / 1600 / 1800 / 2009年是闰年吗 ?

            Console.ReadKey();

        }
    }
}
