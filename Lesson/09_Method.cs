using System;

class MyMethod
{
    //method
    static void SayHi()
    {
        Console.WriteLine("Hi!!");
    }

    //戻り値がある場合
    static string SayHello()
    {
        return "Hello!!";
    }
    //式一つ(returnのみ)だった場合
    //static string SayWorld() => "World";  //C# 6.0から

    static void Main()
    {
        SayHi();
        Console.WriteLine(SayHello());
        //Console.WriteLine(SayWorld());
    }
}