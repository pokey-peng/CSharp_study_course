using System;
public class InvalidNumberException : Exception
{
    public InvalidNumberException() { }               //默认构造方法
    public InvalidNumberException(String message) : base((message + "非法数值（< 0）"))
    {   //带1个String参数的构造方法
    }
}

