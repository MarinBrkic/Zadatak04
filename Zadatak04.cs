
using System;
					
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Upisi neki broj: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int x = (n - 2) + (n - 1);
        Console.WriteLine("Broj u fibonaccijevom nizu iznosi: {0}", x);
    }
}