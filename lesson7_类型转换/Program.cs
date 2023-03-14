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
            //大范围转小范围c#中的显式转换和隐式转换是两种类型的转换。隐式转换是由系统自动进行的，不会导致数据丢失或异常，
            //例如从小的整数类型转换为大的整数类型，或从派生类转换为基类。
            //显式转换是需要使用强制转换表达式进行的，可能会导致数据丢失或异常，例如从大的整数类型转换为小的整数类型，或从基类转换为派生类。

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