using System;

    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite um numero: ");
           	double x = Convert.ToDouble(Console.ReadLine());
           	
           	double raizQuadrada = Math.Sqrt(x);

		Console.WriteLine("A raiz quadrada de " + x + " é: " + raizQuadrada);
           	Console.ReadKey(true);
        }
    }

