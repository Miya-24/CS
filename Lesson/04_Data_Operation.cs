using System;

class MyDataOperation
{
    static void Main()
    {
        var x = 10;
        Console.WriteLine(x / 3);   //3
        Console.WriteLine(x % 3);   //1
        Console.WriteLine(x / 3.0);   //3.333...
        Console.WriteLine(x / (double)3);   //3.333...

        var y = 5;
        y++;
        Console.WriteLine(y);   //6
        y--;
        Console.WriteLine(y);   //5

        var z = 6;
        z += 10;
        Console.WriteLine(z);   //16
        
        var flag = true;
        Console.WriteLine(!flag);   //false
    }
}
