using System;

//对应教程中的解决方案“0505.Net基础班第四天”项目“_03switch-case”
//switch-case结构
namespace _038_1_SwitchCaseStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //李四的年终工作评定，        如果定为A级，则工资涨500元；
            //如果定为B级，则工资涨200元；如果定为C级，工资不变；
            //如果定为D级，工资降200元；  如果定为E级，工资降500元。
            //设李四的原工资为5000，请用户输入李四的评级,然后显示李四来年的工资。
            double salary = 5000;
            bool b = true;
            Console.WriteLine("请输入对李四的年终评定：");
            //a b c d e 乱七八糟
            string level = Console.ReadLine();
            #region if-else if结构
            //if (level == "A")
            //{
            //    salary += 500;
            //}
            //else if (level == "B")
            //{
            //    salary += 200;
            //}
            //else if (level == "C")
            //{
            //    //工资不变，因此什么都不写
            //}
            //else if (level == "D")
            //{
            //    salary -= 200;
            //}
            //else if (level == "E")
            //{
            //    salary -= 500;
            //}
            //else
            //{
            //    Console.WriteLine("输入有误，程序退出");
            //    b = false;
            //}
            #endregion
            #region 
            switch (level)
            {
                case "A":
                    salary += 500;
                    break;
                case "B":
                    salary += 200;
                    break;
                case "C":
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:
                    Console.WriteLine("输入有误，程序退出。");
                    //b = false;不能放在break后面，因为放在后面，就不执行了。
                    b = false; 
                    break;
            }
            #endregion
            if (b)
            {
                Console.WriteLine("李四来年的工资是{0}。", salary);
            }
            Console.ReadKey();
        }
    }
}
