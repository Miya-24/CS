//継承、オーバーライド
using System;

class User {
    public string name;
    public User(string name)
    {
        this.name = name;
    }
    //オーバーライドさせる -> vertual
    public virtual void SayHi()
    {
        Console.WriteLine($"Hi, {name}.");
    }
}
//継承
//Userクラス(親クラス) -> AdminUser(子クラス)
class AdminUser: User {
    //親クラスのコンストラクタを使う -> base
    public AdminUser(string name): base(name) {}

    public virtual void SayHello()
    {
        Console.WriteLine($"Hello, {name}.");
    }
    //オーバーライドする -> override
    public override void SayHi()
    {
        Console.WriteLine($"[Admin] Hi, {name}.");
    }
}

class MyInheritance {
    static void Main()
    {
        User tom = new User("Tom");
        tom.SayHi();
        AdminUser bob = new AdminUser("Bob");
        bob.SayHi();
        bob.SayHello();
    }
}

