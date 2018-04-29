using System;

class User {
    public string name = "me";
    public void SayHi()
    {
        Console.WriteLine($"Hi, {this.name}.");
    }
}

class MyClass {
    static void Main()
    {
        User user = new User();   //インスタンス
        Console.WriteLine(user.name);  //me
        user.SayHi(); //Hi, me
        user.name = "Toshiki";
        user.SayHi();   //Hi, Toshiki
    }
}