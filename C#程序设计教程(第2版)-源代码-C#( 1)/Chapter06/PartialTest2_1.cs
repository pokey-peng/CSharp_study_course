//PartialTest2_1.cs
partial class PartialTest2
{
   int x;                 // 错误，x被重复声明
   partial class Inner       // 正确，Inner类是分部类
   {
      int y;
   }
}
