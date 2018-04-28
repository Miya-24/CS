using System;

class MyArgument
{
    static void SayHi(string name, int age = 23)    //age→初期値指定
    {
        Console.WriteLine($"Hi! {name} ({age})");
    }
    static void Main()
    {
        SayHi("Tom", 30);   //tom 30
        SayHi("Bob");   //bob 23
        SayHi(age:26, name: "Steve");   //引数を変数名で指定 //steve 26
    }
}