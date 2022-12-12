using System;

namespace lesson11_循环语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("循环语句");
            //让代码可以被重复执行

            #region 知识点一 语法相关
            //打印1-20的奇数
            //int i = 1;
            //while (i < 20)
            //{
                //Console.WriteLine(i);
                //i = i + 2;  
            //}

            #endregion

            #region 知识点二 do...while循环

            



            #endregion

            #region 知识点三 for循环
            //基本语法 for(/**/;/*条件表达式*/; /*增量表达式*/)
            //{
                //循环代码逻辑
            //}
            
            


            #endregion
            //输出1-100之间的整数
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            //求1-100之间的所有偶数的和
            int sum = 0;
            for (int i = 0; i <= 100; i = i + 2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            
            //在控制台上输出九九乘法表
            
            for (int i = 1 ; i < 10 ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", j , i , j*i);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

                