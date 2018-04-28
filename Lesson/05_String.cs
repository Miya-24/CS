using System;

class MyString
{
    static void Main()
    {
        Console.WriteLine("Hello" + "Wrold");

        // \n, \t
        Console.WriteLine("hell\no wo\trld");

        var name = "toshiki";
        var score = 50.3;
        Console.WriteLine(string.Format("{0} [{1}]", name, score));

        Console.WriteLine($"{name} [{score}]");
        Console.WriteLine($"{name, 10} [{score}]"); //10文字右詰め
        Console.WriteLine($"{name, -10} [{score, 10}]");    //10文字左詰め
        Console.WriteLine($"{name, -10} [{score, 10:0.00}]");   //浮動小数点数の桁数指定
        Console.WriteLine($"{name, -10} [{score + 25, 10:0.00}]");
    }
}