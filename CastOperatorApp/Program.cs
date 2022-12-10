using System;
class CastOperatorApp {
    public static void Main() {
        int i = 0Xffff;
        short s;
        s = (short)i;
        Console.WriteLine("i = " + i);
        Console.WriteLine("s = " + s);
    }
}
