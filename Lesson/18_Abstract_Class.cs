using System;

// 抽象クラス : ほかのクラスに継承してもらうことが前提。
//　　　　　　　自身をインスタンス化できない。
// User -> Japanese, American
abstract class User {
    //抽象メソッド
    public abstract void SayHi();
}
//具象クラス
class Japanese: User {
    //メソッドを実装しないとエラーになる
    public override void SayHi() {
        Console.WriteLine("こんにちは！");
    }
}

class American: User {
    public override void SayHi() {
        Console.WriteLine("hi!");
    }
}

class MyApp {
    static void Main() {
        Japanese aki = new Japanese();
        aki.SayHi();
        American tom = new American();
        tom.SayHi();
    }
}