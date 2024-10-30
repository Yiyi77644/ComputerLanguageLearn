using System;

//对应教程中的解决方案“0505.Net基础班第二天”项目“10占位符”
//占位符的使用
namespace _017_2_Placeholder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            int n3 = 39;
            int n4 = 22;
            Console.WriteLine("+号的使用：\n第一个数字是：" + n1 + "，第二个数字是：" + n2 + "，第三个数字是：" + n3 + "。");
            Console.WriteLine("占位符的使用：\n第一个数字是：{0}，第二个数字是：{2}，第三个数字是：{2}。",n1,n3,n2);
            Console.ReadKey();

            //定义四个变量，分别存储一个人的姓名，性别（Gender）、年龄、电话（TelephoneNumber）。
            //然后打印在屏幕上
            //（我叫X，我今年X岁了，我是X生，我的电话是XX
            //（电话号用什么类型。如010 - 12345））。
            string name = "姓名";
            int age = 17;
            char gender = '男';
            string telephoneNumber = "010 - 12345";
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的电话是{3}。",name,age, gender ,telephoneNumber);
            Console.ReadKey();

        }
    }
}
