using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_06关系运算符”
//关系运算符
namespace _029_1_RelationalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //关系表达式的结果是布尔（bool）类型。

            ////大象的重量(1500) > 老鼠的重量(1)
            //bool b = 1500 > 1;

            ////兔子的寿命(3) > 乌龟的寿命(1000)
            //bool b = 3 > 1000;

            ////39 < 18
            //bool b = 39 < 18;

            //我的年龄(20) == 你的年龄(20)
            bool b = 20 == 20;

            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
