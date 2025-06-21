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

        //Exercise2();

        //Exercise3();

        Exercise4();

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

    public static void Exercise3() {
        long k1 = 600851475143;
        long factor = 2;

        Console.Write("Factors: ");
        while (factor * factor <= k1) {

            if(k1 % factor == 0) {
                k1 /= factor;

                Console.Write(factor + ", ");
            } else {
                factor++;
            }
        }
        Console.WriteLine( "\n" + k1);

    }

    public static void Exercise4() {
        
        int polindromo = 0;
        int k1 = 0;
        int k2 = 0;



        for (int i = 999; i >= 100; i--) {

            for(int j = i; j >= 100; j--) {

                int produto = i * j;

                if (E_Polindromo(produto) && produto > polindromo) {

                    polindromo = produto;
                    k1 = i;
                    k2 = j;
                }
            }
        }
        Console.WriteLine($"{polindromo} : {k1}, {k2}");
    }
    static bool E_Polindromo(int k3) {
        string numero = k3.ToString();
        char[] n_poli = numero.ToCharArray();
        Array.Reverse(n_poli);
        string inv_numero = new string(n_poli);
        return numero == inv_numero;
    }
}

