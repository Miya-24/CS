using System;

//列挙型
enum Direction {
    Stay = 0,
    Right = 1,
    Left = -1
}

class MyEnumeratedType {
    static void Main() {
        Direction dir = Direction.Right;
        //Console.WriteLine((int)Direction.Right);
        switch (dir){
        case Direction.Stay:
            //そのまま
            Console.WriteLine("Stay.");
            break;
        case Direction.Right:
            //右へ
            Console.WriteLine("Right.");
            break;
        case Direction.Left:
            //左へ
            Console.WriteLine("Left.");
            break;
        default:
            break;
        }
    }
}