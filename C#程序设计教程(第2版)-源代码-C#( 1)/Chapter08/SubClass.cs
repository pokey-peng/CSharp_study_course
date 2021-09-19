class Point    //等同于：class Point : Object
{
    int x, y;
}
class ColoredPoint : Point  //派生类，从Point派生
{
    int color;
}
class Colored3dPoint : ColoredPoint//派生类，从ColoredPoint派生
{
    int z;
}
