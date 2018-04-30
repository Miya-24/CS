using System;

//interface
interface ISharable {
    //メソッドやプロパティを含めることができる
    //抽象メソッド。修飾子はpublic
    void Share();      
}

class User: ISharable {
    //実装時にoverrideは不要
    public void Share() {
        Console.WriteLine("Now Sharing...");
    }
}

class MyInterface {
    static void Main() {
        User user = new User();
        user.Share();
    }
}