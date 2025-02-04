using System;

namespace Resto
{
    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite o primeiro número: ");
           	double x = Convert.ToDouble(Console.ReadLine());
           	
           	double resto = x % 2;
           	
           	Console.WriteLine("O restante da divisão do número " + x + " é: " + resto);
           	Console.ReadKey(true);
        }
    }
}
