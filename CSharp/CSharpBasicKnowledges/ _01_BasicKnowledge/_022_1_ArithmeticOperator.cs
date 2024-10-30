using System;


//对应教程中的解决方案“0505.Net基础班第二天”项目“14算数运算符”
//算数运算符
namespace _022_1_ArithmeticOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 3;
            //int result = a / b;
            //Console.WriteLine(result);
            //Console.ReadKey();

            //int chinese = 90;
            //int math = 80;
            //int english = 67;
            //Console.WriteLine("总成绩是{0}，平均成绩是{1}", chinese + math + english, (chinese + math + english) / 3);
            //Console.ReadKey();

            ////练习题1：定义两个数，分别为100和20，打印出两个数的和。
            //int n1 = 100;
            //int n2 = 20;
            //Console.WriteLine(n1 + n2);
            //Console.ReadKey();

            ////练习题2：计算半径为5的圆的面积和周长，并打印出来。（pi为3.14）面积：pi* r*r，perimeter（周长）
            //int r = 5;
            //double area = 3.14 * r * r;
            //double perimeter = 3.14 * 2 * r;
            //Console.WriteLine("面积是{0}，周长是{1:0.00}", area, perimeter);
            //Console.ReadKey();

            //练习题3：某商店T恤（T_shirt）的价格为35元 / 件，裤子（trousers）的价格为120元 / 条。
            //小明在该店买了3件T恤和2条裤子，请计算并显示小明应该付多少钱？
            //打8.8折之后呢？
            int T_shirt = 35;
            int trousers = 120;
            int totalMoney = T_shirt * 3 + trousers * 2;
            Console.WriteLine(totalMoney);
            double realMoney = totalMoney * 0.88;
            Console.WriteLine(realMoney);
            Console.ReadKey();


            //int number = 10;
            //int --- double 
            //double d=number //自动类型转换
            double d = 303.6;
            //语法：
            //(待转换的类型)要转换的值;
            //double----int //强制类型转换 显示类型转换
            int n = (int)d;
            Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}
