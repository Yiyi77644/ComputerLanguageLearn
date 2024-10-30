using System;

//对应教程中的解决方案“0505.Net基础班第二天”项目“05变量的命名规范”
//变量的命名规范
namespace _013_1_NamingConventionsForVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;//命名格式正确
            int number1 = 10;//命名格式正确
            int number_1 = 10;//命名格式正确
            int number1_ = 10;//命名格式正确

            //命名格式错误，出现了除字母、数字、下划线以外的符号
            //变量的命名中唯一可以出现的特殊符号就是下划线。（@符号除外，现阶段不讲@符号）
            int number#%% = 10;
            //命名格式错误，以数字开头
            int 123number = 10;
        }
    }
}
