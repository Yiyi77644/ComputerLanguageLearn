using System;

//对应教程中的解决方案“0505.Net基础班第二天”项目“08两个练习”
//两个练习
namespace _016_1_TwoPracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一道练习：
            //    有个叫卡卡西的人，在旅店登记的时候，
            //    前台让他填一张表，这张表的内容要存到电脑上，
            //    有姓名、年龄、邮箱、家庭住址、工资。
            //    之后把这些信息显示出来：
            //    我叫卡卡西，我住在火影村，我今年30了，我的邮箱是kakaxi@qq.com，我的工资是2000。
            //第二道练习：
            //    定义一个变量存储一个人的年龄（18），
            //    然后发现这个人的年龄不是18岁，
            //    要把这个人的年龄修改为81岁（本题体会变量可以被重复多次赋值），
            //    最后把这个人的年龄输出到屏幕上。
            string consumerName = "卡卡西";
            int age = 30;
            string email = "kakaxi@qq.com";
            string address = "火影村";
            decimal salary = 2000m;
            //这个输出有更简单的方法，叫占位符。
            Console.WriteLine("我叫" + consumerName + "，我住在" + address + "，我今年" + age + "了，我的邮箱是" + email + "，我的工资是" + salary+"。");
            Console.ReadKey();


            int age2 = 18;
            age2 = 81;
            Console.WriteLine(age2);
            Console.ReadKey();



        }
    }
}
