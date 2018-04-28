using System;

class MyArray
{
    static void Main()
    {
        //int[] scores = new int[3];
        //scores[0] = 10;
        //scores[1] = 30;
        //scores[2] = 20;
        //宣言と初期化を同時に行う場合
        //int[] scores = new int[]  {10, 20, 30};
        //int[] scores = {10, 20, 30};

        var scores = new[] {10, 30, 20};    //型推論の配列
        //for (int i = 0; i < scores.Length; i++) {
        //    Console.WriteLine(scores[i]);
        //}
        foreach (int score in scores) {
            Console.WriteLine(score);
        }
        scores[1] = 40;
        Console.WriteLine(scores[1]);
    }
}