using System;
using System.Collections.Generic;

class Int
{
    public static void divide(int a, int b)
    {
        int quotient = 0;

        try
        {
            quotient = a / b;
        }
        catch (System.DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, quotient);
        }
    }
}
