using System;

    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite o primeiro número: ");
           	double x = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Digite o segundo número: ");
           	double y = Convert.ToDouble(Console.ReadLine());
           	
           	
           	double sub = y-x;
           	
           	Console.WriteLine("A subtração entre o primeiro e segundo número de é: " + sub);
           	Console.ReadKey(true);
        }
    }
