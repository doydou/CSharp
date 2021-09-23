using System;

namespace lession5_常量
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("常量");

            #region 知识点一 常量的申明
            //关键字 const
            //固定写法：const 变量类型 变量名 = 初始值
            //变量的申明
            int i = 10;
            //常量的申明
            const int m = 20;
            
            #endregion

            #region 知识点二 常量的特点
            //1.必须初始化
            //2.不能被修改
            
            //变量申明可以不初始化
            string name;
            //之后可以用来修改
            name = "123";
            name = "345";

            const string myName = "双";
            
            //作用：申明一些常用不变的变量
            //PI 3.1415926
            const float PI = 3.1415926f;
            Console.WriteLine(PI);
            
            #endregion

            #region 练习题1
            //常量有什么特点？
            //1 常量必须初始化
            //2 常量不能被修改
            //3 了解静态关键字static后，会进一步学习常量的特点

            #endregion

            #region 练习题2
            //你觉得在游戏开发中常量会用来干什么？
            //一些数学定理或者公式中的常量。
            //例如在游戏中玩家的最大血量是常量

            #endregion
        }
    }
}