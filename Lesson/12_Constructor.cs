using System;

//コンストラクタ
class User {
    public string name;
    public User(string name)
    {
        this.name = name;
    }
    //オーバーロード
    //public User()
    //{
    //  this.name = "nobody";
    //}
    public User(): this("nobody") {}

    public void SayHi()
    {
        Console.WriteLine($"Hi, {name}.");
    }
}

class MyConstructor {
    static void Main()
    {
        //User user = new User();
        //user.SayHi();
        User tom = new User("Tom");
        tom.SayHi();    //Hi, Tom.
        User user = new User();
        user.SayHi();   //Hi, nobody.
    }
}