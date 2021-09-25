using System;


//第一种注释 两杠注释
//第二种注释 星号注释 /*
//第三种注释 三杠注释 ///（命名空间，函数和类）

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson1_练习题讲解");

            //打印信息后不空行
            Console.Write("1");
            //打印信息后空行
            Console.WriteLine("1");

            ////检测玩家的一键输入
            //Console.ReadKey("");
            ////检测玩家的一系列输入 回车键结束
            //Console.ReadLine("");

            Console.WriteLine("请您输入用户名");
            Console.ReadLine();
            Console.WriteLine("请您输入年龄");
            Console.ReadLine();
            Console.WriteLine("请您输入班级");
            Console.ReadLine();

        }
    }
}