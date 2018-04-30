using System;
//例外処理

class MyExceptionProc: Exception {
    public MyExceptionProc(string msg): base(msg) {}
}

class MyException {
    static void Div(int a, int b) {
        try {
            if (b < 0) {
                //独自の例外処理
                throw new MyExceptionProc("not minus!");
            }
            Console.WriteLine(a / b);
        } catch (DivideByZeroException e) {
            //もともと用意されている例外処理
            Console.WriteLine(e.Message);
        } catch (MyExceptionProc e) {
            //独自の例外処理
            Console.WriteLine(e.Message);
        } finally {
            Console.WriteLine("---end---");
        }
        
    }

    static void Main() {
        Div(10, 0);
        Div(10, -3);
    }
}