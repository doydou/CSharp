using System;

namespace lesson9_运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符");


            #region 知识点一：赋值符号

            

            #endregion

            #region  知识点五：位运算符
            //主要用数值类型进行计算，将数值转换为2进制，在进行位运算
            //位与--& 对位运算，有0则0，多个数位运算时，从做到右依次计算
            int a = 2;//010
            int b = 4;//100
            int c = a & b;
            Console.WriteLine(c);
            
            //位或-- |
            //对位运算有1则1
            a = 1;//001
            b = 2;//010
            c = a | b;
            Console.WriteLine(c);
            
            //异或-- ^
            //相同为0 不用为1
            a = 1; //001
            b = 5; //101
            c = a ^ b;
            Console.WriteLine(c);
            
            //位取反 ~
            //对位运算，0变1 1变0
            a = 5; 
            // 0000 0000 0000 0000 0000 0000 0000 0101
            // 1111 1111 1111 1111 1111 1111 1111 1010
            // 反码补码知识  
            c = ~a;
            Console.WriteLine(c);
            
            //左移<< 和 右移>>
            //让一个数的2进制数进行左移和右移。
            
            
            #endregion


            #region 知识点六：三目运算符

            //3个空位，两个符号


            #endregion
        }
    }
}