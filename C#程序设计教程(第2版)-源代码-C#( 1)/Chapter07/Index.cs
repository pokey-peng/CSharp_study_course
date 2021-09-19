using System;
namespace CSharpBook.Chapter07
{
  class TempRecord
  { // 温度数组
    private float[] temps = new float[5] { 20.1F, 20.2F, 21.5F, 26.9F, 26.8F};
    public int Length                //属性
    {
        get { return temps.Length; }   //返回数组长度
    }
    public float this[int index]        //索引器
    {
        get { return temps[index]; }   //返回指定索引所对应的数组元素
        set { temps[index] = value; }  //设置指定索引所对应的数组元素的值
    }
  }
  class MainClass
  {
    static void Main()
    {
        TempRecord tempRecord = new TempRecord();
        tempRecord[3] = 26.3F; tempRecord[4] = 62.1F;  //访问索引器
        //输出温度数组各元素的值
        for (int i = 0; i < tempRecord.Length; i++) Console.WriteLine("Element #{0} = {1}", i, tempRecord[i]);
        Console.ReadLine();
    }
  }
}
