using System; using System.Linq;
namespace CSharpBook.Chapter13
{
    class IntroToLINQ
    {
        static void Main()
        {   //步骤1. 获取数据源
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            //步骤2. 创建查询：从整数数组中返回所有偶数
            //方法1：使用查询方法声明查询变量
            var numQuery1 = numbers.Where((num) => (num % 2) == 0);
            //方法2：使用查询表达式声明查询变量
            var numQuery2 =         //查询变量（用以存储查询）
                from num in numbers  //必须以from子句开头：指定数据源和范围变量
                where (num % 2) == 0 //筛选子句（可选）
                select num;  //必须以select子句（选择对象序列）或group子句（分组）结尾
            //步骤3. 执行查询并显示查询结果
            Console.Write("numQuery1内容如下：");//方法1（查询表达式）查询结果
            foreach (var num in numQuery1) Console.Write("{0,1} ", num);
            Console.Write("\nnumQuery2内容如下："); //方法2（查询方法）查询结果
            foreach (var num in numQuery2) Console.Write("{0,1} ", num);
            Console.ReadKey();
        }
    }
}