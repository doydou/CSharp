using System;

namespace lesson_转义字符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("转义字符!");
            //它是字符串的一部分，用来表示一些特殊含义的字符，比如空格，引号

            #region 知识点一 转义字符的使用
            //固定写法 \字符
            //不同的 \和字符的组合 表示不同的含义
            
            //常用转义字符
            //单引号 \'
            string str = "\'哈哈哈\'";
            Console.WriteLine(str);
            
            //双引号
            //换行
            //斜杠
            
            //不常用转义字符
            //制表符 \t
            //光标退格 \b
            //空字符 \0
            //警报音 \a
            #endregion

            #region 知识点二 取消转义字符
            
            string str2 = @"哈哈\哈";
            Console.WriteLine(str2);
            #endregion



        }
    }
}