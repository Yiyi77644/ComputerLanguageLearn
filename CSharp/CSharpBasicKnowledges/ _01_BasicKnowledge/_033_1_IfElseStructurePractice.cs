using System;

//对应教程中的解决方案“0505.Net基础班第三天”项目“_12if-else练习”
//if-else练习（本项目包含33节和34节所讲的内容）
namespace _033_1_IfElseStructurePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////如果小赵的考试成绩大于90（含）分，那么爸爸奖励他100元钱，
            ////否则的话，爸爸就让小赵跪方便面。
            //Console.WriteLine("请输入小赵的考试成绩：");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if(score >= 90)
            //{
            //    Console.WriteLine("奖励100元。");
            //}
            //else
            //{
            //    Console.WriteLine("去跪方便面。");
            //}
            //Console.ReadKey();

            //对学员的结业考试成绩评测：
            //成绩 >= 90 ：A
            //90 > 成绩 >= 80 ：B
            //80 > 成绩 >= 70 ：C
            //70 > 成绩 >= 60 ：D
            //成绩 < 60 ：E
            Console.WriteLine("请输入学员的成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
            #region if结构的方法
            //if(score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            ////if(80 <= score < 90)在数学中，经常这样写，但是在C#中没有这种写法，需要用逻辑与来表达这种含义。
            //if (score < 90 && score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //if(score < 80 && score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //if (score < 70 && score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //最后这个if，如果换成else，那么，向控制台输入98，在控制台中会同时打印A和E。
            //这是因为，else只会跟离它最近的if进行配对，也就是跟if (score < 70 && score >= 60)配对，
            //因为98不在这个if的范围内，所以会执行else中的代码。所以不能这样写。如果要这样写，需要增加很多条件。
            //----因为我懒，所以，就不写了。以后不懒了，什么时候想起来什么时候写。
            //if(score < 60)
            //{
            //    Console.WriteLine("E");
            //}
            #endregion
            #region if-else结构的方法
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    if(score>=80)//不用再写&&score<90了，因为已经将score>=90的情况排除了
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else
            //    {
            //        if (score >= 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            if(score >= 60)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else
            //            {
            //                Console.WriteLine("E");
            //            }//第四层if的else括号
            //        }//第三层if的else括号
            //    }//第二层if的else括号
            //}//第一层if的else括号
            ////最后一行代码后面有三个“}”。可以在“}”后面加上注释说明这是谁的括号。
            ////代码中最忌讳代码嵌套代码，因此尽可能减少代码的嵌套。
            #endregion
            #region if-else if结构的方法
            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            //这个else 也可以写成else if(除去以上所有情况的情况)，
            //只不过这个else if和else，两者只能存在一个。
            //选择其中一种方式使用即可
            else
            {
                Console.WriteLine("E");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
