using System;

class MyConditionalBranch
{
    static void Main()
    {
        // if
        var score = int.Parse(Console.ReadLine());  //int型に変換 : int.Parse();

        // > >= < <= == !=
        // if (score > 80) {
        //   Console.WriteLine("Great!");
        // } else if (score > 60) {
        //   Console.WriteLine("Good!");
        // } else {
        //   Console.WriteLine("so so ...!");
        // }
        Console.WriteLine((score > 80) ? "Great" : "so so ...");

        //switch
        var signal = Console.ReadLine();

        switch(signal) {
        case "red":
            Console.WriteLine("Stop!");
            break;
        case "blue":
        case "green":
            Console.WriteLine("Go!");
            break;
        case "yellow":
            Console.WriteLine("Caution!");
            break;
        default:
            Console.WriteLine("wrong signal!");
            break;
        }
    }
}