using System;

// Generic
// 汎用化されたデータ型でクラスなどを作れる
// class MyInteger {
//     public void GetThree(int x) {
//         Console.WriteLine(x);
//         Console.WriteLine(x);
//         Console.WriteLine(x);
//     }
// }
// GetThree()をデータ型として汎用化
class MyData<T> {
    public void GetThree(T x) {
        Console.WriteLine(x);
        Console.WriteLine(x);
        Console.WriteLine(x);
    }
}

class MyGeneric {
    static void Main() {
        // MyInteger mi = new MyInteger();
        // mi.GetThree(20);
        //string型
        MyData<string> s = new MyData<string>();
        s.GetThree("Hello.");
        //double型
        MyData<double> d = new MyData<double>();
        d.GetThree(32.1);
    }
}