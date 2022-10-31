using System;

namespace lesson12_条件运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件语句");
            

            #region 知识点一 if语句
            //if（bool类型值）-（语句块）-else—（语句块）
            //if语句后不用分号且可以嵌套
            

            #endregion

            #region 知识点二 switch语句
            //switch只判断变量是否等于一个变量值
            //switch--case --break(无数个case)--（default_当上面的case的条件都不满足时）--break
            int a = 3;
            switch (a)
            {
                case 1:
                    Console.WriteLine("a=1");
                    break;                
                case 3:
                    Console.WriteLine("a=3");
                    break;
                default:
                    Console.WriteLine("都不对");
                    break;

            }
            //default可忽略
            //可自定义常量
            //贯穿 满足某些条件时，不用写case后面的break。

            #endregion
        }
    }
}