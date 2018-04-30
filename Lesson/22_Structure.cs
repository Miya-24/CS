using System;

// 構造体
struct Point {
    public int X { get; }   //インスタンス化のとき0で初期化
    public int Y { get; }
    //コンストラクタ
    public Point(int x, int y) {
        X = x;
        Y = y;
    }
    public void GetInfo() {
        Console.WriteLine($"{X} : {Y}");
    }
}

class MyStructur {
    static void Main() {
        Point p1 = new Point(5, 3);
        Point p2 = new Point(12, 4);

        p1.GetInfo();
        p2.GetInfo();
    }
}