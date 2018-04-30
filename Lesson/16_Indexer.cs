using System;

class Team
{
    private string[] members = new string[3];
    //インデクサ : クラスの配列にインデックスを使う
    public string this[int i] {
        get { return this.members[i]; }
        set { this.members[i] = value; }
    }
}

class MyIndexer
{
    static void Main() {
        Team giants = new Team();   //インスタンスの作成
        giants[0] = "Takahashi";
        giants[1] = "Abe";
        giants[2] = "Sakamoto";
        Console.WriteLine(giants[1]);
    }
}