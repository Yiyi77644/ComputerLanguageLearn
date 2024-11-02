using System;

//对应教程中的解决方案“0505.Net基础班第四天”项目“_02异常捕获”
//异常捕获
namespace _037_2_ExceptionCapture
{
    class Program
    {
        static void Main(string[] args)
        {
            //异常：就是语法上没有错误，在程序运行过程中由于某些原因，程序出现错误，不能再正常运行。
            //写的代码尽可能没有异常，或者明知有异常，对其进行异常处理。

            Console.WriteLine("请输入一个数字：");
            //如果输入了一个不能转换成数字的字符串，那么就会抛异常。
            //因此对这个可能出现异常的代码进行处理。
            //使用到try  catch
            int number = 0;
            try
            {
                //int number = Convert.ToInt32(Console.ReadLine());
                number = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(number * 2);
            }
            catch
            {
                Console.WriteLine("输入的内容不能转换成数字");
            }
            //当转换成功时，这行代码才执行。如果出了异常，则不执行，因此将它放到try中。
            //如果不想放在try中，就要放在外面，怎么解决：
            //    我的方法：设置一个bool值，初值为false，如果转换成功，则将bool值赋值为true，
            //        然后将Console.WriteLine(number*2);这行代码放进一个if结构中，
            //        判断条件就是这个bool值。如果该值为true，则执行代码，如果为false，则跳出if。
            //        理论就绪，实践开始。写在下方#region 中
            //    老师的方法：思路跟我的思路一样，只是将bool类型的初值设为true，然后在catch里面给bool变量赋值为false。
            //我们如果要执行Console.WriteLine(number * 2);这行代码，需要满足某些条件
            //让代码满足某些条件去执行，最常用的手段就是使用bool类型。以后开发会经常遇到。
            Console.WriteLine(number * 2);
            Console.ReadKey();

            #region 我的方法：将Console.WriteLine(number*2);放在try外面
            //Console.WriteLine("请输入一个数字：");
            ////因为作用域的原因，和变量使用三部曲（先声明再赋值再使用），
            ////因此将变量声明在try外面，并赋初值为0。
            //int number = 0;
            ////标志位，因为想将Console.WriteLine(number * 2);这条语句写在try外面，
            ////因此声明一个bool类型的变量，用于判断是否执行Console.WriteLine(number * 2);这条语句
            ////将该bool类型变量赋初值为false。
            //bool convertIntoNumber = false;
            //try
            //{
            //    //这两句代码不能颠倒顺序。因为如果颠倒顺序，则标志位一定会变为true，
            //    //然而输入的字符串是否能被转成数字类型未知。
            //    //由于try-catch的执行过程为try语句中如果某句代码出现异常，
            //    //该代码后面的代码都不执行，因此将标志位的赋值放在可能发生异常的语句的后面，
            //    //能保证后面使用该标志位的if结构不会在不该执行的时候执行。
            //    number = Convert.ToInt32(Console.ReadLine());
            //    convertIntoNumber = true;
            //}
            //catch
            //{
            //    Console.WriteLine("输入的内容不能转换成数字");
            //}
            //if (convertIntoNumber)
            //{
            //    //哪怕if中只有一行代码，也要将大括号写上，这样能保持结构清晰，便于阅读。
            //    //不允许自己写出来屎山代码。
            //    Console.WriteLine(number * 2);
            //}
            //Console.ReadKey();
            ////我的方法：执行成功。
            #endregion
        }
    }
}
