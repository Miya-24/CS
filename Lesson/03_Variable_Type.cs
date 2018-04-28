using System;

class MyVariable_Type
{
    static void Main()
    {
        //文字列 : string
        //文字 : char
        string s = "Hello";
        char c = 'a';

        //整数値
        //byte, short, int, long
        int i = 100;

        //浮動小数点
        //double, float
        double d = 123.45;
        float f = 23.3f;    //F or f をつける

        //論理値
        //bool
        bool flag = true;

        //型推論
        var x = 5;  //int
        var y = "World"; //string
    }
}