using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_07逻辑运算符练习”
//逻辑运算符
namespace _029_2_LogicalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入老苏的语文和数学成绩,输出以下判断是否正确,正确输出True,错误输出False
            //1)老苏的语文和数学成绩都大于90分
            //2)语文和数学有一门是大于90分的
            Console.WriteLine("请输入语文成绩：");
            double chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入数学成绩：");
            double math = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(math>90&&chinese >90);
            Console.WriteLine(math>90||chinese >90);
            Console.ReadKey();
        }
    }
}
