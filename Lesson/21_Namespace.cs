//名前空間
//using System;
using DotinstallNamespace;

namespace DotinstallNamespace {
    class User {
        public void SayHi() {
            // Console.WriteLine("Hi.");
            System.Console.WriteLine("Hi.");
        }
    }
}

class MyNamespace {
    static void Main() {
        // DotinstallNamespace.User user = new DotinstallNamespace.User;
        User user = new User();
        user.SayHi();
    }
}