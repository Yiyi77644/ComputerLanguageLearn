using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_05加加减减”
//自加自减（加加减减）
namespace _028_2_SelfAddingAndSelfReducing
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 10;
            //////简单理解为number=number+1
            ////number++;
            //////++number ;
            //number--;
            //--number;
            //Console.WriteLine(number );
            //Console.ReadKey();

            //int number1 = 10;
            //int number2 = 10;
            ////这句代码可以拆成：int result1 = 5 + number1; number1++;
            //int result1 = 5 + number1++;
            ////这句代码可以拆成：number2++; int result2 = 5 + number2;  
            //int result2 = 5 + (++number2);
            //Console.WriteLine("number1:{0}, \nnumber2:{1}, \nresult1:{2}, \nresult2:{3}", number1, number2, result1, result2);
            //Console.ReadKey();

            //int number1 = 10;
            //int number2 = 10;
            ////这句代码可以拆成：int result1 = 5 + number1; number1--;
            //int result1 = 5 + number1--;
            ////这句代码可以拆成：number2--; int result2 = 5 + number2;  
            //int result2 = 5 + (--number2);
            //Console.WriteLine("number1:{0}, \nnumber2:{1}, \nresult1:{2}, \nresult2:{3}", number1, number2, result1, result2);
            //Console.ReadKey();

            int a = 5;
            ////预测结果：a=13,b=33
            ////实际结果：a=7, b=31
            //int b = a++ + ++a * 2 + --a + a++;
            ////实际结果：a=7, c=31
            int c = (a++) + (++a) * 2 + (--a) + (a++);
            //说明b的表达式和c的表达式是一样的计算方式。
            #region 错误的分析过程
            ////分析：
            //// ++a，a=6； 
            //// a*2, a=12;  //重新分析之后，这一步错误
            //// --a, a=11;
            //// b=a+a+a=33
            //// a++,a=12;
            //// a++, a=13

            ////预测结果错误原因：优先级顺序弄错。
            ////重新分析：
            //// 先分析a：a++，++a, --a, a++, a=7
            //// 再分析b：
            ////    1.++a, a=6;
            ////    2.++a*2, 就是6*2=12
            ////    3.--a, a=5
            ////    4.b=5+11+5+5=26;
            ////        b=6+12+5+5=
            //// 再分析c：
            ////    1.++a, a=6;
            ////    2.++a*2, 就是6*2=12
            ////    3.--a, a=5
            ////    4.b=5+12+5+5=27;
            //以上分析都不对，打断点进行测试
            #endregion


            // 打断点测试之后得到运算顺序：
            //int bTest = a++;             //a=6,bTest=5
            //bTest = bTest + ++a * 2;     //a=7,bTest=5+7*2=19
            //bTest = bTest + --a;         //a=6,bTest=19+6=25
            //bTest = bTest + a++;         //a=7,bTest=25+6=31

            int cTest = (a++);
            cTest = cTest + (++a) * 2;
            cTest = cTest + (--a);
            cTest = cTest + (a++);

            //说明：c的结果为41是因为使用的a已经不是5而是7。
            //Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            Console.WriteLine("a={0},c={1}", a, c);
            //Console.WriteLine("a={0}, bTest={1}", a, bTest);
            Console.ReadKey();


        }
    }
}
