using System;

//对应教程中的解决方案“0505.Net基础班第二天”项目“04变量的使用规则”
//变量的使用规则
namespace _012_1_RulesForUsingVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;//声明或者定义了整数类型的变量
            number = 20;//给变量赋值
            Console.WriteLine(number);//使用变量
            Console.ReadKey();

            String s = "ZhangSan";
            string ss = "LiSi";
            //大写的String和小写的string没有区别，最终都会映射到System.String这个类里面。
            //大写的String不仅是C#中有的，而且包括VB、F#、所有基于.Net平台的语言。
            //小写的string（蓝色的字体）是独属于C#的类型，string被称为关键字。
            //大写的String也不错，不过在C#中，最好使用小写的string这个关键字。


        }
    }
}
