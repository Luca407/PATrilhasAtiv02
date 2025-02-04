using System;

namespace SomaEntreDoisNumeros
{
    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite um número: ");
           	double x = Convert.ToDouble(Console.ReadLine());
           	
           	Console.WriteLine("Digite outro número: ");
           	double y = Convert.ToDouble(Console.ReadLine());
           	
           	double soma = x + y;
           	
           	Console.WriteLine("A soma de " + x + " e " + y + " é: " + soma);
           	Console.ReadKey(true);
        }
    }
}
