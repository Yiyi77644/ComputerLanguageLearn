using System;

//对应教程中的解决方案“0505.Net基础班第二天”项目“12接收用户的输入”
//接收用户的输入
namespace _019_1_ReceiveUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的姓名：");
            //Console.ReadLine()能接收用户的输入。只负责接收
            //str负责存储输入的内容
            string name = Console.ReadLine();
            Console.WriteLine("你的姓名是：{0}",name);
            Console.ReadKey();

            //练习一：问用户喜欢吃什么水果（fruit），假如用户输入“苹果”，
            //则显示“哈哈，这么巧，我也喜欢吃苹果”。
            Console.WriteLine("美女你喜欢吃啥子水果哟~~~");
            string fruit = Console.ReadLine();
            Console.WriteLine("哈哈，这么巧，我也喜欢{0}", fruit);
            Console.ReadKey();

            //练习二：请用户输入姓名性别年龄，当用户按下某个键后，
            //在屏幕上显示：你好XX，你的年龄是xx，是个X生。
            //（提示：本题针对姓名性别年龄分别接收，而不是一次性接收）
            //后面学习了截取字符串之后，就可以一次性接收所有内容了。
            Console.WriteLine("请输入你的姓名：");
            string name1 = Console.ReadLine();
            Console.WriteLine("请输入你的年龄：");
            string age = Console.ReadLine();
            Console.WriteLine("请输入你的性别：");
            string gender = Console.ReadLine();
            Console.WriteLine("你好{0}，你的年龄是{1}，是个{2}生", name1,age,gender);
            Console.ReadKey();
        }
    }
}
