using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_03类型转换”
//Convert类型转换
namespace _027_1_ConvertTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "123";
            //double d = Convert.ToDouble(s);
            //int n = Convert.ToInt32(s);
            //Console.WriteLine(n);
            //Console.ReadKey();

            //让用户输入姓名，语文、数学、英语成绩，
            //然后给用户显示:
            //XX，你的总成绩为XX分，平均成绩为XX分
            Console.WriteLine("请输入你的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的语文成绩：");
            string strChinese = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩：");
            string strMath = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩：");
            string strEnglish = Console.ReadLine();

            //由于字符串相加的话，最终会变成相连接，、
            //如果要拿字符串类型的变量参与计算，
            //需要将字符串转成int类型或者double类型。
            //int chinese = Convert.ToInt32(strChinese);            
            //int math = Convert.ToInt32(strMath);
            //int english = Convert.ToInt32(strEnglish);
            //Console.WriteLine("{0}，你的总成绩是{1}，平均成绩是{2}", name, chinese + math + english, (chinese + math + english) / 3);

            ////这行代码抛了异常。
            //double chineseToInt = Convert.ToInt32(strChinese);
            double chinese1 = Convert.ToDouble(strChinese);
            double math1 = Convert.ToDouble(strMath);
            double english1 = Convert.ToDouble(strEnglish);
            double sum = chinese1 + math1 + english1;
            //将sum强转为int类型，此时sum/3就是整数。
            //如果要变为小数，则将其中一个操作数变为小数即可。
            //最简单的方式就是其中一个操作数乘上1.0。
            double average = (int)sum * 1.0 / 3;
            //如果算术运算符两侧的操作数有一个是double类型，则整体提升为double类型
            double realAverage = sum / 3;
            Console.WriteLine("{0}，你的总成绩是{1}，平均成绩是{2}，真实的平均成绩是{3}", name, sum,average,realAverage);
            Console.ReadKey();



        }
    }
}
