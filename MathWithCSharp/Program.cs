using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Exercise1();

        Exercise2();

        Console.WriteLine("\n");
        Console.WriteLine("Enter to exit...");
        Console.ReadLine();
    }

    public static void Exercise1() {

        //If we list all the natural numbers below $10$ that are multiples of 3 or 5, we get 3, 5, 6 and 9.
        //The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000

        int sum = 0;
        for (int i = 1; i < 1000; i++) {

            if (i % 3 == 0 || i % 5 == 0) {
                sum += i;
            }
        }
        Console.WriteLine($"Soma: {sum}");
    }

    public static void Exercise2() {
        int term1 = 1;
        int term2 = 2;
        int v = 0;

        //t + t2 = v; t = t2; t2 = v;
        //while (v < 4000000) {
        //    v = term1 + term2;
        //    term1 = term2;
        //    term2 = v;
        //}
        while (term2 <= 4000000) {
            if (term2 % 2 == 0)
                v += term2;

            int temp = term1 + term2;
            term1 = term2;
            term2 = temp;
        }

        Console.WriteLine("Soma dos termos pares: " + v);
    }

}

