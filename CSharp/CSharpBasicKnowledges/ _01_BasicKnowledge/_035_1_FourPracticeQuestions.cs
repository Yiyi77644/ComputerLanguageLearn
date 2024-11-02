using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_13_四个练习”
//四个练习
namespace _035_1_FourPracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 比较3个数字的大小 不考虑相等
            ////比较3个数字的大小 不考虑相等
            ////分别地提示用户输入三个数字，我们接收并转换成int类型
            //Console.WriteLine("请输入第一个数字");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字");
            //int number3 = Convert.ToInt32(Console.ReadLine());
            //#region 方法1
            ////三种情况，使用if-else if
            ////如果第一个数字大于第二个数字且第一个数字大于第三个数字
            //if (number1 > number2 && number1 > number3)
            //{
            //    Console.WriteLine(number1);
            //}
            ////如果第二个数字大于第一个数字且第二个数字大于第三个数字
            //else if (number2 > number1 && number2 > number3)
            //{
            //    Console.WriteLine(number1);
            //}
            ////如果第三个数字大于第一个数字且第三个数字大于第二个数字
            //else
            //{
            //    Console.WriteLine(number1);
            //}
            //#endregion
            //#region 方法2
            ////先让第一个数字跟第二个数字比较，
            ////如果第一个数字大于第二个数字，那么再让第一个数字跟第三个数字比较。
            //if(number1>number2)
            //{
            //    //如果第一个数字大于第二个数字，那么再让第一个数字跟第三个数字比较。
            //    if (number1 > number3)
            //    {
            //        Console.WriteLine(number1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(number3);
            //    }
            //}
            ////如果第二个数字大于第一个数字
            //else
            //{
            //    //如果第二个数字大于第一个数字，那么再让第二个数字跟第三个数字比较。
            //    if (number2 > number3)
            //    {
            //        Console.WriteLine(number2);
            //    }
            //    //第三个数字最大
            //    else
            //    {
            //        Console.WriteLine(number3);
            //    }
            //}
            //#endregion
            //Console.ReadKey();
            #endregion

            #region 练习1
            ////练习1：提示用户输入密码，如果密码是“88888”则提示正确，
            ////    否则要求再输入一次，如果密码是“88888"则提示正确，否则提示错误，程序结束。
            ////    (如果我的密码里有英文还要转换吗，密码：abc1)
            //Console.WriteLine("请输入密码：");
            ////用户输入的密码，直接使用string类型变量存储即可，无需转成int。
            //string pwd = Console.ReadLine();
            //if (pwd == "88888")
            //{
            //    Console.WriteLine("密码正确");
            //}
            //else
            //{
            //    Console.WriteLine("密码错误，请再试一次：");
            //    pwd = Console.ReadLine();
            //    if (pwd == "88888")
            //    {
            //        Console.WriteLine("密码正确，不算太笨");
            //    }
            //    else
            //    {
            //        Console.WriteLine("你真笨，两遍都不对，服了你了，程序结束，不跟你玩了");
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region 练习2
            ////练习2：提示用户输入用户名，然后再提示输入密码，
            ////    如果用户名是“admin”并且密码是“88888”，则提示正确，
            ////    否则，如果用户名不是admin还提示用户用户名不存在，
            ////    如果用户名是admin则提示密码错误。
            //Console.WriteLine("请输入用户名：");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string pwd = Console.ReadLine();
            ////用户名和密码都正确
            //if(userName == "admin" && pwd == "88888")
            //{
            //    Console.WriteLine("登录成功");
            //}
            ////用户名错误
            //else if(userName !="admin")
            //{
            //    Console.WriteLine("用户名错误");
            //}
            ////密码错误
            //else if (pwd != "88888")
            //{
            //    Console.WriteLine("密码错误");
            //}
            ////用户名和密码错误
            //else
            //{
            //    Console.WriteLine("用户名和密码错误");
            //}
            //Console.ReadKey();
            #endregion

            #region 练习3
            //练习3：提示用户输入年龄，如果大于等于18，则告知用户可以查看，
            //    如果小于10岁，则告知不允许查看，如果大于等于10岁并且小于18，
            //    则提示用户是否继续查看(yes、no)，如果输入的是yes则提示用户请查看，
            //    否则提示“退出，你放弃查看”。
            Console.WriteLine("请输入你的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            //如果小于十岁，不让看
            if (age < 10)
            {
                Console.WriteLine("小屁孩看什么看，回家吃奶去");
            }
            //如果大于等于18岁，可以观看
            else if (age >= 18)
            {
                Console.WriteLine("有些事，你是时候知道了");
            }
            //如果介于10到18岁之间，商量着来
            else
            {
                Console.WriteLine("你确定要看吗？请输入yes/no");
                string str = Console.ReadLine();
                if (str == "yes")
                {
                    Console.WriteLine("小崽子看吧，小心发育不良，后果自负");
                }
                else if (str == "no")
                {
                    Console.WriteLine("好孩子，回家吃奶去吧");
                }
            }
            #endregion
        }
    }
}
