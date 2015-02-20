using System;

class PrintASequence
{
    static void Main()
    {
        int a = 2;
        int b = -3;

        for (int i = 0; i < 10; i = i + 2)
        {
            Console.WriteLine("{0} {1}", a, b);
            a = a + 2;
            b = b - 2;
        }
    }
}

