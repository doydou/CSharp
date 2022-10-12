using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("隐式转换");
            //类型转换——不同类型之间的相互转换
            //隐式转换的基本规则--不同类型之间的自动转换
            //大范围转小范围

            #region 知识点一 相同大类型之间的转换
            
            

            #endregion

            #region 知识点二 不同大类型之间的转换

            #region 无符号和有符号之间

            #region 浮点数和整数(有，无符号)之间
            //浮点数装整数

            #endregion

            #endregion
            /*总结：
             高精度（大范围）装低精度（小范围）
             double—————>float—————>整数（无符号和有符号）—————>char
             decimal—————>整数（无符号和有复好）—————>char
             string 和bool 不参与隐式转换规则*/

            #endregion
        }
    }
}