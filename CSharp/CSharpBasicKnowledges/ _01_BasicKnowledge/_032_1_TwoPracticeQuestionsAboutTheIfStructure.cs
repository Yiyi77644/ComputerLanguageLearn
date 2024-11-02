using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_11if结构的3个练习”
//if结构的两个练习
namespace _032_1_TwoPracticeQuestionsAboutTheIfStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            ////练习1：让用户输入年龄,如果输入的年龄大于23(含)岁，则给用户显示你到了结婚的年龄了。
            //Console.WriteLine("请输入你的年龄：");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 23)
            //{
            //    Console.WriteLine("你可以结婚了。");
            //}
            //Console.ReadKey();


            ////练习2：如果老苏的(chinese music)：
            ////    语文成绩大于90并且音乐成绩大于80；
            ////    语文成绩等于100并且音乐成绩大于70，则奖励100元。
            //Console.WriteLine("请输入语文成绩：");
            //int chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入音乐成绩：");
            //int music = Convert.ToInt32(Console.ReadLine());
            //if ((chinese >90 &&music >80)||(chinese ==100 && music >70))
            //{
            //    Console.WriteLine("奖励100元。");
            //}
            //Console.ReadKey();


            //练习3：让用户输入用户名和密码,如果用户名为admin，密码为mypass，则提示登录成功。
            //如果密码改为888888，pwd也不用转成int类型，直接字符串比较就可以。
            //不过转成int类型也能做。这个题，不转换简单。
            Console.WriteLine("请输入用户名：");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pwd = Console.ReadLine();
            if (userName == "admin" && pwd == "mypass")
            {
                Console.WriteLine("登录成功。");
            }
            Console.ReadKey();
        }
    }
}
