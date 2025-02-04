using System;

    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite um número: ");
           	double x = Convert.ToDouble(Console.ReadLine());
           	
           	double quadrado = x*x;
           	
           	Console.WriteLine("A potenciação de " + x + " é: " + quadrado);
           	Console.ReadKey(true);
        }
    }
