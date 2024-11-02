using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_10if结构”
//if结构
namespace _031_2_IfStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实现：如果跪键盘时间大于60分钟，那么媳妇奖励我晚饭不用做了
            Console.WriteLine("请输入跪键盘的时间：");
            int minutes = Convert.ToInt32(Console.ReadLine());
            //如果跪键盘的时间大于60分钟，则不用做晚饭
            bool b = minutes > 60;
            //如果你想表达的含义是当b的值为true时去执行if中的代码，
            //那么语法上  ==true可以省略。
            //但是你想表达的含义是当b==false的时候去执行if中的代码，
            //那么语法上  ==false不能省略。
            if(b)// if (minutes > 60)// if (minutes>60==true)
            {
                Console.WriteLine("好老公，不用跪键盘了，去吃屎吧");
            }
            Console.ReadKey();
        }
    }
}
