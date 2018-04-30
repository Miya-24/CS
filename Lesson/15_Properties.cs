using System;

class User {
    private string name = "me!";
    //プロパティ
    public string Name {
        get { return this.name; } //getter
        set {
            if (value != "") {
                this.name = value;
            }
        }   //setter
    }
    //C#の6.0から
    //publie string Name { get; set; } = "me!"; 
}

class MyPoperties {
    static void Main() {
        User user = new User();
        Console.WriteLine(user.Name);
        user.Name = "Toshiki";
        Console.WriteLine(user.Name);
        user.Name = "";     //空文字はセットされない
        Console.WriteLine(user.Name);
    }
}