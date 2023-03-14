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

            #region 输出1-100之间的整数
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            
            #endregion

            #region 求1-100之间的所有偶数的和
            
            int sum = 0;
            
            for (int i = 0; i <= 100; i = i + 2)
            {
                sum = sum + i;
            }
            
            Console.WriteLine(sum);
            #endregion

            #region 在控制台上输出九九乘法表
            
            for (int i = 1 ; i < 10 ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", j , i , j*i);
                }
                Console.WriteLine();
            }
            
            #endregion

            #region 在控制台输出如下10*10的空心星型方阵
            /*  **********
                *        *
                *        *
                *        *
                *        *
                *        *
                *        *
                *        *
                *        *
                **********   */


            for (int j = 0; j < 10; j++)//表示行数
            {
                for (int i = 0; i < 10; i++)
                    {
                        if (j==0 || j==9)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            if (i == 0 || i == 9)
                            {
                                Console.Write('*');
                            }
                            else
                            {
                                Console.Write(' ');
                            }
                        }
                    }
            Console.WriteLine();    
            }
            #endregion

            #region 在控制台上输出如下10 * 10的三角形方阵

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ( j>i )
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }    
            Console.WriteLine();
            }
            #endregion

            #region 在控制台上输出如下10行的三角形方阵
            //         *            1    1   -> 2i - 1    9    10 - i
            //        ***           2    3   -> 2i - 1    8    10 - i
            //       *****          3    5                7    10 - i
            //      *******         4    7                6    10 - i
            //     *********        5    9                5
            //    ***********       6    11               4
            //   *************      7    13               3
            //  ***************     8    15               2
            // *****************    9    17               1
            //*******************   10   19               0    10 - i


            int m = 9;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j<m)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }
            Console.WriteLine();
            }
            

            #endregion
        }
    }
}

                