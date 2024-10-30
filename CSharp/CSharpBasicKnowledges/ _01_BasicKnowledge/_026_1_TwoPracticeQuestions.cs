using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_02_两道作业题”
//两道练习题
namespace _026_1_TwoPracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            ////练习题1：编程实现计算几天（如46天）是几周零几天。
            //int totalDays = 46;
            //int weeks = totalDays / 7;
            //int days = totalDays % 7;
            //Console.WriteLine("{0}天是{1}周零{2}天", totalDays, weeks, days);
            //Console.ReadKey();

            //练习题2：编程实现107653秒时几天几小时几分几秒钟。
            #region 方法1，从大头计算
            //int totalSeconds = 107653;
            //int seconds = totalSeconds;
            //int days = seconds / (24 * 60 * 60);
            //seconds = seconds % (24 * 60 * 60);
            //int hours = seconds / (60 * 60);
            //seconds = seconds % (60*60);
            //int minutes = seconds / 60;
            //seconds = seconds % 60;
            //107653秒是1天5小时54分钟13秒
            //Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", totalSeconds, days, hours, minutes, seconds);
            #endregion

            #region 方法2，从小头计算
            int totalSeconds = 107653;
            int seconds = totalSeconds % 60;
            int minutes = totalSeconds / 60;//总分钟数，还得取模
            int hours = minutes / 60;//总小时数，还得取模
            int days = hours / 24;
            minutes = minutes % 60;
            hours = hours % 24;
            #endregion
            //107653秒是1天5小时54分钟13秒
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", totalSeconds, days, hours, minutes, seconds);
            Console.ReadKey();
            //练习题3：修改上面的题目，让用户输入，小时（hour）、分钟（minute）、秒（seconds）

        }
    }
}
