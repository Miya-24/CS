using System;

//アクセス修飾子
// public -> どのクラスからでもアクセスできる
// protected -> そのクラス、そのクラスの派生クラス(サブクラス)から
// private -> そのクラスのみ

class User {
    //public string name;
    //private string name;
    protected string name;
    public User(string name) {
        this.name = name;
    }

    public virtual void SayHi() {
        Console.WriteLine($"Hi, {name}.");
    }
}

class AdminUser: User {
    public AdminUser(string name): base(name) {}

    public virtual void SayHello() {
        Console.WriteLine($"Hello, {name}.");
    }

    public override void SayHi() {
        Console.WriteLine($"[Admin] Hi, {name}.");
    }
}

class MyAccessModifiers {
    static void Main()
    {
        User tom = new User("Tom");
        //tom.name = "Tom2";
        tom.SayHi();
        AdminUser bob = new AdminUser("Bob");
        bob.SayHi();
        bob.SayHello();
    }
}