using System;

class MyLoopProcessing
{
    static void Main()
    {
        // while
        var i = 1;

        while (i < 10) {
            Console.WriteLine($"loop1:{i}");
            i++;
        }

        do {
            Console.WriteLine($"loop2:{i}");
            i++;
        } while (i < 10);

        //for
        //for
        for (int j = 0; j < 10; j++) {
            if (j == 5) {
                break;
            } else if (j == 2) {
                continue;
            }
            Console.WriteLine(j);
        }
    }
}