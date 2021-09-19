namespace CSharpBook.Chapter02
{
   class TypeConversion
   {
      static void Main()
      {
        sbyte sbyte1 = 123;           //隐式类型转换：int 到 sbyte
        sbyte sbyte2 = (sbyte)123;     //显式类型转换：int 到 sbyte
        byte byte1 = 123;            //隐式类型转换：int 到 byte
        byte byte2 = (byte)123;       //显式类型转换：int 到 byte
        short short1 = 123;           //隐式类型转换：int 到 short
        short short2 = (short)123;      //显式类型转换：int 到 short
        ushort ushort1 = 123;         //隐式类型转换：int 到 ushort
        ushort ushort2 = (ushort)123;   //显式类型转换：int 到 ushort
        int int1 = 123;               //OK: 123默认为int类型
        uint uint1 = 123;             //隐式类型转换：int 到 uint
        uint uint2 = 123U;            //使用后缀 u 或 U 初始化 uint
        uint uint3 = (uint)123;         //显式类型转换：int 到 uint
        long long1 = 123;            //隐式类型转换：int 到 long
        long long2 = 123L;           //使用后缀 l 或 L 初始化 long
        long long3 = (long)123;       //显式类型转换：int 到 long
        ulong ulong1 = 123;          //隐式类型转换：int 到 ulong
        ulong ulong2 = 123UL;       //使用后缀 ul 或 UL 初始化 ulong
        ulong ulong3 = (ulong)123;    //显式类型转换：int 到 ulong
        float f1 = 12.3F;             //使用后缀 f 或 F 初始化 float
        float f2 = (float)123;          //显式类型转换：int到 float
        double d1 = 12.3;            //OK: 12.3默认为double浮点型变量
        double d2 = 12.3D;           //使用后缀 d 或 D 初始化double浮点型变量
        decimal de1 = 12.30M;	      //使用后缀 m 或 M 初始化decimal类型变量
        decimal de2 = (decimal)12.30;  //显式类型转换：double 到 decimal
        double dNumber = 23.15;      //OK: 23.15默认为double浮点型变量
        int iNumber = System.Convert.ToInt32(dNumber);      //返回 23
        bool bNumber = System.Convert.ToBoolean(dNumber);  //返回 True
        string strNumber = System.Convert.ToString(dNumber);  //返回 "23.15"
        char chrNumber = System.Convert.ToChar(strNumber[0]);//返回 '2'
     }
  }
}
