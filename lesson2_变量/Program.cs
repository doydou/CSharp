using System;

namespace lesson_2变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //函数语句块
            Console.WriteLine("变量");

            //知识点1 折叠代码
            //让编程逻辑更加清晰
            #region 知识点二 
            //变量 可以变化的容器

            //变量申明固定写法
            //变量类型 变量名 = 初始值；
            int i = 1;
            //变量类型 有14种变化

            //1.有符号的整型变量 一定范围的正负数包括0
            //sbyte -128-127
            //int -21亿-21亿多
            //short -32768-32768
            //long -9百万兆-9百万兆

            //2.无符号的整型变量 能存储一定范围 0和正数的变量类型
            //byte 0-255
            //uint 0-42亿
            //ushort 0-65535
            //ulong 0-18百万兆

            //3.浮点数
            //float 存储7-8位的有效数字
            float f = 0.1235455f;
            //double 存储15-17位有效数字
            double d = 0.123543513212;
            //decimal 存储27-28位有效数字

            //4.特殊类型
            //布尔类型 true false 表示真假的数据类型
            //char 是用来存储单个字符的变量类型
            //string 是字符串类型 存储多个字符的
            #endregion

            #region 知识点三
            //不同的变量 存储的范围和类型不一样 本质是占用的内存空间不同

            #endregion

            #region 知识点四 多个相同类型变量同时申明
            int a = 1, b = 2, c = 3;
            string s = "123", s1 = "sdk";



            #endregion

            #region 知识点五 变量初始化相关
            //变量申明时 可以不设置初始值
            int a2;
            a2 = 1;
            Console.WriteLine(a2);
            #endregion
        }
    }
}